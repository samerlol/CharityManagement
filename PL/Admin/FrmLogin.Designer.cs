namespace Al3ooryCharity
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.chromeForm1 = new ChromeForm();
            this.GoToMain = new ChromeButton();
            this.btnClose = new ChromeButton();
            this.En_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new ChromeButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chromeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.GoToMain);
            this.chromeForm1.Controls.Add(this.btnClose);
            this.chromeForm1.Controls.Add(this.En_button);
            this.chromeForm1.Controls.Add(this.pictureBox1);
            this.chromeForm1.Controls.Add(this.btnlogin);
            this.chromeForm1.Controls.Add(this.label2);
            this.chromeForm1.Controls.Add(this.txtID);
            this.chromeForm1.Controls.Add(this.txtPWD);
            this.chromeForm1.Controls.Add(this.label1);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.Sizable = false;
            this.chromeForm1.Size = new System.Drawing.Size(541, 180);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.chromeForm1.TabIndex = 6;
            this.chromeForm1.Text = "لوحة الدخول";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // GoToMain
            // 
            this.GoToMain.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.GoToMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GoToMain.Image = null;
            this.GoToMain.Location = new System.Drawing.Point(233, 131);
            this.GoToMain.Name = "GoToMain";
            this.GoToMain.NoRounding = false;
            this.GoToMain.Size = new System.Drawing.Size(92, 23);
            this.GoToMain.TabIndex = 10;
            this.GoToMain.Text = "main";
            this.GoToMain.Transparent = false;
            this.GoToMain.Click += new System.EventHandler(this.chromeButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(91, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.NoRounding = false;
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "خروج";
            this.btnClose.Transparent = false;
            this.btnClose.Click += new System.EventHandler(this.exit_Click);
            // 
            // En_button
            // 
            this.En_button.Location = new System.Drawing.Point(34, 145);
            this.En_button.Name = "En_button";
            this.En_button.Size = new System.Drawing.Size(35, 23);
            this.En_button.TabIndex = 8;
            this.En_button.Text = "EN";
            this.En_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlogin.Image = null;
            this.btnlogin.Location = new System.Drawing.Point(233, 102);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.NoRounding = false;
            this.btnlogin.Size = new System.Drawing.Size(92, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "تسجيل الدخول";
            this.btnlogin.Transparent = false;
            this.btnlogin.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = ": كلمة المرور";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(34, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(291, 23);
            this.txtID.TabIndex = 3;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(34, 73);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(291, 23);
            this.txtPWD.TabIndex = 4;
            this.txtPWD.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = " : اسم المستخدم";
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(541, 180);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label label2;
        private ChromeForm chromeForm1;
        private ChromeButton btnlogin;
        private System.Windows.Forms.Button En_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ChromeButton btnClose;
        private ChromeButton GoToMain;
    }
}

