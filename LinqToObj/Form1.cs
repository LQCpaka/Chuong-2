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
                new KHOA{MaKH = "TH",TenKH="Tin Hoc"},
                new KHOA{MaKH = "AV",TenKH="Anh Van"},
                new KHOA{MaKH = "OT",TenKH="O To"},
                new KHOA{MaKH = "DT",TenKH="Dien Tu"},
                new KHOA{MaKH = "KT",TenKH="Kinh Te"}
            };
            SINHVIENs = new List<SINHVIEN>
            {
                new SINHVIEN{MaSV="A01",HoTen="Nguyen Van Hung",MaKH="TH",HocBong=1500000},
                new SINHVIEN{MaSV="A02",HoTen="Le Quoc Can",MaKH="AV",HocBong=12000},
                new SINHVIEN{MaSV="A03",HoTen="Nguyen Van a",MaKH="OT",HocBong=135000},
                new SINHVIEN{MaSV="A04",HoTen="Nguyen Van b",MaKH="DT",HocBong=15300},
                new SINHVIEN{MaSV="A05",HoTen="Nguyen Van c",MaKH="DT",HocBong=3500000},
                new SINHVIEN{MaSV="A06",HoTen="Nguyen Van d",MaKH="KT",HocBong=2000},
            };
        }
    }
}
