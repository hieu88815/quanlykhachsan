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
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
        }
        ChucVu_BUS chucvu = new ChucVu_BUS();
        private void ChucVu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chucvu.Load_Chucvu();
        }
        private void insert_Click(object sender, EventArgs e)
        {
            ChucVu_DTO ob = new ChucVu_DTO(machucvu.Text, tenchucvu.Text, Double.Parse(luongcung.Text));
            chucvu.Insert_Chucvu(ob);
            ChucVu_Load(sender, e);
            machucvu.Clear();
            tenchucvu.Clear();
            luongcung.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            machucvu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tenchucvu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            luongcung.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            ChucVu_DTO ob = new ChucVu_DTO(machucvu.Text, tenchucvu.Text, Double.Parse(luongcung.Text));
            chucvu.Update_Chucvu(ob);
            ChucVu_Load(sender, e);
            machucvu.Clear();
            tenchucvu.Clear();
            luongcung.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            chucvu.Delete_Chucvu(machucvu.Text);
            ChucVu_Load(sender, e);
            machucvu.Clear();
            tenchucvu.Clear();
            luongcung.Clear();
        }
    }
}
