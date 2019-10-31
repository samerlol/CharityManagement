namespace Al3ooryCharity.PL
{
    partial class FrmPreview
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
            this.pbox = new System.Windows.Forms.PictureBox();
            this.chromeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.pbox);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.Sizable = true;
            this.chromeForm1.Size = new System.Drawing.Size(501, 398);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "صورة  المعونة / التبرع";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // pbox
            // 
            this.pbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbox.Location = new System.Drawing.Point(0, 29);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(501, 369);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 398);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPreview";
            this.Text = "FrmPreview";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        public System.Windows.Forms.PictureBox pbox;
    }
}