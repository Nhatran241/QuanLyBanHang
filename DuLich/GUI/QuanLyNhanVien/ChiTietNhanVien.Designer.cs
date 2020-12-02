namespace DuLich.GUI.QuanLyNhanVien
{
    partial class ChiTietNhanVien
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
            this.btn_huy_nhanvien = new System.Windows.Forms.Button();
            this.btn_luu_nhanvien = new System.Windows.Forms.Button();
            this.tb_diaChi = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tv_diachi_nhanvien = new System.Windows.Forms.Label();
            this.tv_ma_nhanvien = new System.Windows.Forms.Label();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tv_socmnd_nhanvien = new System.Windows.Forms.Label();
            this.tv_sdt_nhanvien = new System.Windows.Forms.Label();
            this.datepicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_huy_nhanvien
            // 
            this.btn_huy_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy_nhanvien.Location = new System.Drawing.Point(421, 86);
            this.btn_huy_nhanvien.Name = "btn_huy_nhanvien";
            this.btn_huy_nhanvien.Size = new System.Drawing.Size(50, 40);
            this.btn_huy_nhanvien.TabIndex = 15;
            this.btn_huy_nhanvien.Text = "Hủy";
            this.btn_huy_nhanvien.UseVisualStyleBackColor = true;
            this.btn_huy_nhanvien.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu_nhanvien
            // 
            this.btn_luu_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu_nhanvien.Location = new System.Drawing.Point(421, 19);
            this.btn_luu_nhanvien.Name = "btn_luu_nhanvien";
            this.btn_luu_nhanvien.Size = new System.Drawing.Size(50, 40);
            this.btn_luu_nhanvien.TabIndex = 14;
            this.btn_luu_nhanvien.Text = "Lưu";
            this.btn_luu_nhanvien.UseVisualStyleBackColor = true;
            this.btn_luu_nhanvien.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diaChi.Location = new System.Drawing.Point(194, 91);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.Size = new System.Drawing.Size(181, 26);
            this.tb_diaChi.TabIndex = 13;
            this.tb_diaChi.TextChanged += new System.EventHandler(this.tb_diaChi_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(194, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(181, 26);
            this.tb_name.TabIndex = 12;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tv_diachi_nhanvien
            // 
            this.tv_diachi_nhanvien.AutoSize = true;
            this.tv_diachi_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_diachi_nhanvien.Location = new System.Drawing.Point(20, 94);
            this.tv_diachi_nhanvien.Name = "tv_diachi_nhanvien";
            this.tv_diachi_nhanvien.Size = new System.Drawing.Size(60, 20);
            this.tv_diachi_nhanvien.TabIndex = 11;
            this.tv_diachi_nhanvien.Text = "Địa Chỉ";
            // 
            // tv_ma_nhanvien
            // 
            this.tv_ma_nhanvien.AutoSize = true;
            this.tv_ma_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_ma_nhanvien.Location = new System.Drawing.Point(20, 22);
            this.tv_ma_nhanvien.Name = "tv_ma_nhanvien";
            this.tv_ma_nhanvien.Size = new System.Drawing.Size(36, 20);
            this.tv_ma_nhanvien.TabIndex = 10;
            this.tv_ma_nhanvien.Text = "Tên";
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cmnd.Location = new System.Drawing.Point(194, 216);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(181, 26);
            this.tb_cmnd.TabIndex = 19;
            this.tb_cmnd.TextChanged += new System.EventHandler(this.tb_cmnd_TextChanged);
            this.tb_cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cmnd_KeyPress);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(194, 156);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(181, 26);
            this.tb_sdt.TabIndex = 18;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            this.tb_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sdt_KeyPress);
            // 
            // tv_socmnd_nhanvien
            // 
            this.tv_socmnd_nhanvien.AutoSize = true;
            this.tv_socmnd_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_socmnd_nhanvien.Location = new System.Drawing.Point(20, 219);
            this.tv_socmnd_nhanvien.Name = "tv_socmnd_nhanvien";
            this.tv_socmnd_nhanvien.Size = new System.Drawing.Size(80, 20);
            this.tv_socmnd_nhanvien.TabIndex = 17;
            this.tv_socmnd_nhanvien.Text = "Số CMND";
            // 
            // tv_sdt_nhanvien
            // 
            this.tv_sdt_nhanvien.AutoSize = true;
            this.tv_sdt_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_sdt_nhanvien.Location = new System.Drawing.Point(20, 159);
            this.tv_sdt_nhanvien.Name = "tv_sdt_nhanvien";
            this.tv_sdt_nhanvien.Size = new System.Drawing.Size(109, 20);
            this.tv_sdt_nhanvien.TabIndex = 16;
            this.tv_sdt_nhanvien.Text = "Số Điện Thoại";
            // 
            // datepicker_ngaysinh
            // 
            this.datepicker_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_ngaysinh.Location = new System.Drawing.Point(194, 268);
            this.datepicker_ngaysinh.Name = "datepicker_ngaysinh";
            this.datepicker_ngaysinh.Size = new System.Drawing.Size(181, 20);
            this.datepicker_ngaysinh.TabIndex = 28;
            this.datepicker_ngaysinh.ValueChanged += new System.EventHandler(this.datepicker_ngaysinh_ValueChanged);
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_ngaybatdau.Location = new System.Drawing.Point(20, 269);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(81, 20);
            this.tv_ngaybatdau.TabIndex = 27;
            this.tv_ngaybatdau.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Giới Tính";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Location = new System.Drawing.Point(194, 317);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(181, 28);
            this.cb_gioitinh.TabIndex = 30;
            this.cb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioitinh_SelectedIndexChanged);
            // 
            // ChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 384);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepicker_ngaysinh);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Controls.Add(this.tb_cmnd);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tv_socmnd_nhanvien);
            this.Controls.Add(this.tv_sdt_nhanvien);
            this.Controls.Add(this.btn_huy_nhanvien);
            this.Controls.Add(this.btn_luu_nhanvien);
            this.Controls.Add(this.tb_diaChi);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tv_diachi_nhanvien);
            this.Controls.Add(this.tv_ma_nhanvien);
            this.Name = "ChiTietNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy_nhanvien;
        private System.Windows.Forms.Button btn_luu_nhanvien;
        private System.Windows.Forms.TextBox tb_diaChi;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label tv_diachi_nhanvien;
        private System.Windows.Forms.Label tv_ma_nhanvien;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label tv_socmnd_nhanvien;
        private System.Windows.Forms.Label tv_sdt_nhanvien;
        private System.Windows.Forms.DateTimePicker datepicker_ngaysinh;
        private System.Windows.Forms.Label tv_ngaybatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gioitinh;
    }
}
