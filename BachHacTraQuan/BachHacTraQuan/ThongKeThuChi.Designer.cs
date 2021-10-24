
namespace BachHacTraQuan
{
    partial class ThongKeThuChi
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvThuChi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmtc = new System.Windows.Forms.TextBox();
            this.txtmbc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttnv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtchi = new System.Windows.Forms.TextBox();
            this.txtthu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.Location = new System.Drawing.Point(538, 439);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 60);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(434, 439);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 60);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoa.Location = new System.Drawing.Point(330, 439);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 60);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSua.Location = new System.Drawing.Point(226, 439);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 60);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThem.Location = new System.Drawing.Point(122, 439);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 60);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvThuChi
            // 
            this.dgvThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuChi.Location = new System.Drawing.Point(18, 63);
            this.dgvThuChi.Name = "dgvThuChi";
            this.dgvThuChi.Size = new System.Drawing.Size(618, 153);
            this.dgvThuChi.TabIndex = 23;
            this.dgvThuChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuChi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "THỐNG KÊ THU CHI BẠCH HẠC TRÀ QUÁN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BachHacTraQuan.Properties.Resources._31e3ba389b00ddacad3484ffa8d5fc88;
            this.pictureBox1.Location = new System.Drawing.Point(434, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnhienthi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhienthi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnhienthi.Location = new System.Drawing.Point(18, 439);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(98, 60);
            this.btnhienthi.TabIndex = 30;
            this.btnhienthi.Text = "Báo cáo thống kê";
            this.btnhienthi.UseVisualStyleBackColor = false;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(15, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã thu chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(220, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã báo cáo";
            // 
            // txtmtc
            // 
            this.txtmtc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtmtc.Location = new System.Drawing.Point(119, 243);
            this.txtmtc.Name = "txtmtc";
            this.txtmtc.Size = new System.Drawing.Size(90, 20);
            this.txtmtc.TabIndex = 33;
            // 
            // txtmbc
            // 
            this.txtmbc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtmbc.Location = new System.Drawing.Point(329, 242);
            this.txtmbc.Name = "txtmbc";
            this.txtmbc.Size = new System.Drawing.Size(90, 20);
            this.txtmbc.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(15, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tên nhân viên";
            // 
            // txttnv
            // 
            this.txttnv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txttnv.Location = new System.Drawing.Point(135, 298);
            this.txttnv.Name = "txttnv";
            this.txttnv.Size = new System.Drawing.Size(284, 20);
            this.txttnv.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(15, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tháng";
            // 
            // txtthang
            // 
            this.txtthang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtthang.Location = new System.Drawing.Point(78, 349);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(138, 20);
            this.txtthang.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(15, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số tiền chi";
            // 
            // txtchi
            // 
            this.txtchi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtchi.Location = new System.Drawing.Point(110, 398);
            this.txtchi.Name = "txtchi";
            this.txtchi.Size = new System.Drawing.Size(106, 20);
            this.txtchi.TabIndex = 40;
            // 
            // txtthu
            // 
            this.txtthu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtthu.Location = new System.Drawing.Point(317, 398);
            this.txtthu.Name = "txtthu";
            this.txtthu.Size = new System.Drawing.Size(102, 20);
            this.txtthu.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(222, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Số tiền thu";
            // 
            // ThongKeThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 511);
            this.Controls.Add(this.txtthu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtchi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmbc);
            this.Controls.Add(this.txtmtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThuChi);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeThuChi";
            this.Text = "ThongKeThuChi";
            this.Load += new System.EventHandler(this.ThongKeThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvThuChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmtc;
        private System.Windows.Forms.TextBox txtmbc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtchi;
        private System.Windows.Forms.TextBox txtthu;
        private System.Windows.Forms.Label label7;
    }
}