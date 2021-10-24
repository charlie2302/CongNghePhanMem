
namespace BachHacTraQuan
{
    partial class Mainmenu2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.baocaothongke = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkenhapxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkethuchi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.picnen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnen)).BeginInit();
            this.SuspendLayout();
            // 
            // dangnhap
            // 
            this.dangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(98, 25);
            this.dangnhap.Text = "Đăng xuất";
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // nhanvien
            // 
            this.nhanvien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanvien.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.Size = new System.Drawing.Size(96, 25);
            this.nhanvien.Text = "Nhân viên";
            this.nhanvien.Click += new System.EventHandler(this.nhanvien_Click);
            // 
            // sanpham
            // 
            this.sanpham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanpham.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.sanpham.Name = "sanpham";
            this.sanpham.Size = new System.Drawing.Size(96, 25);
            this.sanpham.Text = "Sản phẩm";
            this.sanpham.Click += new System.EventHandler(this.sanpham_Click);
            // 
            // thongke
            // 
            this.thongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baocaothongke,
            this.thongkenhapxuat,
            this.thongkethuchi});
            this.thongke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(93, 25);
            this.thongke.Text = "Thống kê";
            // 
            // baocaothongke
            // 
            this.baocaothongke.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.baocaothongke.Name = "baocaothongke";
            this.baocaothongke.Size = new System.Drawing.Size(228, 26);
            this.baocaothongke.Text = "Báo cáo thống kê";
            this.baocaothongke.Click += new System.EventHandler(this.baocaothongke_Click);
            // 
            // thongkenhapxuat
            // 
            this.thongkenhapxuat.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.thongkenhapxuat.Name = "thongkenhapxuat";
            this.thongkenhapxuat.Size = new System.Drawing.Size(228, 26);
            this.thongkenhapxuat.Text = "Thống kê nhập xuất";
            this.thongkenhapxuat.Click += new System.EventHandler(this.thongkenhapxuat_Click);
            // 
            // thongkethuchi
            // 
            this.thongkethuchi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.thongkethuchi.Name = "thongkethuchi";
            this.thongkethuchi.Size = new System.Drawing.Size(228, 26);
            this.thongkethuchi.Text = "Thống kê thu chi";
            this.thongkethuchi.Click += new System.EventHandler(this.thongkethuchi_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanvien,
            this.sanpham,
            this.hoadon,
            this.thongke,
            this.dangnhap});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(481, 29);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hoadon
            // 
            this.hoadon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoadon.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hoadon.Name = "hoadon";
            this.hoadon.Size = new System.Drawing.Size(87, 25);
            this.hoadon.Text = "Hoá đơn";
            this.hoadon.Click += new System.EventHandler(this.hoadon_Click);
            // 
            // picnen
            // 
            this.picnen.Image = global::BachHacTraQuan.Properties.Resources.Image;
            this.picnen.Location = new System.Drawing.Point(21, 85);
            this.picnen.Name = "picnen";
            this.picnen.Size = new System.Drawing.Size(439, 274);
            this.picnen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picnen.TabIndex = 10;
            this.picnen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "BẠCH HẠC TRÀ QUÁN";
            // 
            // Mainmenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 376);
            this.Controls.Add(this.picnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Mainmenu2";
            this.Text = "Mainmenu2";
            this.Load += new System.EventHandler(this.Mainmenu2_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dangnhap;
        private System.Windows.Forms.ToolStripMenuItem nhanvien;
        private System.Windows.Forms.ToolStripMenuItem sanpham;
        private System.Windows.Forms.ToolStripMenuItem thongke;
        private System.Windows.Forms.ToolStripMenuItem thongkenhapxuat;
        private System.Windows.Forms.ToolStripMenuItem thongkethuchi;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hoadon;
        private System.Windows.Forms.PictureBox picnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem baocaothongke;
    }
}