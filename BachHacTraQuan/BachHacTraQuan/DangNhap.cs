using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện SqlDataProvider

namespace BachHacTraQuan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MainMenu formMainMenu = new MainMenu();
            formMainMenu.Show();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập hệ thống
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string query = "SELECT COUNT(*) AS SoLuong FROM TaiKhoan WHERE username = '" + tk + "' and pass = '" + mk + "'";
            KetNoi cn = new KetNoi();
            DataSet ds = cn.laydulieu(query, "TaiKhoan");
            // Kiểm tra Số lượng trả về có bằng 1 hay không
            if ((int)ds.Tables["TaiKhoan"].Rows[0].ItemArray[0] == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                Mainmenu2 frm = new Mainmenu2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
