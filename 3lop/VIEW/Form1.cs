using _3lop.BLL;
using _3lop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hàm getlist BLL
            dataGridView1.DataSource = BLL.BLL_SV.Instace.GetlistSV_BBl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MSSV = "11121000",
                HoTen = "lê cụ",
                GioiTinh = true,
                ID = "32"
            };
            BLL_SV.Instace.addBll(sv);
            dataGridView1.DataSource = BLL.BLL_SV.Instace.GetlistSV_BBl();
        }
    }
}
