using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHacTraQuan
{
    public partial class Mainmenu2 : Form
    {
        public Mainmenu2()
        {
            InitializeComponent();
        }

        private void nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien formNhanVien = new NhanVien();
            formNhanVien.Show();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            MainMenu formMainMenu = new MainMenu();
            formMainMenu.Show();
        }

        private void sanpham_Click(object sender, EventArgs e)
        {
            SanPham formSanPham = new SanPham();
            formSanPham.Show();
        }

        private void thongkenhapxuat_Click(object sender, EventArgs e)
        {
            ThongKeNhapXuat formThongKeNhapXuat = new ThongKeNhapXuat();
            formThongKeNhapXuat.Show();
        }

        private void thongkethuchi_Click(object sender, EventArgs e)
        {
            ThongKeThuChi formThongKeThuChi = new ThongKeThuChi();
            formThongKeThuChi.Show();
        }

        private void hoadon_Click(object sender, EventArgs e)
        {
            HoaDon formHoaDon = new HoaDon();
            formHoaDon.Show();
        }

        private void Mainmenu2_Load(object sender, EventArgs e)
        {

        }

        private void baocaothongke_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe formbaocaothongke = new BaoCaoThongKe();
            formbaocaothongke.Show();
        }
    }
}
