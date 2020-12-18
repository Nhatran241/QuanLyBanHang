
namespace DuLich.GUI.QuanLyDonHang
{
    partial class ChiTietDonHang
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
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_details = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_themsanpham = new System.Windows.Forms.Button();
            this.btn_xoasanpham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thaydoisoluong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tonggiasanpham = new System.Windows.Forms.TextBox();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái";
            // 
            // lv_details
            // 
            this.lv_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lv_details.FullRowSelect = true;
            this.lv_details.HideSelection = false;
            this.lv_details.Location = new System.Drawing.Point(12, 135);
            this.lv_details.MultiSelect = false;
            this.lv_details.Name = "lv_details";
            this.lv_details.Size = new System.Drawing.Size(712, 318);
            this.lv_details.TabIndex = 19;
            this.lv_details.UseCompatibleStateImageBehavior = false;
            this.lv_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã chi tiết";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm / Combo";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng";
            this.columnHeader6.Width = 100;
            // 
            // btn_themsanpham
            // 
            this.btn_themsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_themsanpham.Location = new System.Drawing.Point(300, 105);
            this.btn_themsanpham.Name = "btn_themsanpham";
            this.btn_themsanpham.Size = new System.Drawing.Size(161, 24);
            this.btn_themsanpham.TabIndex = 20;
            this.btn_themsanpham.Text = "Thêm chi tiết";
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
            this.btn_xoasanpham.Text = "Xóa chi tiết";
            this.btn_xoasanpham.UseVisualStyleBackColor = true;
            this.btn_xoasanpham.Click += new System.EventHandler(this.btn_xoaThietBiKhoiCombo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh Sách chi tiết đơn hàng";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tổng tiền";
            // 
            // tb_tonggiasanpham
            // 
            this.tb_tonggiasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tonggiasanpham.Location = new System.Drawing.Point(126, 53);
            this.tb_tonggiasanpham.MaxLength = 4;
            this.tb_tonggiasanpham.Name = "tb_tonggiasanpham";
            this.tb_tonggiasanpham.ReadOnly = true;
            this.tb_tonggiasanpham.Size = new System.Drawing.Size(196, 26);
            this.tb_tonggiasanpham.TabIndex = 33;
            this.tb_tonggiasanpham.TextChanged += new System.EventHandler(this.tb_tonggiasanpham_TextChanged);
            // 
            // cb_customer
            // 
            this.cb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(126, 9);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(196, 21);
            this.cb_customer.TabIndex = 34;
            this.cb_customer.SelectedIndexChanged += new System.EventHandler(this.cb_customer_SelectedIndexChanged);
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(445, 8);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(196, 21);
            this.cb_status.TabIndex = 35;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // ChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 465);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_customer);
            this.Controls.Add(this.tb_tonggiasanpham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_thaydoisoluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoasanpham);
            this.Controls.Add(this.btn_themsanpham);
            this.Controls.Add(this.lv_details);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Name = "ChiTietDonHang";
            this.Load += new System.EventHandler(this.ChiTietCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_details;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_themsanpham;
        private System.Windows.Forms.Button btn_xoasanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thaydoisoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tonggiasanpham;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.ComboBox cb_status;
    }
}
