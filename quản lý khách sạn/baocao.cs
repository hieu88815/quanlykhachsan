using Microsoft.Reporting.WinForms;
using System;
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
    public partial class baocao : Form
    {
        public baocao()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HIEU;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
        public DataTable Lay_DL(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void baocao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            DataTable dt = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from " + comboBox1.SelectedItem.ToString();
            if(lenh.Text != "")
            {
                sql = sql + " where " + lenh.Text;
            }
            //string sql = "select * from phongdangthue";
            DataTable dt = new DataTable();
            dt = Lay_DL(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\hieu8\source\repos\quản lý khách sạn\quản lý khách sạn\" + comboBox1.SelectedItem.ToString() + ".rdlc";
            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "QLKS";
                rds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("khong co du lieu");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
