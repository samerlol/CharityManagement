namespace Al3ooryCharity.PL
{
    partial class FrmManageDona
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
            this.lblSumCurrentDonations = new System.Windows.Forms.Label();
            this.lblSumCurrDonations = new System.Windows.Forms.Label();
            this.lblSumTotalDonations = new System.Windows.Forms.Label();
            this.lblNSumDonations = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSavetoExcel = new System.Windows.Forms.Button();
            this.btnPrintAllDonations = new System.Windows.Forms.Button();
            this.btnPrintSelectedDonation = new System.Windows.Forms.Button();
            this.btnDonationPic = new System.Windows.Forms.Button();
            this.btnEditDonation = new System.Windows.Forms.Button();
            this.btnDeleteDonation = new System.Windows.Forms.Button();
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDonations = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chromeForm1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonations)).BeginInit();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.lblSumCurrentDonations);
            this.chromeForm1.Controls.Add(this.lblSumCurrDonations);
            this.chromeForm1.Controls.Add(this.lblSumTotalDonations);
            this.chromeForm1.Controls.Add(this.lblNSumDonations);
            this.chromeForm1.Controls.Add(this.button1);
            this.chromeForm1.Controls.Add(this.groupBox2);
            this.chromeForm1.Controls.Add(this.groupBox1);
            this.chromeForm1.Controls.Add(this.txtSearch);
            this.chromeForm1.Controls.Add(this.label1);
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
            this.chromeForm1.Size = new System.Drawing.Size(831, 543);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "إدارة تبرعات";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // lblSumCurrentDonations
            // 
            this.lblSumCurrentDonations.AutoSize = true;
            this.lblSumCurrentDonations.BackColor = System.Drawing.Color.Transparent;
            this.lblSumCurrentDonations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSumCurrentDonations.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSumCurrentDonations.Location = new System.Drawing.Point(29, 59);
            this.lblSumCurrentDonations.Name = "lblSumCurrentDonations";
            this.lblSumCurrentDonations.Size = new System.Drawing.Size(13, 15);
            this.lblSumCurrentDonations.TabIndex = 12;
            this.lblSumCurrentDonations.Text = "0";
            // 
            // lblSumCurrDonations
            // 
            this.lblSumCurrDonations.AutoSize = true;
            this.lblSumCurrDonations.Location = new System.Drawing.Point(90, 79);
            this.lblSumCurrDonations.Name = "lblSumCurrDonations";
            this.lblSumCurrDonations.Size = new System.Drawing.Size(121, 15);
            this.lblSumCurrDonations.TabIndex = 11;
            this.lblSumCurrDonations.Text = "مجموع التبرعات الحالية:";
            // 
            // lblSumTotalDonations
            // 
            this.lblSumTotalDonations.AutoSize = true;
            this.lblSumTotalDonations.BackColor = System.Drawing.Color.Transparent;
            this.lblSumTotalDonations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSumTotalDonations.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSumTotalDonations.Location = new System.Drawing.Point(29, 79);
            this.lblSumTotalDonations.Name = "lblSumTotalDonations";
            this.lblSumTotalDonations.Size = new System.Drawing.Size(13, 15);
            this.lblSumTotalDonations.TabIndex = 10;
            this.lblSumTotalDonations.Text = "0";
            // 
            // lblNSumDonations
            // 
            this.lblNSumDonations.AutoSize = true;
            this.lblNSumDonations.Location = new System.Drawing.Point(90, 59);
            this.lblNSumDonations.Name = "lblNSumDonations";
            this.lblNSumDonations.Size = new System.Drawing.Size(117, 15);
            this.lblNSumDonations.TabIndex = 9;
            this.lblNSumDonations.Text = "مجموع التبرعات الكلية:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "البحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSavetoExcel);
            this.groupBox2.Controls.Add(this.btnPrintAllDonations);
            this.groupBox2.Controls.Add(this.btnPrintSelectedDonation);
            this.groupBox2.Controls.Add(this.btnDonationPic);
            this.groupBox2.Controls.Add(this.btnEditDonation);
            this.groupBox2.Controls.Add(this.btnDeleteDonation);
            this.groupBox2.Controls.Add(this.btnAddDonation);
            this.groupBox2.Location = new System.Drawing.Point(10, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(277, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "الخروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSavetoExcel
            // 
            this.btnSavetoExcel.Location = new System.Drawing.Point(405, 48);
            this.btnSavetoExcel.Name = "btnSavetoExcel";
            this.btnSavetoExcel.Size = new System.Drawing.Size(155, 23);
            this.btnSavetoExcel.TabIndex = 6;
            this.btnSavetoExcel.Text = "حفظ اللائحة في ملف إكسيل";
            this.btnSavetoExcel.UseVisualStyleBackColor = true;
            this.btnSavetoExcel.Click += new System.EventHandler(this.btnSavetoExcel_Click);
            // 
            // btnPrintAllDonations
            // 
            this.btnPrintAllDonations.Location = new System.Drawing.Point(19, 19);
            this.btnPrintAllDonations.Name = "btnPrintAllDonations";
            this.btnPrintAllDonations.Size = new System.Drawing.Size(124, 23);
            this.btnPrintAllDonations.TabIndex = 5;
            this.btnPrintAllDonations.Text = "طباعة كل التبرعات";
            this.btnPrintAllDonations.UseVisualStyleBackColor = true;
            this.btnPrintAllDonations.Click += new System.EventHandler(this.btnPrintAllDonations_Click);
            // 
            // btnPrintSelectedDonation
            // 
            this.btnPrintSelectedDonation.Location = new System.Drawing.Point(149, 19);
            this.btnPrintSelectedDonation.Name = "btnPrintSelectedDonation";
            this.btnPrintSelectedDonation.Size = new System.Drawing.Size(122, 23);
            this.btnPrintSelectedDonation.TabIndex = 4;
            this.btnPrintSelectedDonation.Text = "طباعة التبرع المحدد";
            this.btnPrintSelectedDonation.UseVisualStyleBackColor = true;
            this.btnPrintSelectedDonation.Click += new System.EventHandler(this.btnPrintSelectedDonation_Click);
            // 
            // btnDonationPic
            // 
            this.btnDonationPic.Location = new System.Drawing.Point(277, 19);
            this.btnDonationPic.Name = "btnDonationPic";
            this.btnDonationPic.Size = new System.Drawing.Size(122, 23);
            this.btnDonationPic.TabIndex = 3;
            this.btnDonationPic.Text = "صور/ة التبرع";
            this.btnDonationPic.UseVisualStyleBackColor = true;
            this.btnDonationPic.Click += new System.EventHandler(this.btnDonationPic_Click);
            // 
            // btnEditDonation
            // 
            this.btnEditDonation.Location = new System.Drawing.Point(405, 19);
            this.btnEditDonation.Name = "btnEditDonation";
            this.btnEditDonation.Size = new System.Drawing.Size(122, 23);
            this.btnEditDonation.TabIndex = 2;
            this.btnEditDonation.Text = "تعديل بيانات التبرع";
            this.btnEditDonation.UseVisualStyleBackColor = true;
            this.btnEditDonation.Click += new System.EventHandler(this.btnEditDonation_Click);
            // 
            // btnDeleteDonation
            // 
            this.btnDeleteDonation.Location = new System.Drawing.Point(533, 19);
            this.btnDeleteDonation.Name = "btnDeleteDonation";
            this.btnDeleteDonation.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteDonation.TabIndex = 1;
            this.btnDeleteDonation.Text = "حذف التبرع المحدد";
            this.btnDeleteDonation.UseVisualStyleBackColor = true;
            this.btnDeleteDonation.Click += new System.EventHandler(this.btnDeleteDonation_Click);
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(661, 19);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(122, 23);
            this.btnAddDonation.TabIndex = 0;
            this.btnAddDonation.Text = "إضافة تبرع جديد";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDonations);
            this.groupBox1.Location = new System.Drawing.Point(10, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(808, 337);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة التبرعات";
            // 
            // dataGridViewDonations
            // 
            this.dataGridViewDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonations.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDonations.Name = "dataGridViewDonations";
            this.dataGridViewDonations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDonations.Size = new System.Drawing.Size(796, 312);
            this.dataGridViewDonations.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(287, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "قم بإدخال الكلمة المراد البحث عنها:";
            // 
            // FrmManageDona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 543);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmManageDona";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FrmManageDona";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSavetoExcel;
        private System.Windows.Forms.Button btnPrintAllDonations;
        private System.Windows.Forms.Button btnPrintSelectedDonation;
        private System.Windows.Forms.Button btnDonationPic;
        private System.Windows.Forms.Button btnEditDonation;
        private System.Windows.Forms.Button btnDeleteDonation;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridViewDonations;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSumTotalDonations;
        private System.Windows.Forms.Label lblNSumDonations;
        private System.Windows.Forms.Label lblSumCurrentDonations;
        private System.Windows.Forms.Label lblSumCurrDonations;
    }
}