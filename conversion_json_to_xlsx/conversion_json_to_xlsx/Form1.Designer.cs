namespace conversion_json_to_xlsx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFilePath = new Label();
            btnBrowse = new Button();
            btnConvert = new Button();
            txtFilePath = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnDownload = new Button();
            SuspendLayout();
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(51, 78);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(58, 15);
            lblFilePath.TabIndex = 0;
            lblFilePath.Text = "File Path :";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(420, 75);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Search";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(186, 158);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(128, 75);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(271, 23);
            txtFilePath.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(315, 158);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 4;
            btnDownload.Text = "Downlaod";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 285);
            Controls.Add(btnDownload);
            Controls.Add(txtFilePath);
            Controls.Add(btnConvert);
            Controls.Add(btnBrowse);
            Controls.Add(lblFilePath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilePath;
        private Button btnBrowse;
        private Button btnConvert;
        private TextBox txtFilePath;
        private OpenFileDialog openFileDialog1;
        private Button btnDownload;
    }
}
