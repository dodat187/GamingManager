using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDuyDat_QLQuanGame_CDTH17
{
    public class Connect
    {
        public SqlConnection cn = new SqlConnection();
        public void KN()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = "Data Source=DESKTOP-TV115F9\\SQLEXPRESS;Initial Catalog=DoDuyDat_QLQuanGame_17;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void NKN()
        {
            if (cn.State != 0)
            {
               cn.Close();
            }
        }
        public DataTable XDL(string sql)
        {
            KN();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            NKN();
        }
        public SqlCommand DDL(string sql)
        {
            KN();
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            return cm;
            NKN();
        }
    }
}
