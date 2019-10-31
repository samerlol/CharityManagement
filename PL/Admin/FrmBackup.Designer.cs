namespace Al3ooryCharity.PL
{
    partial class FrmBackup
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
            this.txtDistination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.btnClose = new ChromeButton();
            this.btnCreate = new ChromeButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chromeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.txtDistination);
            this.chromeForm1.Controls.Add(this.label1);
            this.chromeForm1.Controls.Add(this.Browse);
            this.chromeForm1.Controls.Add(this.btnClose);
            this.chromeForm1.Controls.Add(this.btnCreate);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.Sizable = true;
            this.chromeForm1.Size = new System.Drawing.Size(385, 228);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "عمل نسخة احتياطية";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // txtDistination
            // 
            this.txtDistination.Location = new System.Drawing.Point(75, 89);
            this.txtDistination.Name = "txtDistination";
            this.txtDistination.Size = new System.Drawing.Size(282, 23);
            this.txtDistination.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 70);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "رجاء قم بتحديد مسار حفظ النسخة الاحتياطية";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(32, 89);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(37, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(32, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.NoRounding = false;
            this.btnClose.Size = new System.Drawing.Size(142, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "إلغاء";
            this.btnClose.Transparent = false;
            this.btnClose.Click += new System.EventHandler(this.chromeButton2_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.Image = null;
            this.btnCreate.Location = new System.Drawing.Point(215, 145);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NoRounding = false;
            this.btnCreate.Size = new System.Drawing.Size(142, 53);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "إنشاء نسخة احتياطية";
            this.btnCreate.Transparent = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 228);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBackup";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        private System.Windows.Forms.TextBox txtDistination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Browse;
        private ChromeButton btnClose;
        private ChromeButton btnCreate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}