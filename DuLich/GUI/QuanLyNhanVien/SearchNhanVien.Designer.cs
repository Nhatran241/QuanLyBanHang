
namespace DuLich.GUI.QuanLyNhanVien
{
    partial class SearchNhanVien
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tv_searchbox = new System.Windows.Forms.Label();
            this.datepicker_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.datepicker_batdau = new System.Windows.Forms.DateTimePicker();
            this.tv_ngayketthuc = new System.Windows.Forms.Label();
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_search.Location = new System.Drawing.Point(67, 49);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(210, 26);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // tv_searchbox
            // 
            this.tv_searchbox.AutoSize = true;
            this.tv_searchbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tv_searchbox.Location = new System.Drawing.Point(3, 52);
            this.tv_searchbox.Name = "tv_searchbox";
            this.tv_searchbox.Size = new System.Drawing.Size(31, 20);
            this.tv_searchbox.TabIndex = 3;
            this.tv_searchbox.Text = "Tên";
            // 
            // datepicker_ketthuc
            // 
            this.datepicker_ketthuc.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.datepicker_ketthuc.Location = new System.Drawing.Point(436, 5);
            this.datepicker_ketthuc.Name = "datepicker_ketthuc";
            this.datepicker_ketthuc.Size = new System.Drawing.Size(181, 20);
            this.datepicker_ketthuc.TabIndex = 31;
            this.datepicker_ketthuc.ValueChanged += new System.EventHandler(this.datepicker_ketthuc_ValueChanged);
            // 
            // datepicker_batdau
            // 
            this.datepicker_batdau.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.datepicker_batdau.Location = new System.Drawing.Point(131, 5);
            this.datepicker_batdau.Name = "datepicker_batdau";
            this.datepicker_batdau.Size = new System.Drawing.Size(181, 20);
            this.datepicker_batdau.TabIndex = 30;
            this.datepicker_batdau.ValueChanged += new System.EventHandler(this.datepicker_batdau_ValueChanged);
            // 
            // tv_ngayketthuc
            // 
            this.tv_ngayketthuc.AutoSize = true;
            this.tv_ngayketthuc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tv_ngayketthuc.Location = new System.Drawing.Point(372, 5);
            this.tv_ngayketthuc.Name = "tv_ngayketthuc";
            this.tv_ngayketthuc.Size = new System.Drawing.Size(42, 20);
            this.tv_ngayketthuc.TabIndex = 29;
            this.tv_ngayketthuc.Text = "Đến :";
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tv_ngaybatdau.Location = new System.Drawing.Point(3, 5);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(111, 20);
            this.tv_ngaybatdau.TabIndex = 28;
            this.tv_ngaybatdau.Text = "Có ngày sinh từ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(372, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Giới Tính";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Location = new System.Drawing.Point(452, 49);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(206, 28);
            this.cb_gioitinh.TabIndex = 33;
            this.cb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioitinh_SelectedIndexChanged);
            // 
            // SearchNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepicker_ketthuc);
            this.Controls.Add(this.datepicker_batdau);
            this.Controls.Add(this.tv_ngayketthuc);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Controls.Add(this.tv_searchbox);
            this.Controls.Add(this.tb_search);
            this.Name = "SearchNhanVien";
            this.Size = new System.Drawing.Size(800, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label tv_searchbox;
        private System.Windows.Forms.DateTimePicker datepicker_ketthuc;
        private System.Windows.Forms.DateTimePicker datepicker_batdau;
        private System.Windows.Forms.Label tv_ngayketthuc;
        private System.Windows.Forms.Label tv_ngaybatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gioitinh;
    }
}
