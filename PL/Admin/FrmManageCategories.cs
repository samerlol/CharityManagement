using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.Shared;

namespace Al3ooryCharity.PL.Admin
{
    public partial class FrmManageCategories : Form
    {
        SqlConnection Conn = new SqlConnection(@"Server = TIMON; Database = Charity; Trusted_Connection = True;");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FrmManageCategories()
        {
            InitializeComponent();
            //For English version
            da = new SqlDataAdapter("select * from CATEGORIES",Conn);
           txtCateID.DataBindings.Add("text", dt, "ID");
            txtCateDesc.DataBindings.Add("text", dt, "Description");
       
             /*//For Arabic version
             da = new SqlDataAdapter("select ID as 'معرف الصنف',Description as 'وصف الصنف' from CATEGORIES", Conn);
              txtCateID.DataBindings.Add("text", dt, "معرف الصنف");
            txtCateDesc.DataBindings.Add("text", dt, "وصف الصنف");*/
            da.Fill(dt);
            dGVCate.DataSource = dt;
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count);
            MessageBox.Show("erwe");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );
        }

        private void btnFirstElement_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );
        }

        private void btnLastElement_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position +1) + "  /  " + (bmb.Count );
        }

        private void btnPreviousElement_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );
        }

        private void btnNextElement_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );
        }

        private void btnNewCate_Click(object sender, EventArgs e)
        {

            bmb.AddNew();
            btnAddCate.Enabled = true;
            btnNewCate.Enabled = false;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
           // int id = bmb.Count + 1;
            txtCateID.Text = id.ToString() ;
            txtCateDesc.Focus();
            txtCateDesc.ReadOnly = false;

        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Done Adding..","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnAddCate.Enabled = false;
            btnNewCate.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );
            txtCateDesc.ReadOnly = true;
        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Done Deleting..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );

        }

        private void BtnEditCate_Click(object sender, EventArgs e)
        {
            if (txtCateDesc.ReadOnly == true)
            {
                txtCateDesc.ReadOnly = false;
            }
            else { 
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Done Deleting..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "  /  " + (bmb.Count );
            txtCateDesc.ReadOnly = true;
            }
        }

        private void btnPrintAllCate_Click(object sender, EventArgs e)
        {
            RPT.FrmDonationReport frm = new RPT.FrmDonationReport();
            RPT.RPT_Get_All_Categories myreport = new RPT.RPT_Get_All_Categories();
            myreport.Refresh();
            frm.DonationReport.ReportSource = myreport;
            frm.ShowDialog();

        }

        private void btnPrintCurrentCate_Click(object sender, EventArgs e)
        {
            RPT.FrmDonationReport frm = new RPT.FrmDonationReport();
           // RPT.RPT_Get_Single_Category myreport2 = new RPT.RPT_Get_Single_Category();
            RPT.RPT_Get_Single_Categorie myreport = new RPT.RPT_Get_Single_Categorie();
           // myreport2.SetParameterValue("@ID", Convert.ToInt32(txtCateID.Text));
             myreport.SetParameterValue("@ID", Convert.ToInt32(txtCateID.Text));
            
            frm.DonationReport.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {

            RPT.RPT_Get_All_Categories RPT_ALL_Categories = new RPT.RPT_Get_All_Categories();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions diskFileDestination = new DiskFileDestinationOptions();

            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            diskFileDestination.DiskFileName = @"G:\CategorieList22.PDF";
            export = RPT_ALL_Categories.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = diskFileDestination;
            try
            {
                RPT_ALL_Categories.Export();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
            //end save it to PDF
            MessageBox.Show("Done!..");
        }

        private void btnSaveAsPDFcurrentCate_Click(object sender, EventArgs e)
        {
            /*
           RPT.RPT_Get_Single_Categorie get_Single_Categorie = new RPT.RPT_Get_Single_Categorie();
           //RPT.CrystalReport1 get = new RPT.CrystalReport1();
            RPT.RPT_ALL_Donations get_All_Donations = new RPT.RPT_ALL_Donations();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions diskFileDestination = new DiskFileDestinationOptions();

            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            diskFileDestination.DiskFileName = @"G:\SingleCategorie2234.PDF";
            export = get_Single_Categorie.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = diskFileDestination;

            get_Single_Categorie.Refresh();
            get_Single_Categorie.SetParameterValue("@ID", Convert.ToInt32(txtCateID.Text));
            /*
            get_Single_Categorie.Refresh();
            get_Single_Categorie.SetParameterValue("@ID", Convert.ToInt32(txtCateID.Text));
            try { get_Single_Categorie.Export(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //end save it to PDF
            MessageBox.Show("Done!..");*/

            //RPT.RPT_Single_Category get_Single_Category = new RPT.RPT_Single_Category();
            //RPT.RPT_Get_Single_Category get_Single_Category = new RPT.RPT_Get_Single_Category();
            RPT.RPT_Get_Single_Category get_Single_Category = new RPT.RPT_Get_Single_Category();
           // RPT.RPT_ALL_Donations get_All_Donations = new RPT.RPT_ALL_Donations();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions diskFileDestination = new DiskFileDestinationOptions();

            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            diskFileDestination.DiskFileName = @"G:\SingleCategorie113562test.PDF";
            export = get_Single_Category.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = diskFileDestination;

            get_Single_Category.Refresh();
            get_Single_Category.SetParameterValue("@ID", Convert.ToInt32(txtCateID.Text));
            try { get_Single_Category.Export(); }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            //end save it to PDF
            MessageBox.Show("Done!..");
        }
    }
}
