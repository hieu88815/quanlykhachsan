namespace quản_lý_khách_sạn
{
    partial class NhanVien
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
            this.ten = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.machucvu = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.nm = new System.Windows.Forms.Label();
            this.sđt = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.phòng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sogiocong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Location = new System.Drawing.Point(36, 18);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(20, 16);
            this.ten.TabIndex = 0;
            this.ten.Text = "ID";
            this.ten.Click += new System.EventHandler(this.id_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(79, 80);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(194, 22);
            this.date.TabIndex = 1;
            this.date.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(79, 18);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(194, 22);
            this.ID.TabIndex = 2;
            this.ID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(79, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(194, 22);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // machucvu
            // 
            this.machucvu.Location = new System.Drawing.Point(528, 46);
            this.machucvu.Name = "machucvu";
            this.machucvu.Size = new System.Drawing.Size(200, 22);
            this.machucvu.TabIndex = 4;
            this.machucvu.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(528, 18);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(200, 22);
            this.sdt.TabIndex = 5;
            this.sdt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 258);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(90, 134);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 7;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(263, 134);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(395, 134);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 9;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.Location = new System.Drawing.Point(9, 49);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(64, 16);
            this.nm.TabIndex = 11;
            this.nm.Text = "họ và tên ";
            // 
            // sđt
            // 
            this.sđt.AutoSize = true;
            this.sđt.Location = new System.Drawing.Point(417, 21);
            this.sđt.Name = "sđt";
            this.sđt.Size = new System.Drawing.Size(83, 16);
            this.sđt.TabIndex = 12;
            this.sđt.Text = "số điện thoại";
            this.sđt.Click += new System.EventHandler(this.sđt_Click);
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(9, 86);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(64, 16);
            this.ngaysinh.TabIndex = 13;
            this.ngaysinh.Text = "ngày sinh";
            this.ngaysinh.Click += new System.EventHandler(this.date_Click);
            // 
            // phòng
            // 
            this.phòng.AutoSize = true;
            this.phòng.Location = new System.Drawing.Point(430, 49);
            this.phòng.Name = "phòng";
            this.phòng.Size = new System.Drawing.Size(74, 16);
            this.phòng.TabIndex = 14;
            this.phòng.Text = "mã chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "số giờ công";
            // 
            // sogiocong
            // 
            this.sogiocong.Location = new System.Drawing.Point(528, 74);
            this.sogiocong.Name = "sogiocong";
            this.sogiocong.Size = new System.Drawing.Size(200, 22);
            this.sogiocong.TabIndex = 16;
            this.sogiocong.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sogiocong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phòng);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.sđt);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.machucvu);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ten);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox machucvu;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Label sđt;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label phòng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sogiocong;
    }
}