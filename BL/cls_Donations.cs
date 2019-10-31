using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlTypes;
namespace Al3ooryCharity.BL
{
    class cls_Donations
    {
        
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }
       
        public DataTable Get_SumOFDonations()
        {
            string x;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_SumOFDonations", null);
            DAL.Close();
            return Dt;
        }
        public void Add_Donation(int CateID, int DonatorID, string Title,SqlDecimal  Amount, int Quantity, string Description
                                 , DateTime date, byte[] img, string comment)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@CateID", SqlDbType.Int);
            param[0].Value = CateID;

            param[1] = new SqlParameter("@DonatorID", SqlDbType.Int);
            param[1].Value = DonatorID;

            param[2] = new SqlParameter("@title", SqlDbType.VarChar, 50);
            param[2].Value = Title;

            param[3] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[3].Value = Amount;

            param[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[4].Value = Quantity;

            param[5] = new SqlParameter("@Description", SqlDbType.VarChar, 150);
            param[5].Value = Description;

            param[6] = new SqlParameter("@date", SqlDbType.Date);
            param[6].Value = date;

            param[7] = new SqlParameter("@image", SqlDbType.Image);
            param[7].Value = img;

            param[8] = new SqlParameter("@comment", SqlDbType.VarChar,150);
            param[8].Value = comment;
            DAL.ExecuteCommand("Add_Donation", param);
            DAL.Close();

        }
        public void Update_Donation(int ID,int CateID, int DonatorID, string Title, SqlDecimal Amount, int Quantity, string Description
                                 , DateTime date, byte[] img, string comment)
        {
           // int DonationIDafterExit = ;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@CateID", SqlDbType.Int);
            param[1].Value = CateID;

            param[2] = new SqlParameter("@DonatorID", SqlDbType.Int);
            param[2].Value = DonatorID;

            param[3] = new SqlParameter("@title", SqlDbType.VarChar, 50);
            param[3].Value = Title;

            param[4] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[4].Value = Amount;

            param[5] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[5].Value = Quantity;

            param[6] = new SqlParameter("@Description", SqlDbType.VarChar, 150);
            param[6].Value = Description;

            param[7] = new SqlParameter("@date", SqlDbType.Date);
            param[7].Value = date;

            param[8] = new SqlParameter("@image", SqlDbType.Image);
            param[8].Value = img;

            param[9] = new SqlParameter("@comment", SqlDbType.VarChar, 150);
            param[9].Value = comment;
            DAL.ExecuteCommand("Update_Donation", param);
            DAL.Close();

        }
        public void ADD_PRODUCT(int ID_cat, string Label_product, string ID_product,
                                int Qte, string Price, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@Label", SqlDbType.VarChar, 30);
            param[2].Value = Label_product;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_PRODUCT", param);
            DAL.Close();

        }



        public void UPDATE_PRODUCT(int ID_cat, string Label_product, string ID_product,
                        int Qte, string Price, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@Label", SqlDbType.VarChar, 30);
            param[2].Value = Label_product;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("UPDATE_PRODUCT", param);
            DAL.Close();

        }

        public DataTable VerifyDonationID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerfiyDonationID", param);
            DAL.Close();
            return Dt;
        }
        public DataTable VerifyDonatorID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerfiyDonatorID", param);
            DAL.Close();
            return Dt;
        }
        /*public DataTable ReturnDonatorName(string ID)
        {
            //DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //DataTable Dt = new DataTable();
            //SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@ID", SqlDbType.Int);
            //param[0].Value = ID;

            //Dt = DAL.SelectData("ReturnDonatorName", param);
            //DAL.Close();
            //return Dt;
            //string strCmd = "Select Fname + ' ' + LName From Person Where uname=@uname and upass=@upass";
            FrmAddDona addDona = new FrmAddDona();
            SqlConnection strConn = new SqlConnection();
            strConn.Open();
            string strCmd = "select [FName] + ' ' + [m1Name] + ' ' + [m2Name] +' '+ [LName] FROM Donator where ID =@ID";
            SqlConnection objConn = new SqlConnection(strConn.ToString());
            SqlCommand objCmd = new SqlCommand(strCmd, objConn);
            objCmd.Parameters.AddWithValue("@ID", addDona.DonatorID.Text);



            //using (objConn)
            //{
            //    objConn.Open();
            //    var username = objConn.ExecuteScalar() as string;

            //    if (!string.IsNullOrEmpty())
            //    {
            //        btnlogin2.Visible = false;
            //        txtusername.Visible = false;
            //        txtpassword.Visible = false;
            //        Response.Redirect("member.aspx");
            //        lblLogin.Text = "Logged in as:  " + username; //Display login name?
            //    }
            //}

        }*/
        public DataTable GET_ALL_Donations()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Donations", null);
            DAL.Close();
            return Dt;
        }
        
        public DataTable GET_ALL_Donations_Ar()
                {
                    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                    DataTable Dt = new DataTable();
                    Dt = DAL.SelectData("GET_ALL_Donations_Ar", null);
                    DAL.Close();
                    return Dt;
                }

        public DataTable SearchDonation(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("SearchDonation", param);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchDonation_Ar(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.VarChar,50);
            param[0].Value = ID;
            Dt = DAL.SelectData("SearchDonation_Ar", param);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_Image_Donation(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("Get_Image_Donation", param);
            DAL.Close();
            return Dt;
        }

        public void DeleteDonation(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeleteDonation", param);
            DAL.Close();

        }


    }
}
