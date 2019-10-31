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
namespace Al3ooryCharity.PL
{
    public partial class frmUserList : Form
    {
        BL.Cls_Users Cls_Users = new BL.Cls_Users();
        public frmUserList()
        {
            InitializeComponent();
            
            dgList.DataSource = Cls_Users.GET_ALL_Users();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(dglist.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Do you really want to delete This User Name : "+dgList.CurrentRow.Cells[1].Value.ToString()+"?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    
                    Cls_Users.DeleteUser(dgList.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("The Selected User has been deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error While Deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dgList.DataSource = Cls_Users.GET_ALL_Users();
                }
            }
           
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PL.Admin.FrmAddUser frmAddUser = new Admin.FrmAddUser();
            frmAddUser.ShowDialog();
            dgList.DataSource = Cls_Users.GET_ALL_Users();
            frmAddUser.State = "Add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PL.Admin.FrmAddUser frmAddUser = new Admin.FrmAddUser();
            frmAddUser.State = "Change";
            frmAddUser.chromeForm1.Text = dgList.CurrentRow.Cells[1].Value.ToString() + " تعديل مستخدم ";
            frmAddUser.btnAdd.Text = "تعديل";
            frmAddUser.txtID.Text = dgList.CurrentRow.Cells[0].Value.ToString();
            frmAddUser.txtUsername.Text = dgList.CurrentRow.Cells[1].Value.ToString();
            frmAddUser.txtPass.Text = dgList.CurrentRow.Cells[2].Value.ToString();
            frmAddUser.txtPassVerfiy.Text = dgList.CurrentRow.Cells[2].Value.ToString();
            frmAddUser.txtUserType.Text= dgList.CurrentRow.Cells[3].Value.ToString();
            frmAddUser.ShowDialog();
            dgList.DataSource = Cls_Users.GET_ALL_Users();
            frmAddUser.State = "Add";
        }

        private void dglist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click( sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // dglist.DataSource = Cls_Users.SearchUser(txtSearch.Text);
            dgList.DataSource = Cls_Users.SearchUser_Ar(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void dgList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you really want to delete This User Name : " + dgList.CurrentRow.Cells[1].Value.ToString() + "?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {

                        Cls_Users.DeleteUser(dgList.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("The Selected User has been deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error While Deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dgList.DataSource = Cls_Users.GET_ALL_Users();
                    }
                }

            }
        }

        private void btnPrintAllList_Click(object sender, EventArgs e)
        {
            //Not complete yet..
        }
    }
}
