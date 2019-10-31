using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Al3ooryCharity.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //This Constructor Inisialize the connection object
        public DataAccessLayer()
        {
            //string mode = Properties.Settings.Default.Mode;
            //if (mode == "SQL")
            //{
            //    sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + 
            //                                        Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" + 
            //                                        Properties.Settings.Default.ID + "; Password="+ Properties.Settings.Default.Password +"");
            //}
            //else
            //{
            //    sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            //}
            //sqlconnection = new SqlConnection(@"Server=.\MSSQLSERVER; Database= charity; Intergrated Security=true"); //for old version
            //DIZPC\LOL
               sqlconnection = new SqlConnection(@"Server = TIMON; Database = Charity; Trusted_Connection = True;");
        }

        //Method to open the connection
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method To Read Data From Database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Method to Insert, Update, and Delete Data From Database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
