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
using System.Globalization;
using System.Data.SqlTypes;

namespace Al3ooryCharity
{
    
    public partial class FrmAddDona : Form
    {
        public int DonationID;
        public string state = "Add";
        BL.cls_Donations Dona = new BL.cls_Donations();
        PL.FrmManageDona dona = new PL.FrmManageDona();
        
        public FrmAddDona()
        {
            InitializeComponent();
            categoriescombo.DataSource = Dona.GET_ALL_CATEGORIES();
            categoriescombo.DisplayMember = "Description";
            categoriescombo.ValueMember = "ID";
            DonatorID.Focus();
            
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            bool containsLetter = false;
            string text1 = qty.Text.Trim();

            for (int i = 0; i < text1.Length; i++)
            {
                if (!char.IsNumber(text1[i]))
                {
                    containsLetter = true;
                }
            }

            if (containsLetter)
            {
                MessageBox.Show("error string in number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("do you want to clear the text and start again? ", "clear حقل الكمية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    qty.Clear();
                    qty.Text = "0";
                }
            }
        }

        private void qty_Enter(object sender, EventArgs e)
        {
            //if (typeofdonation.Name == "مالي")
            //{
            //    qty_val.Enabled = true;
            //    JOD.Visible = true;

            //}
            //else if (typeofdonation.Name == "مادي")
            //{
            //    qty_val.Enabled = true;
            //    peice.Visible = true;


            //}
            //else
            //{
            //    qty_val.Enabled = true;
            //}
            }

        private void typeofdonation_Leave(object sender, EventArgs e)
        {
          
        }

        private void groupBox3_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {

            if (DonatorID.Text != null &&  state =="Add")
            {
                DonatorInfo.Enabled = false;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                //check amount
                //convert from  date time to date only
                //change from MemID in add donation to Donator ID
                //image button not added...
                if (categoriescombo.SelectedValue.ToString() == "1" || categoriescombo.SelectedValue.ToString() == "6")
                {
                    try
                    {
                        //decimal.Parse(Amount.Text, NumberStyles.Currency);
                        
                        Dona.Add_Donation(Convert.ToInt32(categoriescombo.SelectedValue),
                            Convert.ToInt32(DonatorID.Text), DonaTitle.Text,
                            // float.Parse(Amount.Text, CultureInfo.InvariantCulture.NumberFormat)
                            decimal.Parse(Amount.Text),
                            1, Description.Text, DateOfDona.Value, byteimage, OtherNote.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error in Adding Donation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        MessageBox.Show("Added Donation Success...", "Donation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dona.dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();

                    }
                }
                else
                {
                    try
                    {
                        Dona.Add_Donation(Convert.ToInt32(categoriescombo.SelectedValue), 
                            Convert.ToInt32(DonatorID.Text), DonaTitle.Text,
                           // float.Parse(Amount.Text, CultureInfo.InvariantCulture.NumberFormat)
                           decimal.Parse(Amount.Text),
                            Convert.ToInt32(qty.Text), Description.Text, DateOfDona.Value, byteimage, OtherNote.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error in Adding Donation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //float.Parse(price2.Text, CultureInfo.InvariantCulture.NumberFormat); convertion to float, add using system.globaltio...
                    finally
                    {
                        MessageBox.Show("Added Donation Success...", "Donation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dona.dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();

                    }
                }
                //finally added without testing, test it another time..
            }
            else {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                //check amount
                //convert from  date time to date only
                //change from MemID in add donation to Donator ID
                //MessageBox.Show(dona.dataGridViewDonations.CurrentRow.Cells[0].Value.ToString());

                // MessageBox.Show(Convert.ToInt32(dona.dataGridViewDonations.CurrentRow.Cells[0].Value.ToString()));
                //MessageBox.Show(dona.dataGridViewDonations.CurrentRow.Selected.ToString());


                //if (dona.dataGridViewDonations.CurrentRow.Cells[0].Value.ToString() == null) {
                //    MessageBox.Show("error null value 1");
                //}
                //if (dona.dataGridViewDonations.CurrentRow.Cells[0].Value != null)
                //{
                //    MessageBox.Show("error null value 2");
                //}
                //txtDonatorName
                //MessageBox.Show(Convert.ToString(Convert.ToInt32(dona.dataGridViewDonations.CurrentRow.Cells[0].Value)));
                //MessageBox.Show(dona.dataGridViewDonations.CurrentRow.Cells[0].Value.ToString());


                //int DonationIDafterExit = Convert.ToInt32(txtDonatorName.Text);
                // int DonationIDafterExit = Convert.ToInt32(txtDonatorName.Text);// change DonatorName from Add Donation

                MessageBox.Show(DonationID.ToString());
                if (categoriescombo.SelectedValue.ToString() == "1" || categoriescombo.SelectedValue.ToString() == "6")
                {
                    try
                    {
                        
                        Dona.Update_Donation(DonationID, Convert.ToInt32(categoriescombo.SelectedValue), 
                            Convert.ToInt32(DonatorID.Text), DonaTitle.Text,
                            SqlDecimal.ConvertToPrecScale(SqlDecimal.Parse(Amount.Text), 10, 4),
                            1, Description.Text, DateOfDona.Value, byteimage, OtherNote.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "1 Error in Editing/Modifying Donation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        

                    }
                    MessageBox.Show("1 Editing/Modifying Donation Successed...", "Donation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dona.dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();

                }
                else
                {
                    try
                    {
                        Dona.Update_Donation(DonationID, Convert.ToInt32(categoriescombo.SelectedValue),
                            Convert.ToInt32(DonatorID.Text), DonaTitle.Text,
                           // float.Parse(Amount.Text, CultureInfo.InvariantCulture.NumberFormat)
                           //decimal.Parse(Amount.Text)
                           SqlDecimal.ConvertToPrecScale(SqlDecimal.Parse(Amount.Text), 10, 4)
                           ,
                            Convert.ToInt32(qty.Text), Description.Text, DateOfDona.Value, byteimage, 
                            OtherNote.Text);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, " 2Error in Editing/Modifying Donation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //float.Parse(price2.Text, CultureInfo.InvariantCulture.NumberFormat); convertion to float, add using system.globaltio...
                    finally
                    {
                        MessageBox.Show(" 2 Editing/Modifying Donation Successed...", "Donation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dona.dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();

                    }
                }

            }
            PL.FrmManageDona.getMainForm.dataGridViewDonations.DataSource = Dona.GET_ALL_Donations();

        }

        private void typeofdonation_SelectedValueChanged(object sender, EventArgs e)
        {
            
           
        }

        private void price2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void price2_Leave(object sender, EventArgs e)
        {
            bool containsLetter = false;
            string text1 = Amount.Text.Trim();

            for (int i = 0; i < text1.Length; i++)
            {
                if (!char.IsNumber(text1[i]))
                {
                    containsLetter = true;
                }
            }

            if (containsLetter)
            {
                MessageBox.Show("error string in number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(MessageBox.Show("do you want to clear the text and start again? ","clear حقل الكمية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Amount.Clear();
                    Amount.Text = "0.00";
                }
            }
        }

        private void categoriescombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (categoriescombo.SelectedValue.ToString() == "1" || categoriescombo.SelectedValue.ToString() == "6")
            {

                ValueBox.Visible = true;
                Amount.Enabled = true;
                qty.Enabled = false;



            }
            else
            {
                qty_val.Visible = true;
                ValueBox.Visible = true;
                qty.Enabled = true;
                Amount.Enabled = true;

                ValueBox.Text = "بقيمة";

            }

        }

        private void categoriescombo_Leave(object sender, EventArgs e)
        {
            
        }

        private void categoriescombo_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void categoriescombo_TextChanged(object sender, EventArgs e)
        {
        }

        private void categoriescombo_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void categoriescombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DonatorInfo_MouseHover(object sender, EventArgs e)
        {
            DonatorInfo.Enabled = true;

        }

        private void DonatorID_Validated(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                DataTable Dt = new DataTable();
                Dt = Dona.VerifyDonatorID(DonatorID.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("There is already a donator Name ", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //dona.dataGridViewDonations.DataSource = Dona.VerifyDonatorID(DonatorID.Text);
                    //txtDonatorName.Text = dona.dataGridViewDonations.CurrentRow.Cells[1].Value.ToString();
                   

                }
                else
                {
                    MessageBox.Show("There is no a donator Name ", "Not Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    //DonatorID.Focus();
                    //DonatorID.SelectionStart = 0;
                    //DonatorID.SelectionLength = DonatorID.TextLength;
                    
                }
            }
            
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG |*.jpg|PNG|*.png|GIF|*.gif|BMP|*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void DonatorID_TextChanged(object sender, EventArgs e)
        {
            bool containsLetter = false;
            string text1 = DonatorID.Text.Trim();

            for (int i = 0; i < text1.Length; i++)
            {
                if (!char.IsNumber(text1[i]))
                {
                    containsLetter = true;
                }
            }

            if (containsLetter)
            {
                MessageBox.Show("error string in number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("do you want to clear the text and start again? ", "clear حقل الكمية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DonatorID.Clear();
                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            bool containsLetter = false;
            string text1 = Amount.Text.Trim();

            for (int i = 0; i < text1.Length; i++)
            {
                if (!char.IsNumber(text1[i]))
                {
                    containsLetter = true;
                }
            }

            if (containsLetter)
            {
                MessageBox.Show("error string in number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("do you want to clear the text and start again? ", "clear حقل الكمية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Amount.Clear();
                    
                }
            }
        }
    }
}
