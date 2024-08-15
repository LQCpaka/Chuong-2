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
    public partial class Form2 : Form
    {
        //Dinh nghia danh sach khoa
        List<KHOA> KHOAs;
        List<SINHVIEN> SINHVIENs;
        List<KETQUA> KETQUAs;
        List<MONHOC> MONHOCs;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            //cau1a();
            //cau1b();
            //cau2a();
            //cau2b();
            //cau3a();
            //cau3b();
            //cau4a();
            //cau5a();
            //cau5b();
            //cau6a();
            //cau6b();
            //cau7a();
            //cau7b();
            //cau8a();
            //cau8b();

        }



        private void KhoiTaoDuLieu()
        {
            List<KHOA> Khoas = new List<KHOA>
            {
            new KHOA{MaKh="AV",TenKh="Anh van"},
            new KHOA{MaKh="TH",TenKh="Tin hoc"},
            new KHOA{MaKh="VL",TenKh="Vat ly"},
            new KHOA{MaKh="HH",TenKh="Hoa hoc"}
            };
            // Sinh viên B04, B05, C04 không có điểm
            List<SINHVIEN> Sinhviens = new List<SINHVIEN>
            {
            new SINHVIEN{MaSV="A01",HoTen="Nguyen Văn Hung",MaKh="AV",HocBong=120000},
            new SINHVIEN{MaSV="A02",HoTen="Nguyen Văn Tuan",MaKh="AV",HocBong=150000},
            new SINHVIEN{MaSV="A03",HoTen="Nguyen Văn Dung",MaKh="AV",HocBong=180000},
            new SINHVIEN{MaSV="B01",HoTen="Tran Thi Lan",MaKh="TH",HocBong=190000},
            new SINHVIEN{MaSV="B02",HoTen="Tran Thi Truc",MaKh="TH",HocBong=180000},
            new SINHVIEN{MaSV="B03",HoTen="Tran Thi Dao",MaKh="TH",HocBong=120000},
            new SINHVIEN{MaSV="B04",HoTen="Tran Van Ly",MaKh="TH",HocBong=180000},
            new SINHVIEN{MaSV="B05",HoTen="Tran Van Thanh",MaKh="TH",HocBong=250000},
            new SINHVIEN{MaSV="C01",HoTen="Le Van Truc",MaKh="VL",HocBong=190000},
            new SINHVIEN{MaSV="C02",HoTen="Le Van Cuong",MaKh="VL",HocBong=250000},
            new SINHVIEN{MaSV="C03",HoTen="Le Van Long",MaKh="VL",HocBong=140000},
            new SINHVIEN{MaSV="333",HoTen="33333333333",MaKh="33",HocBong=140000},
            new SINHVIEN{MaSV="C04",HoTen="Le Van Tu",MaKh="VL",HocBong=190000},
            new SINHVIEN{MaSV="C04",HoTen="Le Van Tu",MaKh="VL",HocBong=190000}
            };
            List<KETQUA> Ketquas = new List<KETQUA>
            {
            new KETQUA{MaSV="A01",MaMH="01",DiemThi=9},
            new KETQUA{MaSV="A01",MaMH="02",DiemThi=8},
            new KETQUA{MaSV="A01",MaMH="05",DiemThi=9},
            new KETQUA{MaSV="A02",MaMH="03",DiemThi=6},
            new KETQUA{MaSV="A02",MaMH="02",DiemThi=8},
            new KETQUA{MaSV="A03",MaMH="05",DiemThi=9},
            new KETQUA{MaSV="B01",MaMH="01",DiemThi=2},
            new KETQUA{MaSV="B01",MaMH="02",DiemThi=3},
            new KETQUA{MaSV="B01",MaMH="05",DiemThi=4},
            new KETQUA{MaSV="B02",MaMH="03",DiemThi=6},
            new KETQUA{MaSV="B02",MaMH="01",DiemThi=8},
            new KETQUA{MaSV="B02",MaMH="07",DiemThi=9},
            new KETQUA{MaSV="B02",MaMH="01",DiemThi=7},
            new KETQUA{MaSV="B02",MaMH="05",DiemThi=8},
            new KETQUA{MaSV="B03",MaMH="07",DiemThi=9},
            new KETQUA{MaSV="B03",MaMH="03",DiemThi=10},
            new KETQUA{MaSV="C01",MaMH="02",DiemThi=9},
            new KETQUA{MaSV="C01",MaMH="03",DiemThi=8},
            new KETQUA{MaSV="C01",MaMH="05",DiemThi=9},
            new KETQUA{MaSV="C01",MaMH="01",DiemThi=7},
            new KETQUA{MaSV="C02",MaMH="02",DiemThi=2},
            new KETQUA{MaSV="C02",MaMH="03",DiemThi=3},
            new KETQUA{MaSV="C02",MaMH="07",DiemThi=5},
            new KETQUA{MaSV="C03",MaMH="01",DiemThi=8}
            };
            // Môn 04, 06 không có sinh viên thi
            List<MONHOC> Monhocs = new List<MONHOC>
            {
            new MONHOC{MaMH="01",TenMH="Toan",SoTiet=45},
            new MONHOC{MaMH="02",TenMH="Ly",SoTiet=60},
            new MONHOC{MaMH="03",TenMH="Ngoai ngu",SoTiet=75},
            new MONHOC{MaMH="04",TenMH="Sinh",SoTiet=90},
            new MONHOC{MaMH="05",TenMH="Lap trinh",SoTiet=105},
            new MONHOC{MaMH="06",TenMH="Lich su",SoTiet=60},
            new MONHOC{MaMH="07",TenMH="Tam ly",SoTiet=45},
            };
        }

        void cau1a()
        {
            var kq = from sv in SINHVIENs
                     where sv.MaKh  == "TH"
                     orderby sv.HocBong ascending, sv.HoTen descending
                     select sv;
            dgvkq.DataSource = kq.ToList();
        }
        void cau1b()
        {
            var kq = SINHVIENs.Where(w=>w.MaKh == "TH").OrderBy(o1 => o1.HocBong).ThenByDescending(o2=>o2.HoTen);
            dgvkq.DataSource = kq.ToList();
        }
        void cau2a()
        {
            var kq = from sv in SINHVIENs
                     where sv.HoTen.ToUpper().StartsWith("TRAN")
                     select new { MSV=sv.MaSV, HoTenSV=sv.HoTen };
            dgvkq.DataSource = kq.ToList();
        }
        void cau2b()
        {
            var kq = SINHVIENs.Where(w=>w.HoTen.ToUpper().StartsWith("Tran")).Select(s => new {s.MaSV, s.HoTen});
            dgvkq.DataSource = kq.ToList();
        }
        void cau3a()
        {
            var kq = from sv in SINHVIENs
                     where sv.HoTen.ToUpper().EndsWith("NG")
                     select new { MSV = sv.MaSV, HoTenSV = sv.HoTen };
            dgvkq.DataSource = kq.ToList();
        }
        void cau3b()
        { 
            var kq = SINHVIENs.Where(w => w.HoTen.ToUpper().EndsWith("NG")).Select(s => new { s.MaSV, s.HoTen });
            dgvkq.DataSource = kq.ToList();
        }
        void cau4a()
        {
            var kq = from sv in SINHVIENs
                     where sv.HoTen.ToUpper().Contains("VAN")
                     select new { MSV = sv.MaSV, HoTenSV = sv.HoTen };
            dgvkq.DataSource = kq.ToList();
        }
        void cau4b()
        {
            var kq = SINHVIENs.Where(w => w.HoTen.ToUpper().Contains("VAN")).Select(s => new { s.MaSV, s.HoTen });
            dgvkq.DataSource = kq.ToList();
        }
        void cau5a()
        {
            var kq = from sv in SINHVIENs
                     where sv.MaKh == "TH" && sv.HocBong > 1500000
                     select sv;
            dgvkq.DataSource = kq.ToList();
        }
        void cau5b()
        {
            var kq = SINHVIENs.Where(x => x.MaKh == "TH" && x.HocBong > 1500000);
            dgvkq.DataSource = kq.ToList();
        }
        void cau6a()
        {
            var kq = from sv in SINHVIENs
                     where sv.MaKh == "TH" || sv.HoTen.ToUpper().Contains("VAN")
                     select new { MSV = sv.MaSV, HoTenSV = sv.HoTen, MKH = sv.MaKh };
            dgvkq.DataSource = kq.ToList();
        }
        void cau6b()
        {
            var kq = SINHVIENs.Where(x => x.MaKh == "TH" || x.HoTen.ToUpper().Contains("VAN")).Select(s=> new { s.MaSV, s.HoTen, s.MaKh });
            dgvkq.DataSource = kq.ToList();
        }
        void cau7a()
        {
            var kq = from kh in KHOAs
                     join sv in SINHVIENs on kh.MaKh equals sv.MaKh
                     select new { sv.MaSV, sv.HoTen,sv.MaKh, kh.TenKh };
            dgvkq.DataSource = kq.ToList();
        }
        void cau7b()
        {
            var kq = KHOAs.Join(SINHVIENs, kh=> kh.MaKh, sv =>sv.MaKh, (kh, sv) => new { sv.MaSV, sv.HoTen, sv.MaKh, kh.TenKh });
            dgvkq.DataSource = kq.ToList();
        }
        void cau8a()
        {
            var kq = from kh in KHOAs
                     join sv in SINHVIENs on kh.MaKh equals sv.MaKh
                     join kqd in KETQUAs on sv.MaSV equals kqd.MaSV
                     select new {sv.MaSV, sv.HoTen, sv.HocBong,  kh.TenKh, kqd.DiemThi };
        }
        void cau8b()
        {
            var kq = KHOAs.Join(SINHVIENs, kh => kh.MaKh, sv => sv.MaKh, (kh, sv) => new { sv.MaSV, sv.HoTen, sv.MaKh, kh.TenKh })
                .Join(KETQUAs,svn => svn.MaSV, kqn => kqn.MaSV, (svn,kqn) => new { svn.MaSV, svn.HoTen, svn.MaKh, kqn.DiemThi });
            dgvkq.DataSource = kq.ToList();
        }
    }
}
