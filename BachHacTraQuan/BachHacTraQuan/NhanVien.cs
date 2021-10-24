﻿using System;
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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Mainmenu2 formmainmenu2 = new Mainmenu2();
            formmainmenu2.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mnv = txtMaNhanVien.Text;
            string tnv = txtTenNhanVien.Text;
            string cv = txtChucVu.Text;
            string ngs = txtNgaySinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSDT.Text;
            string dc = txtDiaChi.Text;
            string ngc = txtNgayCongChuan.Text;
            string ngl = txtNgayDiLam.Text;
            string luongcb = txtLuongCoBan.Text;
            string thuclinh = txtThucLinh.Text;

            string query = "INSERT INTO NhanVien (manhanvien, tennhanvien, chucvu, ngaysinh, cmnd, sdt, diachi, ngaycongchuancuathang, songaydilamthucte, luongcobanmotngaycong) VALUES ('" + mnv + "', N'" + tnv + "', N'" + cv + "', '" + ngs + "', '" + cmnd + "', '" + sdt + "', N'" + dc + "', '" + ngc + "', '" + ngl + "', '" + luongcb + "')";
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
            string query = "EXEC ThucLinh; SELECT * FROM NhanVien";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "NhanVien");

            dgvNhanVien.DataSource = ds.Tables["NhanVien"];
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dữ liệu của dòng hiện tại, hiển thị lên các ô Text
            int row = e.RowIndex;
            if (row >= 0)
            {
                // Đọc dữ liệu
                txtMaNhanVien.Text = dgvNhanVien.Rows[row].Cells["manhanvien"].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[row].Cells["tennhanvien"].Value.ToString();
                txtChucVu.Text = dgvNhanVien.Rows[row].Cells["chucvu"].Value.ToString();
                txtNgaySinh.Text = dgvNhanVien.Rows[row].Cells["ngaysinh"].Value.ToString();
                txtCMND.Text = dgvNhanVien.Rows[row].Cells["cmnd"].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[row].Cells["sdt"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[row].Cells["diachi"].Value.ToString();
                txtNgayCongChuan.Text = dgvNhanVien.Rows[row].Cells["ngaycongchuancuathang"].Value.ToString();
                txtNgayDiLam.Text = dgvNhanVien.Rows[row].Cells["songaydilamthucte"].Value.ToString();
                txtLuongCoBan.Text = dgvNhanVien.Rows[row].Cells["luongcobanmotngaycong"].Value.ToString();
                txtThucLinh.Text = dgvNhanVien.Rows[row].Cells["thuclinh"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mnv = txtMaNhanVien.Text;
            string query = "SELECT * FROM NhanVien WHERE manhanvien like N'%" + mnv + "%'";
            DataSet ds = new DataSet();
            KetNoi cn = new KetNoi();
            ds = cn.laydulieu(query, "NhanVien");

            dgvNhanVien.DataSource = ds.Tables["NhanVien"];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mnv = txtMaNhanVien.Text;
            string query = "DELETE Nhanvien WHERE manhanvien = '" + mnv + "'";
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
            string mnv = txtMaNhanVien.Text;
            string tnv = txtTenNhanVien.Text;
            string cv = txtChucVu.Text;
            string ngs = txtNgaySinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSDT.Text;
            string dc = txtDiaChi.Text;
            string ngc = txtNgayCongChuan.Text;
            string ngl = txtNgayDiLam.Text;
            string luongcb = txtLuongCoBan.Text;
            string thuclinh = txtThucLinh.Text;

            string query = "UPDATE Nhanvien SET tennhanvien = N'" + tnv + "', chucvu = N'" + cv + "', ngaysinh = '" + ngs + "', cmnd = '" + cmnd + "', sdt = '" + sdt + "', diachi = N'" + dc + "', ngaycongchuancuathang = '" + ngc + "', songaydilamthucte = '" + ngl + "', luongcobanmotngaycong = '" + luongcb + "' WHERE manhanvien like N'%" + mnv + "%'";
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
    }
}
