namespace DuLich.GUI.QuanLyKhach
{
    partial class ChiTietKhach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.tb_diaChi = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tv_giatri = new System.Windows.Forms.Label();
            this.tv_magia = new System.Windows.Forms.Label();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datepicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(411, 76);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(50, 40);
            this.btn_huy.TabIndex = 15;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(411, 16);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 40);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diaChi.Location = new System.Drawing.Point(149, 82);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.Size = new System.Drawing.Size(241, 26);
            this.tb_diaChi.TabIndex = 13;
            this.tb_diaChi.TextChanged += new System.EventHandler(this.tb_diaChi_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(149, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(241, 26);
            this.tb_name.TabIndex = 12;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tv_giatri
            // 
            this.tv_giatri.AutoSize = true;
            this.tv_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_giatri.Location = new System.Drawing.Point(20, 82);
            this.tv_giatri.Name = "tv_giatri";
            this.tv_giatri.Size = new System.Drawing.Size(60, 20);
            this.tv_giatri.TabIndex = 11;
            this.tv_giatri.Text = "Địa Chỉ";
            // 
            // tv_magia
            // 
            this.tv_magia.AutoSize = true;
            this.tv_magia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_magia.Location = new System.Drawing.Point(20, 22);
            this.tv_magia.Name = "tv_magia";
            this.tv_magia.Size = new System.Drawing.Size(83, 20);
            this.tv_magia.TabIndex = 10;
            this.tv_magia.Text = "Tên khách";
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cmnd.Location = new System.Drawing.Point(149, 213);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(241, 26);
            this.tb_cmnd.TabIndex = 19;
            this.tb_cmnd.TextChanged += new System.EventHandler(this.tb_cmnd_TextChanged);
            this.tb_cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cmnd_KeyPress);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(149, 150);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(241, 26);
            this.tb_sdt.TabIndex = 18;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            this.tb_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sdt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số Điện Thoại";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Location = new System.Drawing.Point(149, 335);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(241, 28);
            this.cb_gioitinh.TabIndex = 34;
            this.cb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioitinh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Giới Tính";
            // 
            // datepicker_ngaysinh
            // 
            this.datepicker_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_ngaysinh.Location = new System.Drawing.Point(149, 274);
            this.datepicker_ngaysinh.Name = "datepicker_ngaysinh";
            this.datepicker_ngaysinh.Size = new System.Drawing.Size(241, 20);
            this.datepicker_ngaysinh.TabIndex = 32;
            this.datepicker_ngaysinh.ValueChanged += new System.EventHandler(this.datepicker_ngaysinh_ValueChanged);
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_ngaybatdau.Location = new System.Drawing.Point(20, 274);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(81, 20);
            this.tv_ngaybatdau.TabIndex = 31;
            this.tv_ngaybatdau.Text = "Ngày Sinh";
            // 
            // ChiTietKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 390);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datepicker_ngaysinh);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Controls.Add(this.tb_cmnd);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tb_diaChi);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tv_giatri);
            this.Controls.Add(this.tv_magia);
            this.Name = "ChiTietKhach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox tb_diaChi;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label tv_giatri;
        private System.Windows.Forms.Label tv_magia;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepicker_ngaysinh;
        private System.Windows.Forms.Label tv_ngaybatdau;
    }
}
