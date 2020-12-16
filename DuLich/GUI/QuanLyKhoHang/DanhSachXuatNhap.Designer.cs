using DuLich.BUS;
using DuLich.GUI.QuanLyTouris;
using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyKhoHang
{
    partial class DanhSachXuatNhap
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lv_product = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search1 = new DuLich.GUI.QuanLyKhoHang.TimKiemKhoHang();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // lv_product
            // 
            this.lv_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader12,
            this.columnHeader13});
            this.lv_product.FullRowSelect = true;
            this.lv_product.HideSelection = false;
            this.lv_product.Location = new System.Drawing.Point(3, 103);
            this.lv_product.MultiSelect = false;
            this.lv_product.Name = "lv_product";
            this.lv_product.Size = new System.Drawing.Size(794, 494);
            this.lv_product.TabIndex = 4;
            this.lv_product.UseCompatibleStateImageBehavior = false;
            this.lv_product.View = System.Windows.Forms.View.Details;
            this.lv_product.SelectedIndexChanged += new System.EventHandler(this.lv_product_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã phiếu";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sản phẩm";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số lượng";
            this.columnHeader12.Width = 160;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ngày tạo";
            this.columnHeader13.Width = 160;
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
            this.search1.Size = new System.Drawing.Size(683, 89);
            this.search1.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DuLich.BanHang_Entity.product);
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataSource = typeof(DuLich.BUS.Tour);
            // 
            // tourisBindingSource
            // 
            this.tourisBindingSource.DataSource = typeof(DuLich.BUS.Tour);
            this.tourisBindingSource.CurrentChanged += new System.EventHandler(this.tourisBindingSource_CurrentChanged);
            // 
            // DanhSachXuatNhap
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lv_product);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.search1);
            this.Name = "DanhSachXuatNhap";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.BindingSource tourisBindingSource;
        private TimKiemKhoHang search1;
        private Button btn_them;
        private Button btn_xoa;
        private BindingSource tourBindingSource;
        private DataGridViewTextBoxColumn catalogIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDetailDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private ListView lv_product;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
    }
}
