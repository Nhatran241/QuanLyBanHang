using DuLich.BUS;
using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyTouris
{
    partial class DanhSachGia : UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_them_gia = new System.Windows.Forms.Button();
            this.btn_xoa_gia = new System.Windows.Forms.Button();
            this.btn_sua_gia = new System.Windows.Forms.Button();
            this.dataGridViewGia = new System.Windows.Forms.DataGridView();
            this.maGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them_gia
            // 
            this.btn_them_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_gia.Location = new System.Drawing.Point(17, 4);
            this.btn_them_gia.Name = "btn_them_gia";
            this.btn_them_gia.Size = new System.Drawing.Size(85, 25);
            this.btn_them_gia.TabIndex = 1;
            this.btn_them_gia.Text = "Thêm";
            this.btn_them_gia.UseVisualStyleBackColor = true;
            this.btn_them_gia.Click += new System.EventHandler(this.btn_them_gia_Click);
            // 
            // btn_xoa_gia
            // 
            this.btn_xoa_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_gia.Location = new System.Drawing.Point(689, 4);
            this.btn_xoa_gia.Name = "btn_xoa_gia";
            this.btn_xoa_gia.Size = new System.Drawing.Size(78, 25);
            this.btn_xoa_gia.TabIndex = 2;
            this.btn_xoa_gia.Text = "Xóa";
            this.btn_xoa_gia.UseVisualStyleBackColor = true;
            this.btn_xoa_gia.Click += new System.EventHandler(this.btn_xoa_gia_Click);
            // 
            // btn_sua_gia
            // 
            this.btn_sua_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_gia.Location = new System.Drawing.Point(353, 4);
            this.btn_sua_gia.Name = "btn_sua_gia";
            this.btn_sua_gia.Size = new System.Drawing.Size(87, 25);
            this.btn_sua_gia.TabIndex = 3;
            this.btn_sua_gia.Text = "Sửa";
            this.btn_sua_gia.UseVisualStyleBackColor = true;
            this.btn_sua_gia.Click += new System.EventHandler(this.btn_sua_gia_Click);
            // 
            // dataGridViewGia
            // 
            this.dataGridViewGia.AllowUserToAddRows = false;
            this.dataGridViewGia.AllowUserToDeleteRows = false;
            this.dataGridViewGia.AutoGenerateColumns = false;
            this.dataGridViewGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiaDataGridViewTextBoxColumn,
            this.giaTriDataGridViewTextBoxColumn,
            this.thoiGianBatDauDataGridViewTextBoxColumn,
            this.thoiGianKetThucDataGridViewTextBoxColumn});
            this.dataGridViewGia.DataSource = this.giaBindingSource;
            this.dataGridViewGia.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewGia.MultiSelect = false;
            this.dataGridViewGia.Name = "dataGridViewGia";
            this.dataGridViewGia.ReadOnly = true;
            this.dataGridViewGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGia.Size = new System.Drawing.Size(767, 376);
            this.dataGridViewGia.TabIndex = 0;
            this.dataGridViewGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiaClick);
            this.dataGridViewGia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiaDoubleClick);
            // 
            // maGiaDataGridViewTextBoxColumn
            // 
            this.maGiaDataGridViewTextBoxColumn.DataPropertyName = "MaGia";
            this.maGiaDataGridViewTextBoxColumn.HeaderText = "Mã giá";
            this.maGiaDataGridViewTextBoxColumn.Name = "maGiaDataGridViewTextBoxColumn";
            this.maGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriDataGridViewTextBoxColumn
            // 
            this.giaTriDataGridViewTextBoxColumn.DataPropertyName = "GiaTri";
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = null;
            this.giaTriDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.giaTriDataGridViewTextBoxColumn.HeaderText = "Giá trị";
            this.giaTriDataGridViewTextBoxColumn.Name = "giaTriDataGridViewTextBoxColumn";
            this.giaTriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianBatDauDataGridViewTextBoxColumn
            // 
            this.thoiGianBatDauDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianBatDau";
            this.thoiGianBatDauDataGridViewTextBoxColumn.HeaderText = "Thời gian bắt đầu";
            this.thoiGianBatDauDataGridViewTextBoxColumn.Name = "thoiGianBatDauDataGridViewTextBoxColumn";
            this.thoiGianBatDauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianKetThucDataGridViewTextBoxColumn
            // 
            this.thoiGianKetThucDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianKetThuc";
            this.thoiGianKetThucDataGridViewTextBoxColumn.HeaderText = "Thời gian kết thúc";
            this.thoiGianKetThucDataGridViewTextBoxColumn.Name = "thoiGianKetThucDataGridViewTextBoxColumn";
            this.thoiGianKetThucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaBindingSource
            // 
            this.giaBindingSource.DataSource = typeof(DuLich.BUS.Gia);
            // 
            // tourisBindingSource
            // 
            this.tourisBindingSource.DataSource = typeof(DuLich.BUS.Tour);
            // 
            // DanhSachGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGia);
            this.Controls.Add(this.btn_sua_gia);
            this.Controls.Add(this.btn_xoa_gia);
            this.Controls.Add(this.btn_them_gia);
            this.Name = "DanhSachGia";
            this.Size = new System.Drawing.Size(767, 414);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Button btn_them_gia;
        private Button btn_xoa_gia;
        private Button btn_sua_gia;
        private DataGridView dataGridViewGia;
        private BindingSource tourisBindingSource;
        private BindingSource giaBindingSource;
        private DataGridViewTextBoxColumn maGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaTriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianBatDauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianKetThucDataGridViewTextBoxColumn;
    }
}
