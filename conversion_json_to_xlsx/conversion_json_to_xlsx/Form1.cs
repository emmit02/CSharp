using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.Collections.Generic;

namespace conversion_json_to_xlsx
{
    public partial class Form1 : Form
    {
        private string xlsxFilePath; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName; // Display the selected file path in the TextBox
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string jsonFilePath = txtFilePath.Text;
            if (string.IsNullOrEmpty(jsonFilePath) || !File.Exists(jsonFilePath))
            {
                MessageBox.Show("Please select a valid JSON file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            xlsxFilePath = Path.ChangeExtension(jsonFilePath, ".xlsx");

            try
            {
                // Read and convert the JSON with nested values
                string jsonData = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON into a dictionary (with key as string, and value as another dictionary)
                var jsonRecords = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(jsonData);

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    if (jsonRecords != null && jsonRecords.Count > 0)
                    {
                        // Write the headers from the first record
                        var firstRecord = jsonRecords.Values.GetEnumerator();
                        firstRecord.MoveNext(); // Move to the first record
                        var firstRowKeys = firstRecord.Current.Keys;

                        int colIndex = 1;
                        foreach (var key in firstRowKeys)
                        {
                            worksheet.Cells[1, colIndex++].Value = key;
                        }

                        // Write the values
                        int rowIndex = 2;
                        foreach (var record in jsonRecords)
                        {
                            colIndex = 1;
                            foreach (var value in record.Value.Values)
                            {
                                worksheet.Cells[rowIndex, colIndex++].Value = value;
                            }
                            rowIndex++;
                        }
                    }

                    // Save the Excel file
                    File.WriteAllBytes(xlsxFilePath, package.GetAsByteArray());
                }

                MessageBox.Show("Conversion successful! XLSX file created at: " + xlsxFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during conversion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(xlsxFilePath) || !File.Exists(xlsxFilePath))
            {
                MessageBox.Show("No converted file found. Please convert a JSON file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the default Downloads folder
                string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                string downloadFilePath = Path.Combine(downloadFolder, Path.GetFileName(xlsxFilePath));

                // Copy the file to the Downloads folder
                File.Copy(xlsxFilePath, downloadFilePath, true);

                MessageBox.Show("File successfully downloaded to: " + downloadFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during download: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
