using _3lop.DALL;
using _3lop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lop.BLL
{
   public class BLL_SV
    {
        public  static BLL_SV _instace;

        public  static BLL_SV Instace {
            get
            {
                if (_instace == null)
                {
                    _instace = new BLL_SV();
                   
                }
                return _instace;
            }
            private set => _instace = value; }
       public BLL_SV()
        {

        }
        public List<SinhVien> GetlistSV_BBl()
        {
            return Dal_SV.Instace.GetlistSV();
        }
        public void addBll(SinhVien sv)
        {
            Dal_SV.Instace.Add(sv);

        }
    }
}
