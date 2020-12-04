
namespace DuLich.GUI.QuanLyCombo
{
    partial class ChiTietCombo
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
            this.tb_tenthietbi = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_giamgia = new System.Windows.Forms.TextBox();
            this.lv_productincombo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_themsanpham = new System.Windows.Forms.Button();
            this.btn_xoasanpham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thaydoisoluong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_giacombo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tonggiasanpham = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_tenthietbi
            // 
            this.tb_tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenthietbi.Location = new System.Drawing.Point(126, 6);
            this.tb_tenthietbi.Name = "tb_tenthietbi";
            this.tb_tenthietbi.Size = new System.Drawing.Size(192, 26);
            this.tb_tenthietbi.TabIndex = 5;
            this.tb_tenthietbi.TextChanged += new System.EventHandler(this.tb_tenthietbi_TextChanged);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(674, -1);
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
            this.btn_huy.Location = new System.Drawing.Point(674, 46);
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
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Combo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giảm giá";
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giamgia.Location = new System.Drawing.Point(442, 6);
            this.tb_giamgia.MaxLength = 4;
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.Size = new System.Drawing.Size(226, 26);
            this.tb_giamgia.TabIndex = 17;
            this.tb_giamgia.TextChanged += new System.EventHandler(this.tb_giamgia_TextChanged);
            // 
            // lv_productincombo
            // 
            this.lv_productincombo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_productincombo.FullRowSelect = true;
            this.lv_productincombo.HideSelection = false;
            this.lv_productincombo.Location = new System.Drawing.Point(12, 135);
            this.lv_productincombo.MultiSelect = false;
            this.lv_productincombo.Name = "lv_productincombo";
            this.lv_productincombo.Size = new System.Drawing.Size(712, 318);
            this.lv_productincombo.TabIndex = 19;
            this.lv_productincombo.UseCompatibleStateImageBehavior = false;
            this.lv_productincombo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng theo combo";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá gốc";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng giá gốc";
            this.columnHeader5.Width = 100;
            // 
            // btn_themsanpham
            // 
            this.btn_themsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_themsanpham.Location = new System.Drawing.Point(300, 105);
            this.btn_themsanpham.Name = "btn_themsanpham";
            this.btn_themsanpham.Size = new System.Drawing.Size(161, 24);
            this.btn_themsanpham.TabIndex = 20;
            this.btn_themsanpham.Text = "Thêm sản phẩm vào combo";
            this.btn_themsanpham.UseVisualStyleBackColor = true;
            this.btn_themsanpham.Click += new System.EventHandler(this.themSanPhamVaoComboClick);
            // 
            // btn_xoasanpham
            // 
            this.btn_xoasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_xoasanpham.Location = new System.Drawing.Point(580, 105);
            this.btn_xoasanpham.Name = "btn_xoasanpham";
            this.btn_xoasanpham.Size = new System.Drawing.Size(144, 24);
            this.btn_xoasanpham.TabIndex = 21;
            this.btn_xoasanpham.Text = "Xóa sản phẩm khỏi combo";
            this.btn_xoasanpham.UseVisualStyleBackColor = true;
            this.btn_xoasanpham.Click += new System.EventHandler(this.btn_xoaThietBiKhoiCombo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách sản phẩm trong combo";
            // 
            // btn_thaydoisoluong
            // 
            this.btn_thaydoisoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_thaydoisoluong.Location = new System.Drawing.Point(467, 105);
            this.btn_thaydoisoluong.Name = "btn_thaydoisoluong";
            this.btn_thaydoisoluong.Size = new System.Drawing.Size(107, 24);
            this.btn_thaydoisoluong.TabIndex = 29;
            this.btn_thaydoisoluong.Text = "Thay đổi số lượng";
            this.btn_thaydoisoluong.UseVisualStyleBackColor = true;
            this.btn_thaydoisoluong.Click += new System.EventHandler(this.btn_thaydoisoluong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Giá combo";
            // 
            // tb_giacombo
            // 
            this.tb_giacombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giacombo.Location = new System.Drawing.Point(456, 53);
            this.tb_giacombo.MaxLength = 4;
            this.tb_giacombo.Name = "tb_giacombo";
            this.tb_giacombo.ReadOnly = true;
            this.tb_giacombo.Size = new System.Drawing.Size(212, 26);
            this.tb_giacombo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tổng giá sản phẩm";
            // 
            // tb_tonggiasanpham
            // 
            this.tb_tonggiasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tonggiasanpham.Location = new System.Drawing.Point(162, 53);
            this.tb_tonggiasanpham.MaxLength = 4;
            this.tb_tonggiasanpham.Name = "tb_tonggiasanpham";
            this.tb_tonggiasanpham.ReadOnly = true;
            this.tb_tonggiasanpham.Size = new System.Drawing.Size(196, 26);
            this.tb_tonggiasanpham.TabIndex = 33;
            // 
            // ChiTietCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 465);
            this.Controls.Add(this.tb_tonggiasanpham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_giacombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thaydoisoluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoasanpham);
            this.Controls.Add(this.btn_themsanpham);
            this.Controls.Add(this.lv_productincombo);
            this.Controls.Add(this.tb_giamgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tb_tenthietbi);
            this.Name = "ChiTietCombo";
            this.Load += new System.EventHandler(this.ChiTietCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_tenthietbi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_giamgia;
        private System.Windows.Forms.ListView lv_productincombo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_themsanpham;
        private System.Windows.Forms.Button btn_xoasanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thaydoisoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_giacombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tonggiasanpham;
    }
}
