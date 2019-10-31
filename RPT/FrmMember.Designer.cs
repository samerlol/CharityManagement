namespace Al3ooryCharity.RPT
{
    partial class FrmMember
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
            this.MemberList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MemberList
            // 
            this.MemberList.ActiveViewIndex = -1;
            this.MemberList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemberList.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberList.Location = new System.Drawing.Point(0, 0);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(619, 457);
            this.MemberList.TabIndex = 0;
            this.MemberList.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 457);
            this.Controls.Add(this.MemberList);
            this.Name = "FrmMember";
            this.Text = "FrmMember";
            this.ResumeLayout(false);

        }

        #endregion

        private RPT_GetMemberList RPT_GetMemberList1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer MemberList;
    }
}