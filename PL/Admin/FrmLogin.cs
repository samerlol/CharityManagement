using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al3ooryCharity
{
    public partial class FrmLogin : Form
    {
        BL.cls_login log = new BL.cls_login();
        FrmChangePass changePass;
        
        
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login_Click(object sender, EventArgs e)
        {
            
            DataTable dt = log.Login(txtID.Text, txtPWD.Text);
            FrmAddDona fAD = new FrmAddDona();
            FrmChangePass fCP = new FrmChangePass();
            FrmCreateIDs fCI = new FrmCreateIDs();
            FrmDistDonations fDD = new FrmDistDonations();
            FrmMemList fML = new FrmMemList();
            FrmPayments fP = new FrmPayments();
            FrmReports fR = new FrmReports();
            PL.FrmBackup fB = new PL.FrmBackup();
            PL.FrmConfig fC = new PL.FrmConfig();
            PL.FrmDonaList fDL = new PL.FrmDonaList();
            PL.FrmManageDona fMD = new PL.FrmManageDona();
            PL.FrmManageMem fMM = new PL.FrmManageMem();
            PL.FrmPreview fPre = new PL.FrmPreview();
            PL.FrmRestoreServer fRS = new PL.FrmRestoreServer();
            PL.frmUserList fUL = new PL.frmUserList();
            

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login success");
                if(dt.Rows[0][3].ToString() == "User"|| dt.Rows[0][3].ToString()=="user")
                {
                    Main x = new Main();
                    x.Show();
                    x.ID = dt.Rows[0][0].ToString();
                    x.Username = dt.Rows[0][1].ToString();
                    x.Password = dt.Rows[0][2].ToString();
                    this.Hide();

                }
                else if(dt.Rows[0][3].ToString() == "Admin"|| dt.Rows[0][3].ToString()=="admin"){

                    Main x = new Main();
                    x.Show();
                    x.ID = dt.Rows[0][0].ToString();
                    x.Username = dt.Rows[0][1].ToString();
                    x.Password = dt.Rows[0][2].ToString();
                    this.Hide();

                }
                else if (dt.Rows[0][3].ToString() == "Employee" || dt.Rows[0][3].ToString() == "Employee")
                {
                    Main x = new Main();
                    x.Show();
                    x.ID = dt.Rows[0][0].ToString();
                    x.Username = dt.Rows[0][1].ToString();
                    x.Password = dt.Rows[0][2].ToString();
                    this.Hide();

                
                }
                //Main.getMainForm.Show();
                //this.Close();
               
                
                 
                /* try
                {
                    Main main = new Main();
                    main.ID = dt.Rows[0][0].ToString();
                    main.Username = dt.Rows[0][1].ToString();
                    main.Password = dt.Rows[0][2].ToString();
                    changePass.txtID.Text = dt.Rows[0][1].ToString();
                    Application.Run(new FrmChangePass());
                    //Application.Run(new Main());
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }*/
               
                


            }
            else
                MessageBox.Show("login fail");
        }

        private void chromeButton1_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();

        }
    }
}
