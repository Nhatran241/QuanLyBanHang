using DuLich.BUS;

namespace DuLich.GUI.QuanLyNhanVien
{
    partial class DanhSachNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.btn_them_nhanvien = new System.Windows.Forms.Button();
            this.btn_xoa_nhanvien = new System.Windows.Forms.Button();
            this.btn_sua_nhanvien = new System.Windows.Forms.Button();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchNhanVien1 = new DuLich.GUI.QuanLyNhanVien.SearchNhanVien();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them_nhanvien
            // 
            this.btn_them_nhanvien.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btn_them_nhanvien.Location = new System.Drawing.Point(19, 96);
            this.btn_them_nhanvien.Name = "btn_them_nhanvien";
            this.btn_them_nhanvien.Size = new System.Drawing.Size(84, 33);
            this.btn_them_nhanvien.TabIndex = 9;
            this.btn_them_nhanvien.Text = "Thêm";
            this.btn_them_nhanvien.UseVisualStyleBackColor = true;
            this.btn_them_nhanvien.Click += new System.EventHandler(this.btn_them_nhanvien_Click);
            // 
            // btn_xoa_nhanvien
            // 
            this.btn_xoa_nhanvien.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btn_xoa_nhanvien.Location = new System.Drawing.Point(685, 96);
            this.btn_xoa_nhanvien.Name = "btn_xoa_nhanvien";
            this.btn_xoa_nhanvien.Size = new System.Drawing.Size(84, 33);
            this.btn_xoa_nhanvien.TabIndex = 11;
            this.btn_xoa_nhanvien.Text = "Xóa";
            this.btn_xoa_nhanvien.UseVisualStyleBackColor = true;
            this.btn_xoa_nhanvien.Click += new System.EventHandler(this.btn_xoa_nhanvien_Click);
            // 
            // btn_sua_nhanvien
            // 
            this.btn_sua_nhanvien.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btn_sua_nhanvien.Location = new System.Drawing.Point(341, 96);
            this.btn_sua_nhanvien.Name = "btn_sua_nhanvien";
            this.btn_sua_nhanvien.Size = new System.Drawing.Size(84, 33);
            this.btn_sua_nhanvien.TabIndex = 10;
            this.btn_sua_nhanvien.Text = "Sửa";
            this.btn_sua_nhanvien.UseVisualStyleBackColor = true;
            this.btn_sua_nhanvien.Click += new System.EventHandler(this.btn_sua_nhanvien_Click);
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToAddRows = false;
            this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewNhanVien.AllowUserToOrderColumns = true;
            this.dataGridViewNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNhanVien.AutoGenerateColumns = false;
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.soCmndDataGridViewTextBoxColumn,
            this.NgaySinh,
            this.GioiTinh});
            this.dataGridViewNhanVien.DataSource = this.nhanVienBindingSource1;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(-3, 138);
            this.dataGridViewNhanVien.MultiSelect = false;
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(800, 459);
            this.dataGridViewNhanVien.TabIndex = 12;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // searchNhanVien1
            // 
            this.searchNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.searchNhanVien1.Name = "searchNhanVien1";
            this.searchNhanVien1.Size = new System.Drawing.Size(800, 90);
            this.searchNhanVien1.TabIndex = 13;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Đia chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soCmndDataGridViewTextBoxColumn
            // 
            this.soCmndDataGridViewTextBoxColumn.DataPropertyName = "SoCmnd";
            this.soCmndDataGridViewTextBoxColumn.HeaderText = "Số chứng minh ";
            this.soCmndDataGridViewTextBoxColumn.Name = "soCmndDataGridViewTextBoxColumn";
            this.soCmndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataSource = typeof(DuLich.BUS.NhanVien);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(DuLich.BUS.NhanVien);
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchNhanVien1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.btn_them_nhanvien);
            this.Controls.Add(this.btn_xoa_nhanvien);
            this.Controls.Add(this.btn_sua_nhanvien);
            this.Name = "DanhSachNhanVien";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them_nhanvien;
        private System.Windows.Forms.Button btn_xoa_nhanvien;
        private System.Windows.Forms.Button btn_sua_nhanvien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private SearchNhanVien searchNhanVien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}
