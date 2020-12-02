using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyDoan
{
    partial class ChiTietDoan : UserControl
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
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.combobox_loai = new System.Windows.Forms.ComboBox();
            this.doan_id = new System.Windows.Forms.Label();
            this.doan_name = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.tour_loai = new System.Windows.Forms.Label();
            this.tab_chitiet = new System.Windows.Forms.TabControl();
            this.tab_phancong = new System.Windows.Forms.TabPage();
            this.tab_khach = new System.Windows.Forms.TabPage();
            this.tab_chiphi = new System.Windows.Forms.TabPage();
            this.datepicker_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.datepicker_batdau = new System.Windows.Forms.DateTimePicker();
            this.tv_ngayketthuc = new System.Windows.Forms.Label();
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_chinhsua = new System.Windows.Forms.Button();
            this.tv_loinhuan = new System.Windows.Forms.Label();
            this.tb_loinhuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_giatour = new System.Windows.Forms.ComboBox();
            this.tb_tongchiphi = new System.Windows.Forms.TextBox();
            this.tv_tongchiphi = new System.Windows.Forms.Label();
            this.panel_thongbao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_chitiet.SuspendLayout();
            this.panel_thongbao.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_id
            // 
            this.textbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_id.Location = new System.Drawing.Point(110, 10);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(236, 23);
            this.textbox_id.TabIndex = 13;
            // 
            // combobox_loai
            // 
            this.combobox_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combobox_loai.FormattingEnabled = true;
            this.combobox_loai.Location = new System.Drawing.Point(451, 10);
            this.combobox_loai.Name = "combobox_loai";
            this.combobox_loai.Size = new System.Drawing.Size(259, 24);
            this.combobox_loai.TabIndex = 12;
            this.combobox_loai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doan_id
            // 
            this.doan_id.AutoSize = true;
            this.doan_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.doan_id.Location = new System.Drawing.Point(10, 10);
            this.doan_id.Name = "doan_id";
            this.doan_id.Size = new System.Drawing.Size(65, 17);
            this.doan_id.TabIndex = 9;
            this.doan_id.Text = "Mã Đoàn";
            // 
            // doan_name
            // 
            this.doan_name.AutoSize = true;
            this.doan_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.doan_name.Location = new System.Drawing.Point(10, 52);
            this.doan_name.Name = "doan_name";
            this.doan_name.Size = new System.Drawing.Size(71, 17);
            this.doan_name.TabIndex = 18;
            this.doan_name.Text = "Tên Đoàn";
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_name.Location = new System.Drawing.Point(110, 52);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(236, 23);
            this.textbox_name.TabIndex = 19;
            this.textbox_name.TextChanged += new System.EventHandler(this.textbox_name_TextChanged);
            // 
            // tour_loai
            // 
            this.tour_loai.AutoSize = true;
            this.tour_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tour_loai.Location = new System.Drawing.Point(370, 13);
            this.tour_loai.Name = "tour_loai";
            this.tour_loai.Size = new System.Drawing.Size(38, 17);
            this.tour_loai.TabIndex = 20;
            this.tour_loai.Text = "Tour";
            // 
            // tab_chitiet
            // 
            this.tab_chitiet.Controls.Add(this.tab_phancong);
            this.tab_chitiet.Controls.Add(this.tab_khach);
            this.tab_chitiet.Controls.Add(this.tab_chiphi);
            this.tab_chitiet.Location = new System.Drawing.Point(0, 164);
            this.tab_chitiet.Name = "tab_chitiet";
            this.tab_chitiet.SelectedIndex = 0;
            this.tab_chitiet.Size = new System.Drawing.Size(800, 430);
            this.tab_chitiet.TabIndex = 21;
            this.tab_chitiet.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tab_phancong
            // 
            this.tab_phancong.BackColor = System.Drawing.Color.White;
            this.tab_phancong.Location = new System.Drawing.Point(4, 22);
            this.tab_phancong.Name = "tab_phancong";
            this.tab_phancong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_phancong.Size = new System.Drawing.Size(792, 404);
            this.tab_phancong.TabIndex = 0;
            this.tab_phancong.Text = "Danh Sách Phân Công";
            // 
            // tab_khach
            // 
            this.tab_khach.Location = new System.Drawing.Point(4, 22);
            this.tab_khach.Name = "tab_khach";
            this.tab_khach.Padding = new System.Windows.Forms.Padding(3);
            this.tab_khach.Size = new System.Drawing.Size(792, 404);
            this.tab_khach.TabIndex = 1;
            this.tab_khach.Text = "Danh Sách Khách";
            this.tab_khach.UseVisualStyleBackColor = true;
            // 
            // tab_chiphi
            // 
            this.tab_chiphi.Location = new System.Drawing.Point(4, 22);
            this.tab_chiphi.Name = "tab_chiphi";
            this.tab_chiphi.Size = new System.Drawing.Size(792, 404);
            this.tab_chiphi.TabIndex = 2;
            this.tab_chiphi.Text = "Danh Sách Chi Phí";
            this.tab_chiphi.UseVisualStyleBackColor = true;
            // 
            // datepicker_ketthuc
            // 
            this.datepicker_ketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_ketthuc.Location = new System.Drawing.Point(501, 138);
            this.datepicker_ketthuc.Name = "datepicker_ketthuc";
            this.datepicker_ketthuc.Size = new System.Drawing.Size(209, 20);
            this.datepicker_ketthuc.TabIndex = 27;
            this.datepicker_ketthuc.ValueChanged += new System.EventHandler(this.datepicker_ketthuc_ValueChanged_1);
            // 
            // datepicker_batdau
            // 
            this.datepicker_batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_batdau.Location = new System.Drawing.Point(120, 138);
            this.datepicker_batdau.Name = "datepicker_batdau";
            this.datepicker_batdau.Size = new System.Drawing.Size(226, 20);
            this.datepicker_batdau.TabIndex = 26;
            this.datepicker_batdau.ValueChanged += new System.EventHandler(this.datepicker_batdau_ValueChanged);
            // 
            // tv_ngayketthuc
            // 
            this.tv_ngayketthuc.AutoSize = true;
            this.tv_ngayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tv_ngayketthuc.Location = new System.Drawing.Point(361, 137);
            this.tv_ngayketthuc.Name = "tv_ngayketthuc";
            this.tv_ngayketthuc.Size = new System.Drawing.Size(102, 17);
            this.tv_ngayketthuc.TabIndex = 25;
            this.tv_ngayketthuc.Text = "Ngày Kết Thúc";
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tv_ngaybatdau.Location = new System.Drawing.Point(10, 137);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(96, 17);
            this.tv_ngaybatdau.TabIndex = 24;
            this.tv_ngaybatdau.Text = "Ngày Bắt Đầu";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_xoa.Location = new System.Drawing.Point(733, 77);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(50, 50);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_chinhsua.Location = new System.Drawing.Point(733, 7);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(50, 50);
            this.btn_chinhsua.TabIndex = 22;
            this.btn_chinhsua.Text = "Sửa";
            this.btn_chinhsua.UseVisualStyleBackColor = true;
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // tv_loinhuan
            // 
            this.tv_loinhuan.AutoSize = true;
            this.tv_loinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tv_loinhuan.Location = new System.Drawing.Point(361, 98);
            this.tv_loinhuan.Name = "tv_loinhuan";
            this.tv_loinhuan.Size = new System.Drawing.Size(73, 17);
            this.tv_loinhuan.TabIndex = 31;
            this.tv_loinhuan.Text = "Lợi Nhuận";
            // 
            // tb_loinhuan
            // 
            this.tb_loinhuan.Enabled = false;
            this.tb_loinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_loinhuan.Location = new System.Drawing.Point(451, 95);
            this.tb_loinhuan.Name = "tb_loinhuan";
            this.tb_loinhuan.Size = new System.Drawing.Size(259, 23);
            this.tb_loinhuan.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(370, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Giá Tour";
            // 
            // cb_giatour
            // 
            this.cb_giatour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_giatour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_giatour.FormattingEnabled = true;
            this.cb_giatour.Location = new System.Drawing.Point(451, 50);
            this.cb_giatour.Name = "cb_giatour";
            this.cb_giatour.Size = new System.Drawing.Size(259, 24);
            this.cb_giatour.TabIndex = 34;
            this.cb_giatour.SelectedIndexChanged += new System.EventHandler(this.cb_giatour_SelectedIndexChanged);
            // 
            // tb_tongchiphi
            // 
            this.tb_tongchiphi.Enabled = false;
            this.tb_tongchiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_tongchiphi.Location = new System.Drawing.Point(110, 95);
            this.tb_tongchiphi.Name = "tb_tongchiphi";
            this.tb_tongchiphi.Size = new System.Drawing.Size(236, 23);
            this.tb_tongchiphi.TabIndex = 36;
            // 
            // tv_tongchiphi
            // 
            this.tv_tongchiphi.AutoSize = true;
            this.tv_tongchiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tv_tongchiphi.Location = new System.Drawing.Point(10, 95);
            this.tv_tongchiphi.Name = "tv_tongchiphi";
            this.tv_tongchiphi.Size = new System.Drawing.Size(89, 17);
            this.tv_tongchiphi.TabIndex = 35;
            this.tv_tongchiphi.Text = "Tổng Chi Phí";
            // 
            // panel_thongbao
            // 
            this.panel_thongbao.Controls.Add(this.label1);
            this.panel_thongbao.Location = new System.Drawing.Point(0, 0);
            this.panel_thongbao.Name = "panel_thongbao";
            this.panel_thongbao.Size = new System.Drawing.Size(800, 619);
            this.panel_thongbao.TabIndex = 37;
            this.panel_thongbao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(92, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Không có tour trong hệ thống hoặc các tour này chưa có giá áp dụng ";
            // 
            // ChiTietDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_thongbao);
            this.Controls.Add(this.datepicker_ketthuc);
            this.Controls.Add(this.datepicker_batdau);
            this.Controls.Add(this.tv_ngayketthuc);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_chinhsua);
            this.Controls.Add(this.tab_chitiet);
            this.Controls.Add(this.tour_loai);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.doan_name);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.combobox_loai);
            this.Controls.Add(this.doan_id);
            this.Controls.Add(this.tb_tongchiphi);
            this.Controls.Add(this.tv_tongchiphi);
            this.Controls.Add(this.cb_giatour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_loinhuan);
            this.Controls.Add(this.tv_loinhuan);
            this.Name = "ChiTietDoan";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.ChiTietDoan_Load);
            this.tab_chitiet.ResumeLayout(false);
            this.panel_thongbao.ResumeLayout(false);
            this.panel_thongbao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.ComboBox combobox_loai;
        private System.Windows.Forms.Label doan_id;
        private System.Windows.Forms.Label doan_name;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label tour_loai;
        private System.Windows.Forms.TabControl tab_chitiet;
        private System.Windows.Forms.TabPage tab_phancong;
        private System.Windows.Forms.TabPage tab_khach;
        private System.Windows.Forms.Button btn_chinhsua;
        private System.Windows.Forms.Button btn_xoa;
        private DateTimePicker datepicker_ketthuc;
        private DateTimePicker datepicker_batdau;
        private Label tv_ngayketthuc;
        private Label tv_ngaybatdau;
        private TabPage tab_chiphi;
        private Label tv_loinhuan;
        private TextBox tb_loinhuan;
        private Label label2;
        private ComboBox cb_giatour;
        private TextBox tb_tongchiphi;
        private Label tv_tongchiphi;
        private Panel panel_thongbao;
        private Label label1;
    }
}
