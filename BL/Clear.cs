using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
namespace Al3ooryCharity.BL
{
    public class Clear
    {
        public static void  ResetControlsInFrmCreateID()
        {

            FrmCreateIDs frm = new FrmCreateIDs();
            frm.txtAddress.Clear();
            //frm.txtSocialStatus.SelectedIndex = 0;

            frm.txtEmail.Clear();
            frm.txtFname.Clear();
            frm.txtIntialFees.Clear();
            frm.txtLname.Clear();
            frm.txtm1Name.Clear();
            frm.txtm2name.Clear();
            frm.txtNationalID.Clear();
            frm.txtPhone.Clear();
            frm.txtSocialStatus.ResetText();

        }
        public void ResetControlsInFrmManageMem()
        {

            PL.FrmManageMem frm = new PL.FrmManageMem();
            frm.lblIDnumber.Text = "";
            //frm.txtSocialStatus.SelectedIndex = 0;
            frm.txtFirstName.Clear();
            frm.txtLastName.Clear();
            frm.txtFatherName.Clear();
            frm.txtGrandName.Clear();
            frm.txtNationalID.Clear();

            frm.txtInitialFees.Clear();
            frm.pbox.Image =global::Al3ooryCharity.Properties.Resources.noimage;

            frm.txtEmail.Clear();

  
            frm.txtComment.Clear();

            frm.txtAddress.Clear();
            frm.txtTele.Clear();
            frm.txtSocialStatus.ResetText();
            frm.lblActive.Visible = false;
            frm.lblDeActive.Visible = false;
            frm.grbFamily.Visible = false;
            frm.txtMemberType.ResetText();




        }
    }
}
