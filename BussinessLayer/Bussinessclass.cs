using System;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
namespace BussinessLayer
{
    public class Bussinessclass
    {
        public int InsertIntoRegisTB(Entityclass e)  
        {
            SqlParameter[] sql = new SqlParameter[8];
            sql[0] = new SqlParameter("@Name", e.Name);
            sql[1] = new SqlParameter("@Address", e.Address);
            sql[2] = new SqlParameter("@Mobile", e.mobile);
            sql[3] = new SqlParameter("@Email", e.Email);
            sql[4] = new SqlParameter("@Collage_Name", e.collage_Name);
            sql[5] = new SqlParameter("@Gender", e.Gender);
            sql[6] = new SqlParameter("@Branch", e.Branch);
            sql[7] = new SqlParameter("@Skills", e.Skills);

            return SQLHelper.executenonquerybysp("insertdata", sql);
        }

        public DataTable SelectRegisDB()
        {
            SqlParameter[] sql = new SqlParameter[0];
            return SQLHelper.executedatatablebysp("selectdatas", sql);
        }
        public DataTable selectID(Entityclass e)
        {
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@ID", e.ID);
            return SQLHelper.executedatatablebysp("selectID", sql);

            
        }
        public int updatetable(Entityclass e)
        {
            SqlParameter[] sql = new SqlParameter[9];
            sql[0] = new SqlParameter("@ID", e.ID);
            sql[1] = new SqlParameter("@Name", e.Name);
            sql[2] = new SqlParameter("@Address", e.Address);
            sql[3] = new SqlParameter("@Mobile", e.mobile);
            sql[4] = new SqlParameter("@Email", e.Email);
            sql[5] = new SqlParameter("@Collage_Name", e.collage_Name);
            sql[6] = new SqlParameter("@Gender", e.Gender);
            sql[7] = new SqlParameter("@Branch", e.Branch);
            sql[8] = new SqlParameter("@Skills", e.Skills);

            return SQLHelper.executenonquerybysp("updaterecord", sql);


        }
        public int deleterow(Entityclass e)
        {
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@ID", e.ID);

            return SQLHelper.executenonquerybysp("deleterow", sql);

        }
    }
}
