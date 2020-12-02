using DuLich.BUS;
using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyDoan
{
    partial class DanhSachDoan
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
            this.dataGridViewDoan = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.searchDoan1 = new DuLich.GUI.QuanLyDoan.SearchDoan();
            this.doanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maDoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoan
            // 
            this.dataGridViewDoan.AllowUserToAddRows = false;
            this.dataGridViewDoan.AllowUserToDeleteRows = false;
            this.dataGridViewDoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoan.AutoGenerateColumns = false;
            this.dataGridViewDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoanDataGridViewTextBoxColumn,
            this.tenDoanDataGridViewTextBoxColumn,
            this.thoiGianBatDauDataGridViewTextBoxColumn,
            this.thoiGianKetThucDataGridViewTextBoxColumn});
            this.dataGridViewDoan.DataSource = this.doanBindingSource;
            this.dataGridViewDoan.Location = new System.Drawing.Point(0, 113);
            this.dataGridViewDoan.MultiSelect = false;
            this.dataGridViewDoan.Name = "dataGridViewDoan";
            this.dataGridViewDoan.ReadOnly = true;
            this.dataGridViewDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoan.Size = new System.Drawing.Size(800, 487);
            this.dataGridViewDoan.TabIndex = 1;
            this.dataGridViewDoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDoanDoubleClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::DuLich.Properties.Resources.remove;
            this.btn_xoa.Location = new System.Drawing.Point(747, 33);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(40, 40);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DuLich.Properties.Resources.plus;
            this.btn_them.Location = new System.Drawing.Point(701, 33);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(40, 40);
            this.btn_them.TabIndex = 4;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // searchDoan1
            // 
            this.searchDoan1.Location = new System.Drawing.Point(3, 4);
            this.searchDoan1.Name = "searchDoan1";
            this.searchDoan1.Size = new System.Drawing.Size(670, 103);
            this.searchDoan1.TabIndex = 2;
            // 
            // doanBindingSource
            // 
            this.doanBindingSource.DataSource = typeof(DuLich.BUS.Doan);
            // 
            // maDoanDataGridViewTextBoxColumn
            // 
            this.maDoanDataGridViewTextBoxColumn.DataPropertyName = "MaDoan";
            this.maDoanDataGridViewTextBoxColumn.HeaderText = "Mã đoàn";
            this.maDoanDataGridViewTextBoxColumn.Name = "maDoanDataGridViewTextBoxColumn";
            this.maDoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDoanDataGridViewTextBoxColumn
            // 
            this.tenDoanDataGridViewTextBoxColumn.DataPropertyName = "TenDoan";
            this.tenDoanDataGridViewTextBoxColumn.HeaderText = "Tên đoàn";
            this.tenDoanDataGridViewTextBoxColumn.Name = "tenDoanDataGridViewTextBoxColumn";
            this.tenDoanDataGridViewTextBoxColumn.ReadOnly = true;
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
            // DanhSachDoan
            // 
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.searchDoan1);
            this.Controls.Add(this.dataGridViewDoan);
            this.Name = "DanhSachDoan";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.DanhSachDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion
        private System.Windows.Forms.BindingSource tourisBindingSource;
        private System.Windows.Forms.ColumnHeader loai_tour;
        private System.Windows.Forms.DataGridView dataGridViewDoan;
        private SearchDoan searchDoan1;
        private Button btn_xoa;
        private Button btn_them;
        private DataGridViewTextBoxColumn maDoanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDoanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianBatDauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianKetThucDataGridViewTextBoxColumn;
        private BindingSource doanBindingSource;
    }
}
