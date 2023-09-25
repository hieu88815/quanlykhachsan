namespace quản_lý_khách_sạn
{
    partial class KhachHang
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
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.nm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sđt = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(26, 131);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 0;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(205, 131);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 1;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(423, 131);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(56, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 16);
            this.label.TabIndex = 4;
            this.label.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 266);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(433, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 22);
            this.name.TabIndex = 7;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(108, 73);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(168, 22);
            this.date.TabIndex = 8;
            this.date.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(86, 27);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(104, 22);
            this.ID.TabIndex = 9;
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.Location = new System.Drawing.Point(337, 27);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(68, 16);
            this.nm.TabIndex = 10;
            this.nm.Text = "học và tên";
            this.nm.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ngày sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // sđt
            // 
            this.sđt.AutoSize = true;
            this.sđt.Location = new System.Drawing.Point(344, 73);
            this.sđt.Name = "sđt";
            this.sđt.Size = new System.Drawing.Size(83, 16);
            this.sđt.TabIndex = 12;
            this.sđt.Text = "số điện thoại";
            this.sđt.Click += new System.EventHandler(this.label2_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(433, 70);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(165, 22);
            this.number.TabIndex = 13;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // NhapKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.number);
            this.Controls.Add(this.sđt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Name = "NhapKhach";
            this.Text = "NhạpKhach";
            this.Load += new System.EventHandler(this.NhapKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sđt;
        private System.Windows.Forms.TextBox number;
    }
}