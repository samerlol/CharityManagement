namespace Al3ooryCharity.PL
{
    partial class FrmRestoreServer
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
            this.btnClose = new ChromeButton();
            this.btnRestore = new ChromeButton();
            this.btnBrowse = new ChromeButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.chromeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.btnClose);
            this.chromeForm1.Controls.Add(this.btnRestore);
            this.chromeForm1.Controls.Add(this.btnBrowse);
            this.chromeForm1.Controls.Add(this.label1);
            this.chromeForm1.Controls.Add(this.txtFileName);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chromeForm1.Sizable = true;
            this.chromeForm1.Size = new System.Drawing.Size(381, 231);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "أستعادة القاعدة بيانات";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            this.chromeForm1.Click += new System.EventHandler(this.chromeForm1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(31, 146);
            this.btnClose.Name = "btnClose";
            this.btnClose.NoRounding = false;
            this.btnClose.Size = new System.Drawing.Size(145, 56);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "إلغاء";
            this.btnClose.Transparent = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestore.Image = null;
            this.btnRestore.Location = new System.Drawing.Point(204, 146);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.NoRounding = false;
            this.btnRestore.Size = new System.Drawing.Size(145, 56);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.Text = "استعادة النسخة الاحتياطية";
            this.btnRestore.Transparent = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.Image = null;
            this.btnBrowse.Location = new System.Drawing.Point(31, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NoRounding = false;
            this.btnBrowse.Size = new System.Drawing.Size(39, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Transparent = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "رجاء قم بتحديد مسار تواجد النسخة الاحتياطية";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(91, 87);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(258, 23);
            this.txtFileName.TabIndex = 10;
            // 
            // FrmRestoreServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 231);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRestoreServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRestoreServer";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        private ChromeButton btnClose;
        private ChromeButton btnRestore;
        private ChromeButton btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
    }
}