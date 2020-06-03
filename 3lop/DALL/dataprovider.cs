using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataprovider
{
    public class Dataprovider
    {
        private static Dataprovider _instance;
        private string cnnstring;

        public static Dataprovider Instance { get {
                if(_instance==null)
                {
                    _instance = new Dataprovider();
                }
                return _instance;
            }
         set => _instance = value;
        }
        private Dataprovider()
        {
            cnnstring  = @"Data Source=TNHSUNDAY-02029;Initial Catalog=QuanLySinhVien1;Persist Security Info=True;User ID=sa;Password=123456";
        }
        public bool Excute(string query)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnstring))
                {
                   
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public DataTable Getrecord(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection cnn = new SqlConnection(cnnstring))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cnn.Open();
                 
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    
                    da.Fill(dt);

                    cnn.Close();
                    return dt;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
   
}
