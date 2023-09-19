using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_khách_sạn
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        NhanVien_BUS nhanvien = new NhanVien_BUS();
        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien_DTO ob = new NhanVien_DTO(ID.Text, name.Text, date.Text, sdt.Text, machucvu.Text, int.Parse(sogiocong.Text));
            nhanvien.Insert_KhachHang(ob);
            NhanVien_Load(sender, e);
            ID.Clear();
            name.Clear();
            date.Clear();
            machucvu.Clear();
            sogiocong.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void sđt_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.Load_Nhanvien();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            nhanvien.Delete_khachhang(ID.Text);
            NhanVien_Load(sender, e);
            ID.Clear();
            name.Clear();
            date.Clear();
            machucvu.Clear();
            sogiocong.Clear();
        }

        private void update_Click(object sender, EventArgs e)
        {
            NhanVien_DTO ob = new NhanVien_DTO(ID.Text, name.Text, date.Text, sdt.Text, machucvu.Text, int.Parse(sogiocong.Text));
            nhanvien.Update_KhachHang(ob);
            NhanVien_Load(sender, e);
            ID.Clear();
            name.Clear();
            date.Clear();
            machucvu.Clear();
            sogiocong.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            ID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            date.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            sdt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            machucvu.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            sogiocong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
