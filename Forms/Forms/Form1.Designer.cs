namespace Forms
{
    partial class Form1
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
            this.gradient1 = new Forms.Gradient();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_phone = new System.Windows.Forms.TextBox();
            this.register_phone = new System.Windows.Forms.Label();
            this.reg_lastname = new System.Windows.Forms.TextBox();
            this.register_last = new System.Windows.Forms.Label();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.register_email = new System.Windows.Forms.Label();
            this.reg_firstname = new System.Windows.Forms.TextBox();
            this.register_first = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_form1 = new System.Windows.Forms.DataGridView();
            this.gradient2 = new Forms.Gradient();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.DarkBlue;
            this.gradient1.BottonColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.gradient2);
            this.gradient1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(800, 450);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.LightGreen;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Gender";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(486, 281);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 18);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Others";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(422, 281);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 18);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(368, 281);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 18);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(404, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Brown;
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.register_btn.FlatAppearance.BorderSize = 10;
            this.register_btn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(282, 335);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(97, 34);
            this.register_btn.TabIndex = 19;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(661, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stock Vertex Venture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(770, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // reg_phone
            // 
            this.reg_phone.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_phone.Location = new System.Drawing.Point(366, 244);
            this.reg_phone.Name = "reg_phone";
            this.reg_phone.Size = new System.Drawing.Size(198, 21);
            this.reg_phone.TabIndex = 16;
            // 
            // register_phone
            // 
            this.register_phone.AutoSize = true;
            this.register_phone.BackColor = System.Drawing.Color.Transparent;
            this.register_phone.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_phone.ForeColor = System.Drawing.Color.White;
            this.register_phone.Location = new System.Drawing.Point(240, 248);
            this.register_phone.Name = "register_phone";
            this.register_phone.Size = new System.Drawing.Size(73, 16);
            this.register_phone.TabIndex = 15;
            this.register_phone.Text = "Phone No:";
            // 
            // reg_lastname
            // 
            this.reg_lastname.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_lastname.Location = new System.Drawing.Point(366, 166);
            this.reg_lastname.Name = "reg_lastname";
            this.reg_lastname.Size = new System.Drawing.Size(198, 21);
            this.reg_lastname.TabIndex = 14;
            // 
            // register_last
            // 
            this.register_last.AutoSize = true;
            this.register_last.BackColor = System.Drawing.Color.Transparent;
            this.register_last.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_last.ForeColor = System.Drawing.Color.White;
            this.register_last.Location = new System.Drawing.Point(240, 170);
            this.register_last.Name = "register_last";
            this.register_last.Size = new System.Drawing.Size(76, 16);
            this.register_last.TabIndex = 13;
            this.register_last.Text = "Last Name:";
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.Location = new System.Drawing.Point(366, 204);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(198, 21);
            this.reg_email.TabIndex = 12;
            // 
            // register_email
            // 
            this.register_email.AutoSize = true;
            this.register_email.BackColor = System.Drawing.Color.Transparent;
            this.register_email.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_email.ForeColor = System.Drawing.Color.White;
            this.register_email.Location = new System.Drawing.Point(240, 208);
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(61, 16);
            this.register_email.TabIndex = 11;
            this.register_email.Text = "Email Id:";
            // 
            // reg_firstname
            // 
            this.reg_firstname.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_firstname.Location = new System.Drawing.Point(366, 124);
            this.reg_firstname.Name = "reg_firstname";
            this.reg_firstname.Size = new System.Drawing.Size(198, 21);
            this.reg_firstname.TabIndex = 10;
            // 
            // register_first
            // 
            this.register_first.AutoSize = true;
            this.register_first.BackColor = System.Drawing.Color.Transparent;
            this.register_first.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_first.ForeColor = System.Drawing.Color.White;
            this.register_first.Location = new System.Drawing.Point(240, 128);
            this.register_first.Name = "register_first";
            this.register_first.Size = new System.Drawing.Size(78, 16);
            this.register_first.TabIndex = 9;
            this.register_first.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // dgv_form1
            // 
            this.dgv_form1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_form1.Location = new System.Drawing.Point(12, 24);
            this.dgv_form1.Name = "dgv_form1";
            this.dgv_form1.Size = new System.Drawing.Size(211, 385);
            this.dgv_form1.TabIndex = 25;
            // 
            // gradient2
            // 
            this.gradient2.Angle = 0F;
            this.gradient2.BottonColor = System.Drawing.Color.Empty;
            this.gradient2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient2.Location = new System.Drawing.Point(331, 141);
            this.gradient2.Name = "gradient2";
            this.gradient2.Size = new System.Drawing.Size(200, 100);
            this.gradient2.TabIndex = 0;
            this.gradient2.TopColor = System.Drawing.Color.Empty;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reg_phone;
        private System.Windows.Forms.Label register_phone;
        private System.Windows.Forms.TextBox reg_lastname;
        private System.Windows.Forms.Label register_last;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label register_email;
        private System.Windows.Forms.TextBox reg_firstname;
        private System.Windows.Forms.Label register_first;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dgv_form1;
        private Gradient gradient2;
    }
}

