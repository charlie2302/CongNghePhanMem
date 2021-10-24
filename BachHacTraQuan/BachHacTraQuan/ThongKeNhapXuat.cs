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
    public partial class ThongKeNhapXuat : Form
    {
        public ThongKeNhapXuat()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Mainmenu2 formmainmenu2 = new Mainmenu2();
            formmainmenu2.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mbc = txtmabaocao.Text;
            string query = "SELECT * FROM ThongKeNhapXuat WHERE mabaocao like N'%" + mbc + "%'";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "ThongKeNhapXuat");

            dgvNhapXuat.DataSource = ds.Tables["ThongKeNhapXuat"];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mbc = txtmabaocao.Text;
            string query = "DELETE ThongKeNhapXuat WHERE mabaocao = '" + mbc + "'";
            KetNoi kn = new KetNoi();
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Xóa thành công!");
                getData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mnx = txtmanhapxuat.Text;
            string mbc = txtmabaocao.Text;
            string tnv = txttennhanvien.Text;
            string thang = txtthang.Text;
            string msp = txtmasp.Text;
            string tsp = txttensanpham.Text;
            string sln = txtsoluongnhap.Text;
            string slb = txtsoluongban.Text;
            string gn = txtgianhap.Text;
            string gb = txtgiaban.Text;

            string query = "UPDATE ThongKeNhapXuat SET mabaocao = N'" + mbc + "', masanpham = '" + msp + "', soluongnhap = '" + sln + "' WHERE manhapxuat like N'%" + mnx + "%'";
            KetNoi kn = new KetNoi();
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công!");
                getData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mnx = txtmanhapxuat.Text;
            string mbc = txtmabaocao.Text;
            string tnv = txttennhanvien.Text;
            string thang = txtthang.Text;
            string msp = txtmasp.Text;
            string tsp = txttensanpham.Text;
            string sln = txtsoluongnhap.Text;
            string slb = txtsoluongban.Text;
            string gn = txtgianhap.Text;
            string gb = txtgiaban.Text;

            string query = "INSERT INTO ThongKeNhapXuat (manhapxuat, mabaocao, masanpham, soluongnhap) VALUES ('" + mnx + "', '" + mbc + "', '" + msp + "', '" + sln + "')";
            KetNoi cn = new KetNoi();
            bool kt = cn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                getData();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        public void getData()
        {
            // Lấy dữ liệu, hiển thị lên GridView
            string query = "EXEC CapNhatTen_GiaBaoCao; EXEC CapNhatSoLuongSPBaoCao; EXEC CapNhatTen_ThangBCNX; SELECT * FROM ThongKeNhapXuat";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "ThongKeNhapXuat");

            dgvNhapXuat.DataSource = ds.Tables["ThongKeNhapXuat"];
        }

        private void ThongKeNhapXuat_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe formbaocao = new BaoCaoThongKe();
            formbaocao.Show();
        }

        private void dgvNhapXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dữ liệu của dòng hiện tại, hiển thị lên các ô Text
            int row = e.RowIndex;
            if (row >= 0)
            {
                // Đọc dữ liệu
                txtmanhapxuat.Text = dgvNhapXuat.Rows[row].Cells["manhapxuat"].Value.ToString();
                txtmabaocao.Text = dgvNhapXuat.Rows[row].Cells["mabaocao"].Value.ToString();
                txttennhanvien.Text = dgvNhapXuat.Rows[row].Cells["tennhanvien"].Value.ToString();
                txtthang.Text = dgvNhapXuat.Rows[row].Cells["thang"].Value.ToString();
                txtmasp.Text = dgvNhapXuat.Rows[row].Cells["masanpham"].Value.ToString();
                txttensanpham.Text = dgvNhapXuat.Rows[row].Cells["tensanpham"].Value.ToString();
                txtsoluongnhap.Text = dgvNhapXuat.Rows[row].Cells["soluongnhap"].Value.ToString();
                txtsoluongban.Text = dgvNhapXuat.Rows[row].Cells["soluongban"].Value.ToString();
                txtgianhap.Text = dgvNhapXuat.Rows[row].Cells["gianhap"].Value.ToString();
                txtgiaban.Text = dgvNhapXuat.Rows[row].Cells["giaban"].Value.ToString();
            }
        }
    }
}
