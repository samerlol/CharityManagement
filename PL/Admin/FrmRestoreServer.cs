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
namespace Al3ooryCharity.PL
{
    public partial class FrmRestoreServer : Form
    {
        SqlConnection Conn = new SqlConnection(@"Server=DIZPC\LOL; Database=master; Integrated Security= True");
        SqlCommand cmd;
        OpenFileDialog ofd = new OpenFileDialog();

        public FrmRestoreServer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            
            try {
                string strQuery = "ALTER Database Charity SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Charity From Disk='" + txtFileName.Text + "' with replace";
                cmd = new SqlCommand(strQuery, Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show(" Backup File for Database Restored Successfuly...", "Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,ex.Source); }
            
        }

        private void chromeForm1_Click(object sender, EventArgs e)
        {

        }
    }
}
