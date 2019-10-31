using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Al3ooryCharity.BL
{
    class Cls_Users
    {
        public void Add_User(string ID, string Username, string Pass, string UserType, DateTime dtime)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            param[1].Value = Username;

            param[2] = new SqlParameter("@Pass", SqlDbType.VarChar, 50);
            param[2].Value = Pass;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;

            param[4] = new SqlParameter("@DOAc", SqlDbType.Date);
            param[4].Value = dtime.ToShortDateString();


            DAL.ExecuteCommand("Add_User", param);
            DAL.Close();

        }

        //Done but not tested
        public void Update_User(string ID, string Username, string Pass, string UserType)
        {
            // int MemberIDafterExit = ;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            param[1].Value = Username;

            param[2] = new SqlParameter("@PW", SqlDbType.NVarChar, 50);
            param[2].Value = Pass;

            param[3] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            param[3].Value = UserType;


            DAL.ExecuteCommand("Update_User", param);
            DAL.Close();

        }
        public void Update_User_Pass(string ID,string Pass)
        {
            // int MemberIDafterExit = ;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;


            param[1] = new SqlParameter("@Pass", SqlDbType.NVarChar, 50);
            param[1].Value = Pass;


            DAL.ExecuteCommand("Update_User_Pass", param);
            DAL.Close();

        }
        /* public void ADD_PRODUCT(int ID_cat, string Label_product, string ID_product,
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
         */

        public DataTable SearchUser(string txt)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text",SqlDbType.NVarChar,50);
            param[0].Value = txt;
            DT = DAL.SelectData("SearchUser", param);
            DAL.Close();
            return DT;
        }
        public DataTable Get_User_Date(string txt)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = txt;
            DT = DAL.SelectData("Get_User_Date", param);
            DAL.Close();
            return DT;
        }
        public DataTable SearchUser_Ar(string txt)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.NVarChar, 50);
            param[0].Value = txt;
            DT = DAL.SelectData("SearchUser_Ar", param);
            DAL.Close();
            return DT;
        }
        public DataTable VerifyUserID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerifyUserID", param);
            DAL.Close();
            return Dt;
        }
        /* public DataTable VerifyDonatorID(string ID)
         {
             DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
             DataTable Dt = new DataTable();
             SqlParameter[] param = new SqlParameter[1];
             param[0] = new SqlParameter("@ID", SqlDbType.Int);
             param[0].Value = ID;
             Dt = DAL.SelectData("VerfiyDonatorID", param);
             DAL.Close();
             return Dt;
         }*/
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
        public void DeleteUser(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeleteUser", param);
            DAL.Close();

        }

        //Done
        public DataTable GET_ALL_Users()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Users", null);
            DAL.Close();
            return Dt;
        }
    }
}
