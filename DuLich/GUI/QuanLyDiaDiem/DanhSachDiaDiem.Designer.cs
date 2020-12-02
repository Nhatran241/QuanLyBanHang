using DuLich.BUS;
using System;

namespace DuLich.GUI.QuanLyDiaDiem
{
    partial class DanhSachDiaDiem
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
            this.btn_sua_diadiem = new System.Windows.Forms.Button();
            this.btn_xoa_diadiem = new System.Windows.Forms.Button();
            this.btn_them_diadiem = new System.Windows.Forms.Button();
            this.dataGridViewDiaDiem = new System.Windows.Forms.DataGridView();
            this.maDienDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiaDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sua_diadiem
            // 
            this.btn_sua_diadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_diadiem.Location = new System.Drawing.Point(366, 9);
            this.btn_sua_diadiem.Name = "btn_sua_diadiem";
            this.btn_sua_diadiem.Size = new System.Drawing.Size(81, 28);
            this.btn_sua_diadiem.TabIndex = 6;
            this.btn_sua_diadiem.Text = "Sửa";
            this.btn_sua_diadiem.UseVisualStyleBackColor = true;
            this.btn_sua_diadiem.Click += new System.EventHandler(this.btn_sua_diadiem_Click);
            // 
            // btn_xoa_diadiem
            // 
            this.btn_xoa_diadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_diadiem.Location = new System.Drawing.Point(705, 9);
            this.btn_xoa_diadiem.Name = "btn_xoa_diadiem";
            this.btn_xoa_diadiem.Size = new System.Drawing.Size(78, 28);
            this.btn_xoa_diadiem.TabIndex = 5;
            this.btn_xoa_diadiem.Text = "Xóa";
            this.btn_xoa_diadiem.UseVisualStyleBackColor = true;
            this.btn_xoa_diadiem.Click += new System.EventHandler(this.btn_xoa_diadiem_Click);
            // 
            // btn_them_diadiem
            // 
            this.btn_them_diadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_diadiem.Location = new System.Drawing.Point(14, 9);
            this.btn_them_diadiem.Name = "btn_them_diadiem";
            this.btn_them_diadiem.Size = new System.Drawing.Size(83, 28);
            this.btn_them_diadiem.TabIndex = 4;
            this.btn_them_diadiem.Text = "Thêm";
            this.btn_them_diadiem.UseVisualStyleBackColor = true;
            this.btn_them_diadiem.Click += new System.EventHandler(this.btn_them_diadiem_Click);
            // 
            // dataGridViewDiaDiem
            // 
            this.dataGridViewDiaDiem.AllowUserToAddRows = false;
            this.dataGridViewDiaDiem.AllowUserToDeleteRows = false;
            this.dataGridViewDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDiaDiem.AutoGenerateColumns = false;
            this.dataGridViewDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiaDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDienDiemDataGridViewTextBoxColumn,
            this.tenDiaDiemDataGridViewTextBoxColumn});
            this.dataGridViewDiaDiem.DataSource = this.diaDiemBindingSource;
            this.dataGridViewDiaDiem.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewDiaDiem.MultiSelect = false;
            this.dataGridViewDiaDiem.Name = "dataGridViewDiaDiem";
            this.dataGridViewDiaDiem.ReadOnly = true;
            this.dataGridViewDiaDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiaDiem.Size = new System.Drawing.Size(800, 550);
            this.dataGridViewDiaDiem.TabIndex = 7;
            this.dataGridViewDiaDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiaDiem_CellContentClick);
            // 
            // maDienDiemDataGridViewTextBoxColumn
            // 
            this.maDienDiemDataGridViewTextBoxColumn.DataPropertyName = "MaDienDiem";
            this.maDienDiemDataGridViewTextBoxColumn.HeaderText = "Mã đia điểm";
            this.maDienDiemDataGridViewTextBoxColumn.Name = "maDienDiemDataGridViewTextBoxColumn";
            this.maDienDiemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDiaDiemDataGridViewTextBoxColumn
            // 
            this.tenDiaDiemDataGridViewTextBoxColumn.DataPropertyName = "TenDiaDiem";
            this.tenDiaDiemDataGridViewTextBoxColumn.HeaderText = "Tên địa điểm";
            this.tenDiaDiemDataGridViewTextBoxColumn.Name = "tenDiaDiemDataGridViewTextBoxColumn";
            this.tenDiaDiemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDiemBindingSource
            // 
            this.diaDiemBindingSource.DataSource = typeof(DuLich.BUS.DiaDiem);
            // 
            // DanhSachDiaDiem
            // 
            this.Controls.Add(this.dataGridViewDiaDiem);
            this.Controls.Add(this.btn_sua_diadiem);
            this.Controls.Add(this.btn_xoa_diadiem);
            this.Controls.Add(this.btn_them_diadiem);
            this.Name = "DanhSachDiaDiem";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button btn_sua_diadiem;
        private System.Windows.Forms.Button btn_xoa_diadiem;
        private System.Windows.Forms.Button btn_them_diadiem;
        private System.Windows.Forms.DataGridView dataGridViewDiaDiem;
        private System.Windows.Forms.BindingSource diaDiemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDienDiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDiemDataGridViewTextBoxColumn;
    }
}
