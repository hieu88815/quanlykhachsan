﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_khách_sạn
{
    public partial class nhap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HIEU;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
        public nhap()
        {
            InitializeComponent();
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void inExcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang form = new KhachHang();
            form.Show();
        }

        private void nhậpThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhongDangThue form = new PhongDangThue();
            form.Show();
        }

        private void nhậpThôngTinToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Phong form = new Phong();
            form.Show();
        }

        private void nhậpThôngTinToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NhanVien form = new NhanVien();
            form.Show();
        }

        private void nhậpThôngTinToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void nhậpThôngTinToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            GiaPhong form = new GiaPhong();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtExcleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocao baocao = new baocao();
            baocao.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang form = new KhachHang();
            form.Show();
        }

        private void phòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongDangThue form = new PhongDangThue();
            form.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.Show();
        }

        private void giáPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaPhong form = new GiaPhong();
            form.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Show();
        }

        private void chúcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.Show();
        }
    }
}
