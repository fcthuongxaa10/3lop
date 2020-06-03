using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lop.DTO
{
  public  class SinhVien
    {
       
        private string _MSSV;
        private string _HoTen;
        private Boolean _GioiTinh;
        private string _ID;

        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public Boolean GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string ID { get => _ID; set => _ID = value; }
    }
}
