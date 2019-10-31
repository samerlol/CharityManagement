using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions;
namespace Al3ooryCharity.PL
{
    public partial class FrmManageDona : Form
    {
        BL.cls_Donations Dona = new BL.cls_Donations();
        FrmAddDona AddDona;
        private static FrmManageDona frm;
        DataRowCollection DRC;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FrmManageDona getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FrmManageDona();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FrmManageDona()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();
            lblSumTotalDonations.Text = Convert.ToString(Dona.Get_SumOFDonations());
            lblSumCurrentDonations.Text = Convert.ToString(Dona.Get_SumOFDonations());
            DRC = Dona.Get_SumOFDonations().Rows;
            lblSumCurrentDonations.Text = DRC[0][0].ToString();
            lblSumTotalDonations.Text =DRC[0][0].ToString();


            //for arabic Language
            //dataGridViewDonations.DataSource = Dona.GET_ALL_Donations_Ar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDona = new FrmAddDona();
            AddDona.ShowDialog();
            dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();
            DRC = Dona.Get_SumOFDonations().Rows;

            lblSumTotalDonations.Text = DRC[0][0].ToString();
            lblSumCurrentDonations.Text = DRC[0][0].ToString();

            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*
            DataTable Dt= new DataTable();

            Dt = Dona.SearchDonation(txtSearch.Text);

            //for arabic language
            //Dt = Dona.SearchDonation_Ar(txtSearch.Text);
            dataGridViewDonations.DataSource = Dt;*/
            dataGridViewDonations.DataSource = Dona.SearchDonation_Ar(txtSearch.Text);
        }

        private void btnDeleteDonation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete This Donation?", "Delete Donation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes) {
                try
                {
                    Dona.DeleteDonation(Convert.ToInt32(dataGridViewDonations.CurrentRow.Cells[0].Value));
                    MessageBox.Show("The Selected Item has been deleted", "Delete Donation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "error While Deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();
                }
            }
        }

        private void btnEditDonation_Click(object sender, EventArgs e)
        {
            AddDona = new FrmAddDona();
            AddDona.Text = "تعديل المعونة:"+dataGridViewDonations.CurrentRow.Cells[3].Value.ToString();
            AddDona.btnAdd.Text = "تعديل";
            AddDona.label1.Text = "تعديل معونة او مساعدة";
            AddDona.categoriescombo.Text = dataGridViewDonations.CurrentRow.Cells[1].Value.ToString();
            AddDona.DonatorID.Text = dataGridViewDonations.CurrentRow.Cells[2].Value.ToString();
            AddDona.DonaTitle.Text = dataGridViewDonations.CurrentRow.Cells[3].Value.ToString();
            //filter between qunantity and amount and price .....
            AddDona.Amount.Text = dataGridViewDonations.CurrentRow.Cells[4].Value.ToString();
            AddDona.qty.Text = dataGridViewDonations.CurrentRow.Cells[5].Value.ToString();

            AddDona.Description.Text = dataGridViewDonations.CurrentRow.Cells[6].Value.ToString();
            AddDona.DateOfDona.Text = dataGridViewDonations.CurrentRow.Cells[7].Value.ToString();
            AddDona.OtherNote.Text = dataGridViewDonations.CurrentRow.Cells[8].Value.ToString();
            AddDona.ValueBox.Visible = true;
            AddDona.qty_val.Visible = true;
            if (AddDona.categoriescombo.SelectedValue.ToString() == "1" || AddDona.categoriescombo.SelectedValue.ToString() == "6")
            {
                AddDona.qty.Enabled = false;
                AddDona.Amount.Enabled = true;
            }
            else {
                AddDona.qty.Enabled = true;

            }
                AddDona.peice.Visible = true;
            AddDona.JOD.Visible = true;
           

            AddDona.ValueBox.Text = "قيمة:";
            AddDona.state = "Change";
            AddDona.DonatorID.ReadOnly = true;
            AddDona.DonatorInfo.Enabled = true;
            AddDona.DonationID = Convert.ToInt32(dataGridViewDonations.CurrentRow.Cells[0].Value.ToString());
            
            AddDona.txtDonatorName.Text = "رقم ال ID خاص للمعونة"+ AddDona.DonationID.ToString();
            
            //last time here...
            //int x = (int) this.dataGridViewDonations.CurrentRow.Cells[0].Value;
            byte[] image = (byte[])Dona.Get_Image_Donation((int)this.dataGridViewDonations.CurrentRow.Cells[0].Value).Rows[0][0];
            //byte[] image = (byte[])Dona.Get_Image_Donation(this.dataGridViewDonations.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            AddDona.pbox.Image = Image.FromStream(ms);
            AddDona.ShowDialog();
            dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();
            DRC = Dona.Get_SumOFDonations().Rows;

            lblSumTotalDonations.Text = DRC[0][0].ToString();
            lblSumCurrentDonations.Text = DRC[0][0].ToString();
            

        }

        private void btnDonationPic_Click(object sender, EventArgs e)
        {
            FrmPreview ViewImage = new FrmPreview();
            byte[] image = (byte[])Dona.Get_Image_Donation((int)this.dataGridViewDonations.CurrentRow.Cells[0].Value).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            ViewImage.pbox.Image = Image.FromStream(ms);
            
            ViewImage.ShowDialog();
        }

        private void btnPrintSelectedDonation_Click(object sender, EventArgs e)
        {
            RPT.RPT_Donation_Single myreport = new RPT.RPT_Donation_Single();
            myreport.SetParameterValue("@ID", this.dataGridViewDonations.CurrentRow.Cells[0].Value.ToString());
            RPT.FrmDonationReport myform = new RPT.FrmDonationReport();
            myform.DonationReport.ReportSource = myreport;
            myform.ShowDialog();
           
        }

        private void btnPrintAllDonations_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_Donations RPT_ALL_Donations = new RPT.RPT_ALL_Donations();
            RPT.FrmDonationReport frmDonationReport = new RPT.FrmDonationReport();
             frmDonationReport.DonationReport.ReportSource = RPT_ALL_Donations;
             frmDonationReport.ShowDialog();
           /* RPT.FrmDonationReport frmDonationReport = new RPT.FrmDonationReport();
            RPT.RPT_All_Dona all_Dona = new RPT.RPT_All_Dona();
            frmDonationReport.DonationReport.ReportSource = all_Dona;
            frmDonationReport.ShowDialog();*/
        }

        private void btnSavetoExcel_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_Donations RPT_ALL_Donations = new RPT.RPT_ALL_Donations();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions diskFileDestination = new DiskFileDestinationOptions();
            //To save it to execel
            ExcelFormatOptions excelFormat = new ExcelFormatOptions();
            diskFileDestination.DiskFileName = @"E:\text.xls";
            export = RPT_ALL_Donations.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelFormat;
            export.ExportDestinationOptions = diskFileDestination;

            //end of save excel type
            //To save it to PDF
            /*PdfFormatOptions pdfFormat = new PdfFormatOptions();
            diskFileDestination.DiskFileName = @"E:\DonationsList.PDF";
            export = RPT_ALL_Donations.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = diskFileDestination;
            */
            RPT_ALL_Donations.Export();
            //end save it to PDF
            MessageBox.Show("Done!..");
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewDonations.DataSource = Dona.SearchDonation_Ar(txtSearch.Text);

        }
    }
}
