using DuLich.BUS;

namespace DuLich.GUI.QuanLyChiPhi
{
    partial class DanhSachChiPhi
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
            this.btn_them_doan = new System.Windows.Forms.Button();
            this.btn_xoa_doan = new System.Windows.Forms.Button();
            this.btn_sua_doan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chiPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maChiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiChiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiPhiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them_doan
            // 
            this.btn_them_doan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_them_doan.Location = new System.Drawing.Point(13, 3);
            this.btn_them_doan.Name = "btn_them_doan";
            this.btn_them_doan.Size = new System.Drawing.Size(80, 29);
            this.btn_them_doan.TabIndex = 9;
            this.btn_them_doan.Text = "Thêm";
            this.btn_them_doan.UseVisualStyleBackColor = true;
            this.btn_them_doan.Click += new System.EventHandler(this.btn_them_doan_Click);
            // 
            // btn_xoa_doan
            // 
            this.btn_xoa_doan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_xoa_doan.Location = new System.Drawing.Point(665, 1);
            this.btn_xoa_doan.Name = "btn_xoa_doan";
            this.btn_xoa_doan.Size = new System.Drawing.Size(86, 32);
            this.btn_xoa_doan.TabIndex = 11;
            this.btn_xoa_doan.Text = "Xóa";
            this.btn_xoa_doan.UseVisualStyleBackColor = true;
            this.btn_xoa_doan.Click += new System.EventHandler(this.btn_xoa_doan_Click);
            // 
            // btn_sua_doan
            // 
            this.btn_sua_doan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sua_doan.Location = new System.Drawing.Point(331, 1);
            this.btn_sua_doan.Name = "btn_sua_doan";
            this.btn_sua_doan.Size = new System.Drawing.Size(89, 29);
            this.btn_sua_doan.TabIndex = 10;
            this.btn_sua_doan.Text = "Sửa";
            this.btn_sua_doan.UseVisualStyleBackColor = true;
            this.btn_sua_doan.Click += new System.EventHandler(this.btn_sua_doan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChiPhiDataGridViewTextBoxColumn,
            this.loaiChiPhiDataGridViewTextBoxColumn,
            this.giaTriDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiPhiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 363);
            this.dataGridView1.TabIndex = 15;
            // 
            // chiPhiBindingSource
            // 
            this.chiPhiBindingSource.DataSource = typeof(DuLich.BUS.ChiPhi);
            // 
            // maChiPhiDataGridViewTextBoxColumn
            // 
            this.maChiPhiDataGridViewTextBoxColumn.DataPropertyName = "MaChiPhi";
            this.maChiPhiDataGridViewTextBoxColumn.HeaderText = "Mã chi phí";
            this.maChiPhiDataGridViewTextBoxColumn.Name = "maChiPhiDataGridViewTextBoxColumn";
            this.maChiPhiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiChiPhiDataGridViewTextBoxColumn
            // 
            this.loaiChiPhiDataGridViewTextBoxColumn.DataPropertyName = "LoaiChiPhi";
            this.loaiChiPhiDataGridViewTextBoxColumn.HeaderText = "Loại chi phí";
            this.loaiChiPhiDataGridViewTextBoxColumn.Name = "loaiChiPhiDataGridViewTextBoxColumn";
            this.loaiChiPhiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriDataGridViewTextBoxColumn
            // 
            this.giaTriDataGridViewTextBoxColumn.DataPropertyName = "GiaTri";
            this.giaTriDataGridViewTextBoxColumn.HeaderText = "Giá trị";
            this.giaTriDataGridViewTextBoxColumn.Name = "giaTriDataGridViewTextBoxColumn";
            this.giaTriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DanhSachChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_them_doan);
            this.Controls.Add(this.btn_xoa_doan);
            this.Controls.Add(this.btn_sua_doan);
            this.Name = "DanhSachChiPhi";
            this.Size = new System.Drawing.Size(767, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiPhiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them_doan;
        private System.Windows.Forms.Button btn_xoa_doan;
        private System.Windows.Forms.Button btn_sua_doan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiChiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiPhiBindingSource;
    }
}
