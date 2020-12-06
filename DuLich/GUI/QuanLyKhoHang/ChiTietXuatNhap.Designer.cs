
namespace DuLich.GUI.QuanLyKhoHang
{
    partial class ChiTietXuatNhap
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
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_loaiphieu = new System.Windows.Forms.ComboBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.cb_sanpham = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_ngaybatdau.Location = new System.Drawing.Point(12, 65);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(82, 20);
            this.tv_ngaybatdau.TabIndex = 2;
            this.tv_ngaybatdau.Text = "Sản phẩm";
            this.tv_ngaybatdau.Click += new System.EventHandler(this.tv_ngaybatdau_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(423, 6);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 40);
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(423, 55);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(50, 40);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loại Phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lượng";
            // 
            // cb_loaiphieu
            // 
            this.cb_loaiphieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiphieu.FormattingEnabled = true;
            this.cb_loaiphieu.Items.AddRange(new object[] {
            "Phiếu Nhập",
            "Phiếu Xuất"});
            this.cb_loaiphieu.Location = new System.Drawing.Point(126, 8);
            this.cb_loaiphieu.MaxLength = 10;
            this.cb_loaiphieu.Name = "cb_loaiphieu";
            this.cb_loaiphieu.Size = new System.Drawing.Size(263, 21);
            this.cb_loaiphieu.TabIndex = 14;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluong.Location = new System.Drawing.Point(126, 111);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(263, 26);
            this.tb_soluong.TabIndex = 15;
            this.tb_soluong.TextChanged += new System.EventHandler(this.tb_soluong_TextChanged);
            // 
            // cb_sanpham
            // 
            this.cb_sanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sanpham.FormattingEnabled = true;
            this.cb_sanpham.Location = new System.Drawing.Point(126, 64);
            this.cb_sanpham.Name = "cb_sanpham";
            this.cb_sanpham.Size = new System.Drawing.Size(263, 21);
            this.cb_sanpham.TabIndex = 16;
            this.cb_sanpham.SelectedIndexChanged += new System.EventHandler(this.sanpham_SelectedIndexChanged);
            // 
            // ChiTietXuatNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 157);
            this.Controls.Add(this.cb_sanpham);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.cb_loaiphieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Name = "ChiTietXuatNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tv_ngaybatdau;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_loaiphieu;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.ComboBox cb_sanpham;
    }
}
