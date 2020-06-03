using _3lop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lop.DALL
{
    class Dal_SV
    {
        private static Dal_SV _instace;

        public static Dal_SV Instace {
            get
            {
                if(_instace== null)
                {
                    _instace = new Dal_SV();
                }
                return _instace;
            }
           
            set => _instace = value; }
        private Dal_SV()
        {

        }
        public List<SinhVien> GetlistSV()
        {
            List<SinhVien> data = new List<SinhVien>();
            try
            {
                string query = "select * from SinhVien";
                foreach (DataRow item in Dataprovider.Dataprovider.Instance.Getrecord(query).Rows)
                {
                    data.Add(GetSV(item));
                }
                return data;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public SinhVien GetSV(DataRow r)
        {
            return new SinhVien
            {
                MSSV = r["MSSV"].ToString(),
                HoTen = r["HoTen"].ToString(),
                GioiTinh = Convert.ToBoolean(r["GioiTinh"].ToString()),
                ID = r["ID"].ToString()

            };
        }
        public void Add(SinhVien sv)
        {
            string query = "INSERT INTO SinhVien VALUES ('" + sv.MSSV + "','" + sv.HoTen + "','" + sv.GioiTinh.ToString() +"'," + "'" + sv.ID + "')";
            Dataprovider.Dataprovider.Instance.Getrecord(query);  
        }

    }
  
    
}
