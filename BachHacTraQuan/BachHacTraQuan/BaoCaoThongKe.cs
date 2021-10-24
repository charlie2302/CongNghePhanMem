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
    public partial class BaoCaoThongKe : Form
    {
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Mainmenu2 formmainmenu2 = new Mainmenu2();
            formmainmenu2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKeNhapXuat formthongkenhapxuat = new ThongKeNhapXuat();
            formthongkenhapxuat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeThuChi formthongkethuchi = new ThongKeThuChi();
            formthongkethuchi.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mbc = txtmbc.Text;
            string mnv = txtmnv.Text;
            string tnv = txttnv.Text;
            string thang = txtthang.Text;
            string tg = txtthoigian.Text;

            string query = "INSERT INTO BaoCaoThongKe (mabaocao, manhanvien, thang, thoigianthuchien) VALUES ('" + mbc + "', '" + mnv + "', '" + thang + "', '" + tg + "')";
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

        private void dgvBaoCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                // Đọc dữ liệu
                txtmbc.Text = dgvBaoCao.Rows[row].Cells["mabaocao"].Value.ToString();
                txtmnv.Text = dgvBaoCao.Rows[row].Cells["manhanvien"].Value.ToString();
                txttnv.Text = dgvBaoCao.Rows[row].Cells["tennhanvien"].Value.ToString();
                txtthang.Text = dgvBaoCao.Rows[row].Cells["thang"].Value.ToString();
                txtthoigian.Text = dgvBaoCao.Rows[row].Cells["thoigianthuchien"].Value.ToString();
            }
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mbc = txtmbc.Text;
            string query = "DELETE BaoCaoThongKe WHERE mabaocao = '" + mbc + "'";
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
            string mbc = txtmbc.Text;
            string mnv = txtmnv.Text;
            string tnv = txttnv.Text;
            string thang = txtthang.Text;
            string tg = txtthoigian.Text;

            string query = "UPDATE BaoCaoThongKe SET manhanvien = '" + mnv + "', thang = '" + thang + "', thoigianthuchien = '" + tg + "' WHERE mabaocao like N'%" + mbc + "%'";
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mbc = txtmbc.Text;
            string query = "SELECT * FROM BaoCaoThongKe WHERE mabaocao like N'%" + mbc + "%'";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "BaoCaoThongKe");

            dgvBaoCao.DataSource = ds.Tables["BaoCaoThongKe"];
        }

        public void getData()
        {
            // Lấy dữ liệu, hiển thị lên GridView
            string query = "EXEC CapNhatBCTK; SELECT * FROM BaoCaoThongKe";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "BaoCaoThongKe");

            dgvBaoCao.DataSource = ds.Tables["BaoCaoThongKe"];
        }
    }
}
