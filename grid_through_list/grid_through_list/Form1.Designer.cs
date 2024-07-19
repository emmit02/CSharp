namespace grid_through_list
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
            label2 = new Label();
            label3 = new Label();
            txt_id = new TextBox();
            txt_fn = new TextBox();
            txtln = new TextBox();
            txt_profession = new TextBox();
            label4 = new Label();
            btn_add = new Button();
            COL_ID = new DataGridViewTextBoxColumn();
            COL_NAME = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME });
            dataGridView1.Location = new Point(27, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(495, 229);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Person Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 40);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 40);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(96, 67);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(122, 23);
            txt_id.TabIndex = 4;
            // 
            // txt_fn
            // 
            txt_fn.Location = new Point(258, 67);
            txt_fn.Name = "txt_fn";
            txt_fn.Size = new Size(122, 23);
            txt_fn.TabIndex = 5;
            // 
            // txtln
            // 
            txtln.Location = new Point(419, 67);
            txtln.Name = "txtln";
            txtln.Size = new Size(122, 23);
            txtln.TabIndex = 6;
            // 
            // txt_profession
            // 
            txt_profession.Location = new Point(97, 129);
            txt_profession.Name = "txt_profession";
            txt_profession.Size = new Size(437, 23);
            txt_profession.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 102);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Profession";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(28, 50);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(41, 85);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // COL_ID
            // 
            COL_ID.HeaderText = "Id";
            COL_ID.Name = "COL_ID";
            // 
            // COL_NAME
            // 
            COL_NAME.HeaderText = "Name";
            COL_NAME.Name = "COL_NAME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 438);
            Controls.Add(btn_add);
            Controls.Add(txt_profession);
            Controls.Add(label4);
            Controls.Add(txtln);
            Controls.Add(txt_fn);
            Controls.Add(txt_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_id;
        private TextBox txt_fn;
        private TextBox txtln;
        private TextBox txt_profession;
        private Label label4;
        private Button btn_add;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
    }
}
