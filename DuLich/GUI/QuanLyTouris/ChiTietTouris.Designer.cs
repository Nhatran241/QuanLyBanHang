using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyTouris
{
    partial class ChiTietTouris : UserControl  
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
            this.tour_id = new System.Windows.Forms.Label();
            this.tour_name = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.tour_loai = new System.Windows.Forms.Label();
            this.tab_chitiet = new System.Windows.Forms.TabControl();
            this.tab_gia = new System.Windows.Forms.TabPage();
            this.tab_diadiem = new System.Windows.Forms.TabPage();
            this.tab_thongke = new System.Windows.Forms.TabPage();
            this.btn_chinhsua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tab_chitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_id
            // 
            this.textbox_id.Enabled = false;
            this.textbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_id.Location = new System.Drawing.Point(93, 10);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(218, 22);
            this.textbox_id.TabIndex = 13;
            // 
            // combobox_loai
            // 
            this.combobox_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_loai.FormattingEnabled = true;
            this.combobox_loai.Location = new System.Drawing.Point(93, 63);
            this.combobox_loai.Name = "combobox_loai";
            this.combobox_loai.Size = new System.Drawing.Size(218, 24);
            this.combobox_loai.TabIndex = 12;
            this.combobox_loai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tour_id
            // 
            this.tour_id.AutoSize = true;
            this.tour_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tour_id.Location = new System.Drawing.Point(10, 10);
            this.tour_id.Name = "tour_id";
            this.tour_id.Size = new System.Drawing.Size(58, 16);
            this.tour_id.TabIndex = 9;
            this.tour_id.Text = "Mã Tour";
            // 
            // tour_name
            // 
            this.tour_name.AutoSize = true;
            this.tour_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tour_name.Location = new System.Drawing.Point(330, 13);
            this.tour_name.Name = "tour_name";
            this.tour_name.Size = new System.Drawing.Size(63, 16);
            this.tour_name.TabIndex = 18;
            this.tour_name.Text = "Tên Tour";
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_name.Location = new System.Drawing.Point(399, 10);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(330, 22);
            this.textbox_name.TabIndex = 19;
            this.textbox_name.TextChanged += new System.EventHandler(this.textbox_name_TextChanged);
            // 
            // tour_loai
            // 
            this.tour_loai.AutoSize = true;
            this.tour_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tour_loai.Location = new System.Drawing.Point(10, 71);
            this.tour_loai.Name = "tour_loai";
            this.tour_loai.Size = new System.Drawing.Size(65, 16);
            this.tour_loai.TabIndex = 20;
            this.tour_loai.Text = "Loại Tour";
            // 
            // tab_chitiet
            // 
            this.tab_chitiet.Controls.Add(this.tab_gia);
            this.tab_chitiet.Controls.Add(this.tab_diadiem);
            this.tab_chitiet.Controls.Add(this.tab_thongke);
            this.tab_chitiet.Location = new System.Drawing.Point(14, 127);
            this.tab_chitiet.Name = "tab_chitiet";
            this.tab_chitiet.SelectedIndex = 0;
            this.tab_chitiet.Size = new System.Drawing.Size(775, 473);
            this.tab_chitiet.TabIndex = 21;
            this.tab_chitiet.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tab_gia
            // 
            this.tab_gia.BackColor = System.Drawing.Color.White;
            this.tab_gia.Location = new System.Drawing.Point(4, 22);
            this.tab_gia.Name = "tab_gia";
            this.tab_gia.Padding = new System.Windows.Forms.Padding(3);
            this.tab_gia.Size = new System.Drawing.Size(767, 447);
            this.tab_gia.TabIndex = 0;
            this.tab_gia.Text = "Giá";
            this.tab_gia.Click += new System.EventHandler(this.tab_gia_Click);
            // 
            // tab_diadiem
            // 
            this.tab_diadiem.Location = new System.Drawing.Point(4, 22);
            this.tab_diadiem.Name = "tab_diadiem";
            this.tab_diadiem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_diadiem.Size = new System.Drawing.Size(767, 447);
            this.tab_diadiem.TabIndex = 1;
            this.tab_diadiem.Text = "Địa Điểm";
            this.tab_diadiem.UseVisualStyleBackColor = true;
            // 
            // tab_thongke
            // 
            this.tab_thongke.AutoScroll = true;
            this.tab_thongke.Location = new System.Drawing.Point(4, 22);
            this.tab_thongke.Name = "tab_thongke";
            this.tab_thongke.Size = new System.Drawing.Size(767, 447);
            this.tab_thongke.TabIndex = 2;
            this.tab_thongke.Text = "Thống Kê";
            this.tab_thongke.UseVisualStyleBackColor = true;
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chinhsua.Location = new System.Drawing.Point(735, 7);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(50, 50);
            this.btn_chinhsua.TabIndex = 22;
            this.btn_chinhsua.Text = "Sửa";
            this.btn_chinhsua.UseVisualStyleBackColor = true;
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(735, 71);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(50, 50);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // ChiTietTouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_chinhsua);
            this.Controls.Add(this.tab_chitiet);
            this.Controls.Add(this.tour_loai);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.tour_name);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.combobox_loai);
            this.Controls.Add(this.tour_id);
            this.Name = "ChiTietTouris";
            this.Size = new System.Drawing.Size(800, 600);
            this.tab_chitiet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.ComboBox combobox_loai;
        private System.Windows.Forms.Label tour_id;
        private System.Windows.Forms.Label tour_name;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label tour_loai;
        private System.Windows.Forms.TabControl tab_chitiet;
        private System.Windows.Forms.TabPage tab_gia;
        private System.Windows.Forms.TabPage tab_diadiem;
        private System.Windows.Forms.Button btn_chinhsua;
        private System.Windows.Forms.Button btn_xoa;
        private TabPage tab_thongke;
    }
}
