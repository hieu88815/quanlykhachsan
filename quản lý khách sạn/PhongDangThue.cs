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
    public partial class PhongDangThue : Form
    {
        public PhongDangThue()
        {
            InitializeComponent();
        }
        PhongDangThue_BUS phong = new PhongDangThue_BUS();
        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phong.Load_PhongDangThue();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            PhongDangThue_DTO phongDTO = new PhongDangThue_DTO(ID.Text, maphong.Text, ngaynhanphong.Text, ngaytraphong.Text);
            phong.Insert_phongdangthue(phongDTO);
            PhongDangThue_Load(sender, e);
            ID.Clear();
            maphong.Clear();
            ngaynhanphong.Clear();
            ngaytraphong.Clear();
        }

        private void PhongDangThue_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phong.Load_PhongDangThue();
        }

        private void update_Click(object sender, EventArgs e)
        {
            PhongDangThue_DTO phongDTO = new PhongDangThue_DTO(ID.Text, maphong.Text, ngaynhanphong.Text, ngaytraphong.Text);
            phong.Update_phongdangthue(phongDTO);
            PhongDangThue_Load(sender, e);
            ID.Clear();
            maphong.Clear();
            ngaynhanphong.Clear();
            ngaytraphong.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            phong.Delete_phongdangthue(ID.Text, maphong.Text);
            PhongDangThue_Load(sender, e);
            ID.Clear();
            maphong.Clear();
            ngaynhanphong.Clear();
            ngaytraphong.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            ID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            maphong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            ngaynhanphong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            ngaytraphong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
    }
}
