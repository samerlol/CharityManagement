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

    public partial class FrmChangePass : Form
    {
        BL.cls_login log2 = new BL.cls_login();
        BL.Cls_Users user = new BL.Cls_Users();
        

        public FrmChangePass()
        {
            InitializeComponent();
               BL.cls_login log = new BL.cls_login();

                DataTable dt = log.Login("admin","hahah");
                txtID.Text = dt.Rows[0][0].ToString();
                txtUserName.Text = dt.Rows[0][1].ToString();
                txtOldPassword.Text = dt.Rows[0][2].ToString();
        }

        private void chromeButton2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnShowTxt2_CheckedChanged(object sender)
        {
            if(btnShowTxt2.Checked == true) { 
            this.txtNewPass.UseSystemPasswordChar = false;
            this.txtNewPassValidation.UseSystemPasswordChar = false;
            }
            else {
                this.txtNewPass.UseSystemPasswordChar = true;
                this.txtNewPassValidation.UseSystemPasswordChar = true;
            }
        }

        private void btnShowTxt1_CheckedChanged(object sender)
        {
            if (btnShowTxt1.Checked == true)
                this.txtOldPassword.UseSystemPasswordChar = false;
            else
                this.txtOldPassword.UseSystemPasswordChar = true ;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = log2.Login(txtID.Text,txtOldPassword.Text);
            if (String.IsNullOrEmpty(txtOldPassword.Text) || String.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                MessageBox.Show("Please full fill the Old Password.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else if (txtOldPassword.Text == dt.Rows[0][3].ToString()) {
                user.Update_User_Pass(txtID.Text,txtNewPass.Text);
            
            }
            //user.Update_User_Pass(txtID.Text, txtNewPass.Text);
            MessageBox.Show("Done");
        }

    }
}
