namespace Forms
{
    partial class dataGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradient1 = new Forms.Gradient();
            this.dgv_btn_id = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dgv_btn_display = new System.Windows.Forms.Button();
            this.dgv_btn_update = new System.Windows.Forms.Button();
            this.dgv_btn_delete = new System.Windows.Forms.Button();
            this.dgv_btn_insert = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.dgv_lbl_year = new System.Windows.Forms.ComboBox();
            this.dg_year = new System.Windows.Forms.Label();
            this.dgv_lbl_branch = new System.Windows.Forms.ComboBox();
            this.dg_branch = new System.Windows.Forms.Label();
            this.dgv_lbl_coarse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_next = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_next)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.comboBox3.Location = new System.Drawing.Point(466, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(165, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CSE",
            "EC",
            "ME",
            "FINANCE",
            "HR"});
            this.comboBox2.Location = new System.Drawing.Point(214, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "B.Tech",
            "M.Tech",
            "BBA",
            "MBA",
            "LLB"});
            this.comboBox1.Location = new System.Drawing.Point(214, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(144, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Branch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(422, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(760, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fill Your Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 231);
            this.dataGridView1.TabIndex = 9;
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.DarkBlue;
            this.gradient1.BottonColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.dgv_btn_id);
            this.gradient1.Controls.Add(this.label);
            this.gradient1.Controls.Add(this.dgv_btn_display);
            this.gradient1.Controls.Add(this.dgv_btn_update);
            this.gradient1.Controls.Add(this.dgv_btn_delete);
            this.gradient1.Controls.Add(this.dgv_btn_insert);
            this.gradient1.Controls.Add(this.exit);
            this.gradient1.Controls.Add(this.dgv_lbl_year);
            this.gradient1.Controls.Add(this.dg_year);
            this.gradient1.Controls.Add(this.dgv_lbl_branch);
            this.gradient1.Controls.Add(this.dg_branch);
            this.gradient1.Controls.Add(this.dgv_lbl_coarse);
            this.gradient1.Controls.Add(this.label7);
            this.gradient1.Controls.Add(this.label6);
            this.gradient1.Controls.Add(this.dgv_next);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(800, 450);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.LightGreen;
            // 
            // dgv_btn_id
            // 
            this.dgv_btn_id.Location = new System.Drawing.Point(91, 63);
            this.dgv_btn_id.Name = "dgv_btn_id";
            this.dgv_btn_id.Size = new System.Drawing.Size(100, 25);
            this.dgv_btn_id.TabIndex = 25;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(29, 70);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 18);
            this.label.TabIndex = 24;
            this.label.Text = "Id:";
            // 
            // dgv_btn_display
            // 
            this.dgv_btn_display.BackColor = System.Drawing.Color.Brown;
            this.dgv_btn_display.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_btn_display.FlatAppearance.BorderSize = 10;
            this.dgv_btn_display.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_btn_display.ForeColor = System.Drawing.Color.White;
            this.dgv_btn_display.Location = new System.Drawing.Point(510, 155);
            this.dgv_btn_display.Name = "dgv_btn_display";
            this.dgv_btn_display.Size = new System.Drawing.Size(97, 34);
            this.dgv_btn_display.TabIndex = 23;
            this.dgv_btn_display.Text = "display";
            this.dgv_btn_display.UseVisualStyleBackColor = false;
            // 
            // dgv_btn_update
            // 
            this.dgv_btn_update.BackColor = System.Drawing.Color.Brown;
            this.dgv_btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_btn_update.FlatAppearance.BorderSize = 10;
            this.dgv_btn_update.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_btn_update.ForeColor = System.Drawing.Color.White;
            this.dgv_btn_update.Location = new System.Drawing.Point(404, 155);
            this.dgv_btn_update.Name = "dgv_btn_update";
            this.dgv_btn_update.Size = new System.Drawing.Size(97, 34);
            this.dgv_btn_update.TabIndex = 22;
            this.dgv_btn_update.Text = "Update";
            this.dgv_btn_update.UseVisualStyleBackColor = false;
            // 
            // dgv_btn_delete
            // 
            this.dgv_btn_delete.BackColor = System.Drawing.Color.Brown;
            this.dgv_btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_btn_delete.FlatAppearance.BorderSize = 10;
            this.dgv_btn_delete.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_btn_delete.ForeColor = System.Drawing.Color.White;
            this.dgv_btn_delete.Location = new System.Drawing.Point(300, 155);
            this.dgv_btn_delete.Name = "dgv_btn_delete";
            this.dgv_btn_delete.Size = new System.Drawing.Size(97, 34);
            this.dgv_btn_delete.TabIndex = 21;
            this.dgv_btn_delete.Text = "Delete";
            this.dgv_btn_delete.UseVisualStyleBackColor = false;
            // 
            // dgv_btn_insert
            // 
            this.dgv_btn_insert.BackColor = System.Drawing.Color.Brown;
            this.dgv_btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_btn_insert.FlatAppearance.BorderSize = 10;
            this.dgv_btn_insert.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_btn_insert.ForeColor = System.Drawing.Color.White;
            this.dgv_btn_insert.Location = new System.Drawing.Point(193, 155);
            this.dgv_btn_insert.Name = "dgv_btn_insert";
            this.dgv_btn_insert.Size = new System.Drawing.Size(97, 34);
            this.dgv_btn_insert.TabIndex = 20;
            this.dgv_btn_insert.Text = "Insert";
            this.dgv_btn_insert.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(770, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(18, 17);
            this.exit.TabIndex = 18;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dgv_lbl_year
            // 
            this.dgv_lbl_year.FormattingEnabled = true;
            this.dgv_lbl_year.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.dgv_lbl_year.Location = new System.Drawing.Point(606, 94);
            this.dgv_lbl_year.Name = "dgv_lbl_year";
            this.dgv_lbl_year.Size = new System.Drawing.Size(164, 26);
            this.dgv_lbl_year.TabIndex = 7;
            // 
            // dg_year
            // 
            this.dg_year.AutoSize = true;
            this.dg_year.BackColor = System.Drawing.Color.Transparent;
            this.dg_year.ForeColor = System.Drawing.Color.White;
            this.dg_year.Location = new System.Drawing.Point(556, 102);
            this.dg_year.Name = "dg_year";
            this.dg_year.Size = new System.Drawing.Size(41, 18);
            this.dg_year.TabIndex = 6;
            this.dg_year.Text = "Year:";
            // 
            // dgv_lbl_branch
            // 
            this.dgv_lbl_branch.FormattingEnabled = true;
            this.dgv_lbl_branch.Items.AddRange(new object[] {
            "CSE",
            "EC",
            "ME",
            "HR",
            "FINANCE"});
            this.dgv_lbl_branch.Location = new System.Drawing.Point(351, 94);
            this.dgv_lbl_branch.Name = "dgv_lbl_branch";
            this.dgv_lbl_branch.Size = new System.Drawing.Size(164, 26);
            this.dgv_lbl_branch.TabIndex = 5;
            // 
            // dg_branch
            // 
            this.dg_branch.AutoSize = true;
            this.dg_branch.BackColor = System.Drawing.Color.Transparent;
            this.dg_branch.ForeColor = System.Drawing.Color.White;
            this.dg_branch.Location = new System.Drawing.Point(293, 102);
            this.dg_branch.Name = "dg_branch";
            this.dg_branch.Size = new System.Drawing.Size(56, 18);
            this.dg_branch.TabIndex = 4;
            this.dg_branch.Text = "Branch:";
            // 
            // dgv_lbl_coarse
            // 
            this.dgv_lbl_coarse.FormattingEnabled = true;
            this.dgv_lbl_coarse.Items.AddRange(new object[] {
            "B.tech",
            "M.tech",
            "bba",
            "mba"});
            this.dgv_lbl_coarse.Location = new System.Drawing.Point(91, 94);
            this.dgv_lbl_coarse.Name = "dgv_lbl_coarse";
            this.dgv_lbl_coarse.Size = new System.Drawing.Size(164, 26);
            this.dgv_lbl_coarse.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Coarse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(299, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fill Your Information";
            // 
            // dgv_next
            // 
            this.dgv_next.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_next.Location = new System.Drawing.Point(28, 216);
            this.dgv_next.Name = "dgv_next";
            this.dgv_next.Size = new System.Drawing.Size(742, 203);
            this.dgv_next.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataGridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_next;
        private System.Windows.Forms.ComboBox dgv_lbl_coarse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dgv_lbl_branch;
        private System.Windows.Forms.Label dg_branch;
        private System.Windows.Forms.ComboBox dgv_lbl_year;
        private System.Windows.Forms.Label dg_year;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button dgv_btn_display;
        private System.Windows.Forms.Button dgv_btn_update;
        private System.Windows.Forms.Button dgv_btn_delete;
        private System.Windows.Forms.Button dgv_btn_insert;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox dgv_btn_id;
    }
}