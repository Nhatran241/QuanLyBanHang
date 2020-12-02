using System;

namespace DuLich.GUI.QuanLyChiPhi
{
    partial class ChiTietChiPhi
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
            this.tv_machiphi = new System.Windows.Forms.Label();
            this.tv_chiphi = new System.Windows.Forms.Label();
            this.tv_loaichiphi = new System.Windows.Forms.Label();
            this.tb_machiphi = new System.Windows.Forms.TextBox();
            this.tb_chiphi = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.combobox_loaichiphi = new System.Windows.Forms.ComboBox();
            this.tv_ghichu = new System.Windows.Forms.Label();
            this.tb_ghichu = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tv_machiphi
            // 
            this.tv_machiphi.AutoSize = true;
            this.tv_machiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tv_machiphi.Location = new System.Drawing.Point(17, 19);
            this.tv_machiphi.Name = "tv_machiphi";
            this.tv_machiphi.Size = new System.Drawing.Size(84, 20);
            this.tv_machiphi.TabIndex = 0;
            this.tv_machiphi.Text = "Mã Chi Phí";
            this.tv_machiphi.Click += new System.EventHandler(this.tv_maphancong_Click);
            // 
            // tv_chiphi
            // 
            this.tv_chiphi.AutoSize = true;
            this.tv_chiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tv_chiphi.Location = new System.Drawing.Point(17, 72);
            this.tv_chiphi.Name = "tv_chiphi";
            this.tv_chiphi.Size = new System.Drawing.Size(58, 20);
            this.tv_chiphi.TabIndex = 1;
            this.tv_chiphi.Text = "Chi Phí";
            // 
            // tv_loaichiphi
            // 
            this.tv_loaichiphi.AutoSize = true;
            this.tv_loaichiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tv_loaichiphi.Location = new System.Drawing.Point(17, 124);
            this.tv_loaichiphi.Name = "tv_loaichiphi";
            this.tv_loaichiphi.Size = new System.Drawing.Size(92, 20);
            this.tv_loaichiphi.TabIndex = 2;
            this.tv_loaichiphi.Text = "Loại Chi Phí";
            // 
            // tb_machiphi
            // 
            this.tb_machiphi.Enabled = false;
            this.tb_machiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_machiphi.Location = new System.Drawing.Point(132, 16);
            this.tb_machiphi.Name = "tb_machiphi";
            this.tb_machiphi.Size = new System.Drawing.Size(253, 26);
            this.tb_machiphi.TabIndex = 4;
            this.tb_machiphi.TextChanged += new System.EventHandler(this.tb_maphancong_TextChanged);
            // 
            // tb_chiphi
            // 
            this.tb_chiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_chiphi.Location = new System.Drawing.Point(132, 72);
            this.tb_chiphi.Name = "tb_chiphi";
            this.tb_chiphi.Size = new System.Drawing.Size(253, 26);
            this.tb_chiphi.TabIndex = 5;
            this.tb_chiphi.TextChanged += new System.EventHandler(this.tb_giatri_TextChanged);
            this.tb_chiphi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_chiphi_KeyPress);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_luu.Location = new System.Drawing.Point(408, 13);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 40);
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_huy.Location = new System.Drawing.Point(408, 72);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(50, 40);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // combobox_loaichiphi
            // 
            this.combobox_loaichiphi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_loaichiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combobox_loaichiphi.FormattingEnabled = true;
            this.combobox_loaichiphi.Location = new System.Drawing.Point(132, 121);
            this.combobox_loaichiphi.Name = "combobox_loaichiphi";
            this.combobox_loaichiphi.Size = new System.Drawing.Size(253, 28);
            this.combobox_loaichiphi.TabIndex = 13;
            this.combobox_loaichiphi.SelectedIndexChanged += new System.EventHandler(this.comboxloaichiphi_SelectedIndexChanged);
            // 
            // tv_ghichu
            // 
            this.tv_ghichu.AutoSize = true;
            this.tv_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tv_ghichu.Location = new System.Drawing.Point(17, 168);
            this.tv_ghichu.Name = "tv_ghichu";
            this.tv_ghichu.Size = new System.Drawing.Size(67, 20);
            this.tv_ghichu.TabIndex = 14;
            this.tv_ghichu.Text = "Ghi Chú";
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_ghichu.Location = new System.Drawing.Point(132, 168);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(253, 161);
            this.tb_ghichu.TabIndex = 15;
            this.tb_ghichu.Text = "";
            this.tb_ghichu.TextChanged += new System.EventHandler(this.tb_ghichu_TextChanged);
            // 
            // ChiTietChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 341);
            this.Controls.Add(this.tb_ghichu);
            this.Controls.Add(this.tv_ghichu);
            this.Controls.Add(this.combobox_loaichiphi);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tb_chiphi);
            this.Controls.Add(this.tb_machiphi);
            this.Controls.Add(this.tv_loaichiphi);
            this.Controls.Add(this.tv_chiphi);
            this.Controls.Add(this.tv_machiphi);
            this.Name = "ChiTietChiPhi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label tv_machiphi;
        private System.Windows.Forms.Label tv_chiphi;
        private System.Windows.Forms.Label tv_loaichiphi;
        private System.Windows.Forms.TextBox tb_machiphi;
        private System.Windows.Forms.TextBox tb_chiphi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.ComboBox combobox_loaichiphi;
        private System.Windows.Forms.Label tv_ghichu;
        private System.Windows.Forms.RichTextBox tb_ghichu;
    }
}
