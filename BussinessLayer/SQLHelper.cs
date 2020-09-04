using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;


namespace BussinessLayer
{
   public class SQLHelper
    {
        
        public static string constr = ConfigurationManager.ConnectionStrings["con_db"].ConnectionString; //pass coonectionstring data
        public static SqlConnection con = new SqlConnection(constr);  //connect to sql server

        public static int executenonquerybysp(string spname,SqlParameter[] objsqlpara) //insert,update,delete
        {
            try
            {
                int result = 0;
                con.Open();                   //open database connection
                SqlCommand cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (objsqlpara != null)     //
                {
                    cmd.Parameters.AddRange(objsqlpara);   //Addrange is use to store multiples data but Add is use to store only single data 
                }
                result = cmd.ExecuteNonQuery();     //executenonquery is use only for insert,update,delete 
                return result;
            }
            catch(Exception ex)
            {
                throw ex;    ///use to throw browser side error
            }
            finally
            {
                con.Close();      //close database connection
            }
        }
        
        public static DataTable executedatatablebysp(string spname,SqlParameter[] objsqlpara) //select quries
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();                   //open database connection
                SqlCommand cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (objsqlpara != null)     //
                {
                    cmd.Parameters.AddRange(objsqlpara);   //Addrange is use to store multiples data but Add is use to store only single data 
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd); //sql table is converted into VS datatable using sqldataadapter
                sda.Fill(dt);      // table is fill in datatable
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();      //close database connection if error is display or not
            }

        }



    }
}
