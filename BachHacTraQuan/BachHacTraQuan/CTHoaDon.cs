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
    public partial class CTHoaDon : Form
    {
        public CTHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Mainmenu2 formmainmenu2 = new Mainmenu2();
            formmainmenu2.Show();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            HoaDon formhoadon = new HoaDon();
            formhoadon.Show();
        }
        
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPham formsanpham = new SanPham();
            formsanpham.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mct = txtmact.Text;
            string mhd = txtmahoadon.Text;
            string msp = txtmasp.Text;
            string tsp = txttensp.Text;
            string sl = txtsoluong.Text;
            string gia = txtgia.Text;
            string tt = txtthanhtien.Text;

            string query = "INSERT INTO CTHoaDon (macthoadon, mahoadon, masanpham, soluong) VALUES ('" + mct + "', '" + mhd + "', '" + msp + "', '" + sl + "')";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                // Đọc dữ liệu
                txtmact.Text = dgvCTHoaDon.Rows[row].Cells["macthoadon"].Value.ToString();
                txtmahoadon.Text = dgvCTHoaDon.Rows[row].Cells["mahoadon"].Value.ToString();
                txtmasp.Text = dgvCTHoaDon.Rows[row].Cells["masanpham"].Value.ToString();
                txttensp.Text = dgvCTHoaDon.Rows[row].Cells["tensanpham"].Value.ToString();
                txtsoluong.Text = dgvCTHoaDon.Rows[row].Cells["soluong"].Value.ToString();
                txtgia.Text = dgvCTHoaDon.Rows[row].Cells["gia"].Value.ToString();
                txtthanhtien.Text = dgvCTHoaDon.Rows[row].Cells["thanhtien"].Value.ToString();
            }
        }

        public void getData()
        {
            // Lấy dữ liệu, hiển thị lên GridView
            string query = "EXEC CapNhatBangCTHoaDon; EXEC ThanhTien; EXEC TongHoaDon_TienCoc_CanThanhToan;  SELECT * FROM CTHoaDon";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "CTHoaDon");

            dgvCTHoaDon.DataSource = ds.Tables["CTHoaDon"];
        }

        private void CTHoaDon_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mct = txtmact.Text;
            string mhd = txtmahoadon.Text;
            string msp = txtmasp.Text;
            string tsp = txttensp.Text;
            string sl = txtsoluong.Text;
            string gia = txtgia.Text;
            string tt = txtthanhtien.Text;

            string query = "UPDATE CTHoaDon SET mahoadon = '" + mhd + "', masanpham = '" + msp + "', soluong = '" + sl + "' WHERE macthoadon like N'%" + mct + "%'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mct = txtmact.Text;
            string query = "DELETE CTHoaDon WHERE macthoadon = '" + mct + "'";
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mhd = txtmahoadon.Text;
            string query = "SELECT * FROM CTHoaDon WHERE mahoadon like N'%" + mhd + "%'";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "CTHoaDon");

            dgvCTHoaDon.DataSource = ds.Tables["CTHoaDon"];
        }
    }
}
