using DuLich.BUS;
using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyTouris
{
    partial class DanhSachTour
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
            this.dataGridViewTour = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.search1 = new DuLich.GUI.QuanLyTouris.SearchTour();
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTour
            // 
            this.dataGridViewTour.AllowUserToAddRows = false;
            this.dataGridViewTour.AllowUserToDeleteRows = false;
            this.dataGridViewTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTour.AutoGenerateColumns = false;
            this.dataGridViewTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTourDataGridViewTextBoxColumn,
            this.tenTourDataGridViewTextBoxColumn,
            this.loaiTourDataGridViewTextBoxColumn});
            this.dataGridViewTour.DataSource = this.tourBindingSource;
            this.dataGridViewTour.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewTour.MultiSelect = false;
            this.dataGridViewTour.Name = "dataGridViewTour";
            this.dataGridViewTour.ReadOnly = true;
            this.dataGridViewTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTour.Size = new System.Drawing.Size(800, 535);
            this.dataGridViewTour.TabIndex = 0;
            this.dataGridViewTour.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TourSelected);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DuLich.Properties.Resources.plus;
            this.btn_them.Location = new System.Drawing.Point(688, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(40, 40);
            this.btn_them.TabIndex = 2;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::DuLich.Properties.Resources.remove;
            this.btn_xoa.Location = new System.Drawing.Point(747, 12);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(40, 40);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // search1
            // 
            this.search1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search1.AutoSize = true;
            this.search1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search1.Location = new System.Drawing.Point(3, 8);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(601, 44);
            this.search1.TabIndex = 1;
            // 
            // tourisBindingSource
            // 
            this.tourisBindingSource.DataSource = typeof(DuLich.BUS.Tour);
            this.tourisBindingSource.CurrentChanged += new System.EventHandler(this.tourisBindingSource_CurrentChanged);
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataSource = typeof(DuLich.BUS.Tour);
            // 
            // maTourDataGridViewTextBoxColumn
            // 
            this.maTourDataGridViewTextBoxColumn.DataPropertyName = "MaTour";
            this.maTourDataGridViewTextBoxColumn.FillWeight = 472F;
            this.maTourDataGridViewTextBoxColumn.HeaderText = "Mã tour";
            this.maTourDataGridViewTextBoxColumn.Name = "maTourDataGridViewTextBoxColumn";
            this.maTourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTourDataGridViewTextBoxColumn
            // 
            this.tenTourDataGridViewTextBoxColumn.DataPropertyName = "TenTour";
            this.tenTourDataGridViewTextBoxColumn.FillWeight = 472F;
            this.tenTourDataGridViewTextBoxColumn.HeaderText = "Tên tour";
            this.tenTourDataGridViewTextBoxColumn.Name = "tenTourDataGridViewTextBoxColumn";
            this.tenTourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiTourDataGridViewTextBoxColumn
            // 
            this.loaiTourDataGridViewTextBoxColumn.DataPropertyName = "LoaiTour";
            this.loaiTourDataGridViewTextBoxColumn.FillWeight = 472F;
            this.loaiTourDataGridViewTextBoxColumn.HeaderText = "Loại tour";
            this.loaiTourDataGridViewTextBoxColumn.Name = "loaiTourDataGridViewTextBoxColumn";
            this.loaiTourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DanhSachTour
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.dataGridViewTour);
            this.Name = "DanhSachTour";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTour;
        private System.Windows.Forms.BindingSource tourisBindingSource;
        private SearchTour search1;
        private Button btn_them;
        private Button btn_xoa;
        private BindingSource tourBindingSource;
        private DataGridViewTextBoxColumn maTourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenTourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiTourDataGridViewTextBoxColumn;
    }
}
