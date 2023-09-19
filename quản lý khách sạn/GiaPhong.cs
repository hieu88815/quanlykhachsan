using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace quản_lý_khách_sạn
{
    public partial class GiaPhong : Form
    {
        public GiaPhong()
        {
            InitializeComponent();
        }
        GiaPhong_BUS giaphong = new GiaPhong_BUS();
        private void insert_Click(object sender, EventArgs e)
        {
            GiaPhong_DTO ob = new GiaPhong_DTO(loaiphong.Text, Double.Parse(gia.Text));
            giaphong.Insert_Giaphong(ob);
            GiaPhong_Load(sender, e);
            loaiphong.Clear();
            gia.Clear();
        }

        private void GiaPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = giaphong.Load_GiaPhong();
        }

        private void update_Click(object sender, EventArgs e)
        {
            GiaPhong_DTO ob = new GiaPhong_DTO(loaiphong.Text, Double.Parse(gia.Text));
            giaphong.Update_Giaphong(ob);
            GiaPhong_Load(sender, e);
            loaiphong.Clear();
            gia.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            giaphong.Delete_GiaPhong(loaiphong.Text);
            GiaPhong_Load(sender, e);
            loaiphong.Clear();
            gia.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            loaiphong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            gia.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
    }
}
