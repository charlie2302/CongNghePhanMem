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
    public partial class ThongKeThuChi : Form
    {
        public ThongKeThuChi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Mainmenu2 formmainmenu2 = new Mainmenu2();
            formmainmenu2.Show();
        }

        private void dgvThuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dữ liệu của dòng hiện tại, hiển thị lên các ô Text
            int row = e.RowIndex;
            if (row >= 0)
            {
                // Đọc dữ liệu
                txtmtc.Text = dgvThuChi.Rows[row].Cells["mathuchi"].Value.ToString();
                txtmbc.Text = dgvThuChi.Rows[row].Cells["mabaocao"].Value.ToString();
                txttnv.Text = dgvThuChi.Rows[row].Cells["tennhanvien"].Value.ToString();
                txtthang.Text = dgvThuChi.Rows[row].Cells["thang"].Value.ToString();
                txtchi.Text = dgvThuChi.Rows[row].Cells["sotienchi"].Value.ToString();
                txtthu.Text = dgvThuChi.Rows[row].Cells["sotienthu"].Value.ToString();
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe formbaocao = new BaoCaoThongKe();
            formbaocao.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mtc = txtmtc.Text;
            string mbc = txtmbc.Text;
            string tnv = txttnv.Text;
            string thang = txtthang.Text;
            string chi = txtchi.Text;
            string thu = txtthu.Text;

            string query = "INSERT INTO ThongKeThuChi (mathuchi, mabaocao) VALUES ('" + mtc + "', '" + mbc + "')";
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

        private void ThongKeThuChi_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            // Lấy dữ liệu, hiển thị lên GridView
            string query = "EXEC CapNhatTienBCTC; EXEC CapNhatTenBCTC; SELECT * FROM ThongKeThuChi";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "ThongKeThuChi");

            dgvThuChi.DataSource = ds.Tables["ThongKeThuChi"];
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mtc = txtmtc.Text;
            string mbc = txtmbc.Text;
            string tnv = txttnv.Text;
            string thang = txtthang.Text;
            string chi = txtchi.Text;
            string thu = txtthu.Text;

            string query = "UPDATE ThongKeThuChi SET mabaocao = N'" + mbc + "' WHERE mathuchi like N'%" + mtc + "%'";
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
            string mbc = txtmbc.Text;
            string query = "DELETE ThongKeThuChi WHERE mabaocao = '" + mbc + "'";
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
            string mbc = txtmbc.Text;
            string query = "SELECT * FROM ThongKeThuChi WHERE mabaocao like N'%" + mbc + "%'";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "ThongKeThuChi");

            dgvThuChi.DataSource = ds.Tables["ThongKeThuChi"];
        }
    }
}
