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
using System.Xml.Linq;

namespace quản_lý_khách_sạn
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        Phong_BUS phong = new Phong_BUS();
        private void Phong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phong.Load_Phong();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phong_DTO phongDTO = new Phong_DTO(maphong.Text, tenphong.Text, loaiphong.Text);
            phong.Insert_Phong(phongDTO);
            Phong_Load(sender, e);
            maphong.Clear();
            tenphong.Clear();
            loaiphong.Clear();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Phong_DTO phongDTO = new Phong_DTO(maphong.Text, tenphong.Text, loaiphong.Text);
            phong.Update_Phong(phongDTO);
            Phong_Load(sender, e);
            maphong.Clear();
            tenphong.Clear();
            loaiphong.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            phong.Delete_Phong(maphong.Text);
            Phong_Load(sender, e);
            maphong.Clear();
            tenphong.Clear();
            loaiphong.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            maphong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tenphong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            loaiphong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
