
namespace DuLich.GUI.QuanLyThietBi
{
    partial class ChiTietThietBi
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
            this.tv_giatri = new System.Windows.Forms.Label();
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.tb_tenthietbi = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_danhmuc = new System.Windows.Forms.ComboBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_giamgia = new System.Windows.Forms.TextBox();
            this.tb_giasaugiam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_chitiet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tv_giatri
            // 
            this.tv_giatri.AutoSize = true;
            this.tv_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_giatri.Location = new System.Drawing.Point(12, 111);
            this.tv_giatri.Name = "tv_giatri";
            this.tv_giatri.Size = new System.Drawing.Size(34, 20);
            this.tv_giatri.TabIndex = 1;
            this.tv_giatri.Text = "Giá";
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_ngaybatdau.Location = new System.Drawing.Point(12, 39);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(82, 20);
            this.tv_ngaybatdau.TabIndex = 2;
            this.tv_ngaybatdau.Text = "Danh mục";
            this.tv_ngaybatdau.Click += new System.EventHandler(this.tv_ngaybatdau_Click);
            // 
            // tb_tenthietbi
            // 
            this.tb_tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenthietbi.Location = new System.Drawing.Point(126, 6);
            this.tb_tenthietbi.Name = "tb_tenthietbi";
            this.tb_tenthietbi.Size = new System.Drawing.Size(263, 26);
            this.tb_tenthietbi.TabIndex = 5;
            this.tb_tenthietbi.TextChanged += new System.EventHandler(this.tb_tenthietbi_TextChanged);
            this.tb_tenthietbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_giatri_KeyPress_1);
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
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giảm giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giá sau giảm";
            // 
            // cb_danhmuc
            // 
            this.cb_danhmuc.FormattingEnabled = true;
            this.cb_danhmuc.Location = new System.Drawing.Point(126, 41);
            this.cb_danhmuc.Name = "cb_danhmuc";
            this.cb_danhmuc.Size = new System.Drawing.Size(263, 21);
            this.cb_danhmuc.TabIndex = 14;
            this.cb_danhmuc.SelectedIndexChanged += new System.EventHandler(this.cb_danhmuc_SelectedIndexChanged);
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluong.Location = new System.Drawing.Point(126, 75);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(263, 26);
            this.tb_soluong.TabIndex = 15;
            this.tb_soluong.TextChanged += new System.EventHandler(this.tb_soluong_TextChanged);
            // 
            // tb_gia
            // 
            this.tb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gia.Location = new System.Drawing.Point(126, 111);
            this.tb_gia.MaxLength = 18;
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(263, 26);
            this.tb_gia.TabIndex = 16;
            this.tb_gia.TextChanged += new System.EventHandler(this.tb_gia_TextChanged);
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giamgia.Location = new System.Drawing.Point(126, 145);
            this.tb_giamgia.MaxLength = 3;
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.Size = new System.Drawing.Size(263, 26);
            this.tb_giamgia.TabIndex = 17;
            this.tb_giamgia.TextChanged += new System.EventHandler(this.tb_giamgia_TextChanged);
            // 
            // tb_giasaugiam
            // 
            this.tb_giasaugiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giasaugiam.Location = new System.Drawing.Point(126, 180);
            this.tb_giasaugiam.Name = "tb_giasaugiam";
            this.tb_giasaugiam.ReadOnly = true;
            this.tb_giasaugiam.Size = new System.Drawing.Size(263, 26);
            this.tb_giasaugiam.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chi tiết ";
            // 
            // tb_chitiet
            // 
            this.tb_chitiet.Location = new System.Drawing.Point(126, 216);
            this.tb_chitiet.Name = "tb_chitiet";
            this.tb_chitiet.Size = new System.Drawing.Size(263, 233);
            this.tb_chitiet.TabIndex = 20;
            this.tb_chitiet.Text = "";
            this.tb_chitiet.TextChanged += new System.EventHandler(this.tb_chitiet_TextChanged);
            // 
            // ChiTietThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 461);
            this.Controls.Add(this.tb_chitiet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_giasaugiam);
            this.Controls.Add(this.tb_giamgia);
            this.Controls.Add(this.tb_gia);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.cb_danhmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tb_tenthietbi);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Controls.Add(this.tv_giatri);
            this.Name = "ChiTietThietBi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tv_giatri;
        private System.Windows.Forms.Label tv_ngaybatdau;
        private System.Windows.Forms.TextBox tb_tenthietbi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_danhmuc;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_giamgia;
        private System.Windows.Forms.TextBox tb_giasaugiam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tb_chitiet;
    }
}
