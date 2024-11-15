namespace filter
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            noofgroupscb = new ComboBox();
            conditionpanel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(572, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 557);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 71);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter the group No:";
            // 
            // noofgroupscb
            // 
            noofgroupscb.FormattingEnabled = true;
            noofgroupscb.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            noofgroupscb.Location = new Point(177, 68);
            noofgroupscb.Name = "noofgroupscb";
            noofgroupscb.Size = new Size(121, 23);
            noofgroupscb.TabIndex = 2;
            noofgroupscb.SelectedIndexChanged += noofgroupscb_SelectedIndexChanged;
            // 
            // conditionpanel1
            // 
            conditionpanel1.Location = new Point(48, 136);
            conditionpanel1.Name = "conditionpanel1";
            conditionpanel1.Size = new Size(460, 359);
            conditionpanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 560);
            Controls.Add(conditionpanel1);
            Controls.Add(noofgroupscb);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox noofgroupscb;
        private Panel conditionpanel1;
    }
}
