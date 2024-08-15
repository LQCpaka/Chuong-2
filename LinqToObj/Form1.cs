using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToObj
{
    public partial class Form1 : Form
    {
        //Dinh nghia danh sach khoa
        List<KHOA> KHOAs;
        List<SINHVIEN> SINHVIENs;
        List<KETQUA> KETQUAs;
        List<MONHOC> MONHOCs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            ThiDu1a();
        }

        private void ThiDu1a()
        {
            var kq = from kh in SINHVIENs
                     select kh;
            dgvkq.DataSource = kq.ToList();
        }
        private void ThiDu1b()
        {
            var kq = KHOAs;
            dgvkq.DataSource = kq.ToList();
        }

        private void KhoiTaoDuLieu()
        {
            KHOAs = new List<KHOA>
            {
                new KHOA{MaKh = "TH",TenKh="Tin Hoc"},
                new KHOA{MaKh = "AV",TenKh="Anh Van"},
                new KHOA{MaKh = "OT",TenKh="O To"},
                new KHOA{MaKh = "DT",TenKh="Dien Tu"},
                new KHOA{MaKh = "KT",TenKh="Kinh Te"}
            };
            SINHVIENs = new List<SINHVIEN>
            {
                new SINHVIEN{MaSV="A01",HoTen="Nguyen Van Hung",MaKh="TH",HocBong=1500000},
                new SINHVIEN{MaSV="A02",HoTen="Le Quoc Can",MaKh="AV",HocBong=12000},
                new SINHVIEN{MaSV="A03",HoTen="Nguyen Van a",MaKh="OT",HocBong=135000},
                new SINHVIEN{MaSV="A04",HoTen="Nguyen Van b",MaKh="DT",HocBong=15300},
                new SINHVIEN{MaSV="A05",HoTen="Nguyen Van c",MaKh="DT",HocBong=3500000},
                new SINHVIEN{MaSV="A06",HoTen="Nguyen Van d",MaKh="KT",HocBong=2000},
            };
        }
    }
}
