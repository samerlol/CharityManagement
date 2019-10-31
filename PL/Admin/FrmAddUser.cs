using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al3ooryCharity.PL.Admin
{
    public partial class FrmAddUser : Form
    {
        BL.Cls_Users Cls_Users = new BL.Cls_Users();
        public string State = "Add";
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (State == "Add")
            {
                if (txtPass.Text != "" && string.IsNullOrEmpty(txtPass.Text) != true && string.IsNullOrWhiteSpace(txtPass.Text) != true &&
                    txtPassVerfiy.Text != "" && string.IsNullOrEmpty(txtPassVerfiy.Text) != true && string.IsNullOrWhiteSpace(txtPassVerfiy.Text) != true &&
                    txtUsername.Text != "" && string.IsNullOrEmpty(txtUsername.Text) != true && string.IsNullOrWhiteSpace(txtUsername.Text) != true &&
                    txtUserType.Text != "" && string.IsNullOrEmpty(txtUserType.Text) != true && string.IsNullOrWhiteSpace(txtUserType.Text) != true &&
                    txtID.Text != "" && string.IsNullOrEmpty(txtID.Text) != true && string.IsNullOrWhiteSpace(txtID.Text) != true)
                {
                    if (txtPass.Text == txtPassVerfiy.Text)
                    {
                        DataTable Dt = new DataTable();
                        Dt = Cls_Users.VerifyUserID(txtID.Text);
                        if (Dt.Rows.Count > 0)
                        {
                            MessageBox.Show("There is already a ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            try
                            {
                                ///The real code is commented.
                                Cls_Users.Add_User(txtID.Text, txtUsername.Text, txtPass.Text, txtUserType.Text,dTP.Value);
                                MessageBox.Show("User Has Been Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                
                                /*DataTable x2= Cls_Users.Get_User_Date(txtID.Text);
                                txtDiff.Text = Convert.ToDateTime(x.Rows[0][0].ToString()).ToShortDateString();
                                //txtDiff.Text = Convert.ToDateTime(x.Rows[0][0].ToString().ToShortDateString()) - Convert.ToDateTime(x.Rows[0][1].ToString()).ToShortDateString();
                                TimeSpan ee2 = Convert.ToDateTime(x.Rows[0][0].ToString()) - Convert.ToDateTime(x.Rows[0][1].ToString());
                                MessageBox.Show(ee.ToString());*/

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password is not Matching...", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all fields..", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (State == "Change") {
                if (txtPass.Text != "" && string.IsNullOrEmpty(txtPass.Text) != true && string.IsNullOrWhiteSpace(txtPass.Text) != true &&
                    txtPassVerfiy.Text != "" && string.IsNullOrEmpty(txtPassVerfiy.Text) != true && string.IsNullOrWhiteSpace(txtPassVerfiy.Text) != true &&
                    txtUsername.Text != "" && string.IsNullOrEmpty(txtUsername.Text) != true && string.IsNullOrWhiteSpace(txtUsername.Text) != true &&
                    txtUserType.Text != "" && string.IsNullOrEmpty(txtUserType.Text) != true && string.IsNullOrWhiteSpace(txtUserType.Text) != true &&
                    txtID.Text != "" && string.IsNullOrEmpty(txtID.Text) != true && string.IsNullOrWhiteSpace(txtID.Text) != true)
                {
                    if (txtPass.Text == txtPassVerfiy.Text)
                    {
                        DataTable Dt = new DataTable();
                     
                            try
                            {
                                Cls_Users.Update_User(txtID.Text, txtUsername.Text, txtPass.Text, txtUserType.Text);
                                MessageBox.Show("User Has Been Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        

                    }
                    else
                    {
                        MessageBox.Show("Password is not Matching...", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all fields..", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void chromeForm1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dTP_ValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
