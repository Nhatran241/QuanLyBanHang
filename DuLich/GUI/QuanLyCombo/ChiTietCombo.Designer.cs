
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_themsanpham = new System.Windows.Forms.Button();
            this.btn_xoasanpham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_thaydoisoluong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_tenthietbi
            // 
            this.tb_tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenthietbi.Location = new System.Drawing.Point(126, 6);
            this.tb_tenthietbi.Name = "tb_tenthietbi";
            this.tb_tenthietbi.Size = new System.Drawing.Size(263, 26);
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
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giảm giá";
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giamgia.Location = new System.Drawing.Point(126, 46);
            this.tb_giamgia.MaxLength = 4;
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.Size = new System.Drawing.Size(263, 26);
            this.tb_giamgia.TabIndex = 17;
            this.tb_giamgia.TextChanged += new System.EventHandler(this.tb_giamgia_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 292);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.btn_xoasanpham.Click += new System.EventHandler(this.button2_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(261, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tổng giá gốc của các sản phẩm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(550, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tổng giá sau giảm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(434, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "10,000,000đ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(656, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "10,000,000đ";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(13, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tổng sản phẩm trong combo :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(168, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "2";
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
            // 
            // ChiTietCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 465);
            this.Controls.Add(this.btn_thaydoisoluong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoasanpham);
            this.Controls.Add(this.btn_themsanpham);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_themsanpham;
        private System.Windows.Forms.Button btn_xoasanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_thaydoisoluong;
    }
}
