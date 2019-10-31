namespace Al3ooryCharity.PL.Admin
{
    partial class FrmAddUser
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
            this.chromeForm1 = new ChromeForm();
            this.label6 = new System.Windows.Forms.Label();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassVerfiy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.ComboBox();
            this.btnClose = new ChromeButton();
            this.btnAdd = new ChromeButton();
            this.chromeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.label6);
            this.chromeForm1.Controls.Add(this.dTP);
            this.chromeForm1.Controls.Add(this.txtID);
            this.chromeForm1.Controls.Add(this.label5);
            this.chromeForm1.Controls.Add(this.txtPassVerfiy);
            this.chromeForm1.Controls.Add(this.label4);
            this.chromeForm1.Controls.Add(this.txtPass);
            this.chromeForm1.Controls.Add(this.txtUsername);
            this.chromeForm1.Controls.Add(this.label3);
            this.chromeForm1.Controls.Add(this.label2);
            this.chromeForm1.Controls.Add(this.label1);
            this.chromeForm1.Controls.Add(this.txtUserType);
            this.chromeForm1.Controls.Add(this.btnClose);
            this.chromeForm1.Controls.Add(this.btnAdd);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chromeForm1.Sizable = false;
            this.chromeForm1.Size = new System.Drawing.Size(266, 430);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "إضافة مستخدم جديد";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            this.chromeForm1.Click += new System.EventHandler(this.chromeForm1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "تاريخ الانتهاء:";
            // 
            // dTP
            // 
            this.dTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP.Location = new System.Drawing.Point(30, 305);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(207, 23);
            this.dTP.TabIndex = 12;
            this.dTP.ValueChanged += new System.EventHandler(this.dTP_ValueChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(29, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(208, 23);
            this.txtID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "اسم المعرف :";
            // 
            // txtPassVerfiy
            // 
            this.txtPassVerfiy.Location = new System.Drawing.Point(30, 249);
            this.txtPassVerfiy.Name = "txtPassVerfiy";
            this.txtPassVerfiy.Size = new System.Drawing.Size(207, 23);
            this.txtPassVerfiy.TabIndex = 9;
            this.txtPassVerfiy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassVerfiy.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "تأكيـــد الباسورد:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(30, 205);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(207, 23);
            this.txtPass.TabIndex = 7;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(30, 158);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 23);
            this.txtUsername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "الباسورد(جديد):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم الكامل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "نوع المستخدم :";
            // 
            // txtUserType
            // 
            this.txtUserType.FormattingEnabled = true;
            this.txtUserType.Items.AddRange(new object[] {
            "Manager",
            "Employee",
            "Member",
            "Donator",
            "Poverty"});
            this.txtUserType.Location = new System.Drawing.Point(30, 111);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(207, 23);
            this.txtUserType.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(25, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.NoRounding = false;
            this.btnClose.Size = new System.Drawing.Size(98, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "إلغاء";
            this.btnClose.Transparent = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.Image = null;
            this.btnAdd.Location = new System.Drawing.Point(139, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoRounding = false;
            this.btnAdd.Size = new System.Drawing.Size(98, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Transparent = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 430);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUser";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ChromeButton btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.ComboBox txtUserType;
        public System.Windows.Forms.TextBox txtPassVerfiy;
        public System.Windows.Forms.TextBox txtID;
        public ChromeForm chromeForm1;
        public ChromeButton btnAdd;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.Label label6;
    }
}