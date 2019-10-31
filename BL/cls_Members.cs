using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
namespace Al3ooryCharity.BL
{
    class cls_Members
    {
        
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ALL_Tables()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Tables", null);
            DAL.Close();
            return Dt;
        }

        //Done
        public void Add_Member(string Fname,string m1name,string m2name,string Lname,string NationalID,Decimal IntialFees,
                               string gender,string email,string address,string phoneno,
                               string socialstatus,int nochildren,string status
                               ,DateTime DOB, byte[] Picture, string comment,int nowives)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("@Fname", SqlDbType.NVarChar,50);
            param[0].Value = Fname;

            param[1] = new SqlParameter("@m1name", SqlDbType.NVarChar, 50);
            param[1].Value = m1name;

            param[2] = new SqlParameter("@m2name", SqlDbType.NVarChar, 50);
            param[2].Value = m2name;

            param[3] = new SqlParameter("@Lname", SqlDbType.NVarChar, 50);
            param[3].Value = Lname;

            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

            param[5] = new SqlParameter("@NationalID", SqlDbType.VarChar, 10);
            param[5].Value = NationalID;

            param[6] = new SqlParameter("@InitialFees", SqlDbType.Decimal);
            param[6].Value = IntialFees;

            param[7] = new SqlParameter("@Gender", SqlDbType.NVarChar,5);
            param[7].Value = gender;

            param[8] = new SqlParameter("@DOB", SqlDbType.Date);
            param[8].Value = DOB;

            param[9] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[9].Value = email;

            param[10] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
            param[10].Value = address;

            param[11] = new SqlParameter("@Phoneno", SqlDbType.VarChar, 15);
            param[11].Value = phoneno;

            param[12] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 50);
            param[12].Value = socialstatus;

            param[13] = new SqlParameter("@NoChildren", SqlDbType.Int);
            param[13].Value = nochildren;

            param[14] = new SqlParameter("@Status", SqlDbType.NVarChar, 50);
            param[14].Value = status;

            param[15] = new SqlParameter("@Comment", SqlDbType.NVarChar, 150);
            param[15].Value = comment;
            param[16] = new SqlParameter("@noWives", SqlDbType.Int);
            param[16].Value = nowives;
            
            DAL.ExecuteCommand("Add_Member", param);
            DAL.Close();

        }


        public void Update_Member_Status(int ID, string Status) {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Status", SqlDbType.NVarChar,50);
            param[1].Value = Status;
            DAL.ExecuteCommand("ChangeMemberStatus", param);
            DAL.Close();
        
        
        }
        //Done but not tested
        public void Update_Member(int ID, string Fname, string m1name, string m2name, string Lname, string NationalID, Decimal IntialFees,
                               string gender, string email, string address, string phoneno,
                               string socialstatus, int nochildren, string status
                               , DateTime DOB, byte[] Picture, string comment,int nowives)
        {
           // int MemberIDafterExit = ;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@Fname", SqlDbType.NVarChar, 50);
            param[0].Value = Fname;

            param[1] = new SqlParameter("@m1name", SqlDbType.NVarChar, 50);
            param[1].Value = m1name;

            param[2] = new SqlParameter("@m2name", SqlDbType.NVarChar, 50);
            param[2].Value = m2name;

            param[3] = new SqlParameter("@Lname", SqlDbType.NVarChar, 50);
            param[3].Value = Lname;

            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

            param[5] = new SqlParameter("@NationalID", SqlDbType.VarChar, 10);
            param[5].Value = NationalID;

            param[6] = new SqlParameter("@InitialFees", SqlDbType.Decimal);
            param[6].Value = IntialFees;

            param[7] = new SqlParameter("@Gender", SqlDbType.NVarChar, 5);
            param[7].Value = gender;

            param[8] = new SqlParameter("@DOB", SqlDbType.Date);
            param[8].Value = DOB;

            param[9] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[9].Value = email;

            param[10] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
            param[10].Value = address;

            param[11] = new SqlParameter("@Phoneno", SqlDbType.VarChar, 15);
            param[11].Value = phoneno;

            param[12] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 50);
            param[12].Value = socialstatus;

            param[13] = new SqlParameter("@NoChildren", SqlDbType.Int);
            param[13].Value = nochildren;

            param[14] = new SqlParameter("@Status", SqlDbType.NVarChar, 50);
            param[14].Value = status;

            param[15] = new SqlParameter("@Comment", SqlDbType.NVarChar, 150);
            param[15].Value = comment;

            param[16] = new SqlParameter("@ID", SqlDbType.Int);
            param[16].Value = ID;
            param[17] = new SqlParameter("@noWives", SqlDbType.Int);
            param[17].Value = nowives;

            DAL.ExecuteCommand("Update_Member", param);
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


        public DataTable VerifyMemberID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerfiyMemberID", param);
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


            //Done
        public DataTable GET_ALL_Members()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Members", null);
            DAL.Close();
            return Dt;
        }

        //Done
        public DataTable GET_ALL_Members_Ar()
                {
                    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                    DataTable Dt = new DataTable();
                    Dt = DAL.SelectData("GET_ALL_Members_AR", null);
                    DAL.Close();
                    return Dt;
                }

        public DataTable SearchMember(string text)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.NVarChar, 50);
            param[0].Value = text;
            Dt = DAL.SelectData("SearchMember", param);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchMemberList(string MaritalStatus, string Status)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@MS", SqlDbType.NVarChar, 50);
            param[0].Value = MaritalStatus;
            param[1] = new SqlParameter("@Status", SqlDbType.NVarChar, 50);
            param[1].Value = Status;
            Dt = DAL.SelectData("SearchMemberList", param);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchMemberListNamenStatus(string Name,string MaritalStatus, string Status)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;
            param[1] = new SqlParameter("@MS", SqlDbType.NVarChar, 50);
            param[1].Value = MaritalStatus;
            param[2] = new SqlParameter("@Status", SqlDbType.NVarChar, 50);
            param[2].Value = Status;
            Dt = DAL.SelectData("SearchMemberListNamenStatus", param);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchMemberListNatIDnStatus(string NationalID, string MaritalStatus, string Status)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@NationalID", SqlDbType.NVarChar, 50);
            param[0].Value = NationalID;
            param[1] = new SqlParameter("@MS", SqlDbType.NVarChar, 50);
            param[1].Value = MaritalStatus;
            param[2] = new SqlParameter("@Status", SqlDbType.NVarChar, 50);
            param[2].Value = Status;
            Dt = DAL.SelectData("SearchMemberListNatIDnStatus", param);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchMemberListNNMS(string Name,string NationalID, string MaritalStatus, string Status)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;
            param[1] = new SqlParameter("@NationalID", SqlDbType.NVarChar, 50);
            param[1].Value = NationalID;
            param[2] = new SqlParameter("@MS", SqlDbType.NVarChar, 50);
            param[2].Value = MaritalStatus;
            param[3] = new SqlParameter("@Status", SqlDbType.NVarChar, 50);
            param[3].Value = Status;
            Dt = DAL.SelectData("SearchMemberListNNMS", param);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchMember_Ar(string text)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.NVarChar, 50);
            param[0].Value = text;
            Dt = DAL.SelectData("SearchMember_Ar", param);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_Image_Member(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("Get_Image_Member", param);
            DAL.Close();
            return Dt;
        }

        public void DeleteMember(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeleteMember", param);
            DAL.Close();

        }


    }
}
