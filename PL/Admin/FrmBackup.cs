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
using System.Data.SqlClient;
namespace Al3ooryCharity.PL
{
    public partial class FrmBackup : Form
    {
        
        SqlConnection Conn = new SqlConnection(@"Server=TIMON; Database=Charity; Integrated Security= True");
        SqlCommand cmd;
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void chromeButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            //if (ofd.ShowDialog() == DialogResult.OK) {
            //    txtDistination.Text = ofd.FileName;

            //}
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK) {
                txtDistination.Text = folderBrowserDialog1.SelectedPath;
            }


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDistination.Text) || String.IsNullOrWhiteSpace(txtDistination.Text))
                MessageBox.Show("Please Fill Distination Path for the backup file.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);    
            else{    
            try
                {
                    
                    string fileName = txtDistination.Text + "\\Charity" + DateTime.Now.ToShortDateString().Replace("/", "-") + " - " + DateTime.Now.ToLongTimeString().Replace(":", "-");

                    string strQuery = "Backup Database Charity to Disk='" + fileName + ".bak'";
                    cmd = new SqlCommand(strQuery, Conn);
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Conn.Close();


                    /*
                     string backlog = txtDistination.Text + "\\CharityLog" + DateTime.Now.ToShortDateString().Replace("/", "-") + " - " + DateTime.Now.ToLongTimeString().Replace(":", "-");
                    string strQuery2 = "use master;  backup log Charity to Disk='" + backlog + ".bak' with NORECOVERY";
                    cmd = new SqlCommand(strQuery2, Conn);
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                     */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            MessageBox.Show("Create Backup File for Database Successfuly...", "BackUp Database", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
