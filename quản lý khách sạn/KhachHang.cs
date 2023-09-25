using DTO;
using BUS;
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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        KhachHang_BUS khachhang = new KhachHang_BUS();
        private void NhapKhach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khachhang.Load_KhachHang();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang_DTO ob = new KhachHang_DTO(ID.Text, name.Text, date.Text, number.Text);
            khachhang.Insert_KhachHang(ob);
            NhapKhach_Load(sender, e);
            ID.Clear();
            name.Clear();
            date.Clear();
            number.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            khachhang.Delete_khachhang(ID.Text);
            NhapKhach_Load(sender, e);
            ID.Clear();
            name.Clear();
            date.Clear();
            number.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            KhachHang_DTO ob = new KhachHang_DTO(ID.Text, name.Text, date.Text, number.Text);
            khachhang.Update_KhachHang(ob);
            NhapKhach_Load(sender, e);
            ID.Clear();
            name.Clear();
            date.Clear();
            number.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            ID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            date.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            number.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
    }
}
