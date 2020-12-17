using DuLich.BUS;
using DuLich.GUI.QuanLyTouris;
using System;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyDonHang
{
    partial class DanhSachDonHang
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
            this.lv_combo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search1 = new DuLich.GUI.QuanLyDonHang.TimKiemDonHang();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_combo
            // 
            this.lv_combo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_combo.FullRowSelect = true;
            this.lv_combo.HideSelection = false;
            this.lv_combo.Location = new System.Drawing.Point(3, 103);
            this.lv_combo.MultiSelect = false;
            this.lv_combo.Name = "lv_combo";
            this.lv_combo.Size = new System.Drawing.Size(794, 494);
            this.lv_combo.TabIndex = 4;
            this.lv_combo.UseCompatibleStateImageBehavior = false;
            this.lv_combo.View = System.Windows.Forms.View.Details;
            this.lv_combo.DoubleClick += new System.EventHandler(this.lv_product_item_doubleclick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đơn hàng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên khách hàng";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ giao hàng";
            this.columnHeader8.Width = 220;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tổng tiền";
            this.columnHeader9.Width = 170;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Trạng thái đơn hàng";
            this.columnHeader10.Width = 150;
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
            this.search1.Size = new System.Drawing.Size(585, 89);
            this.search1.TabIndex = 1;
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
            // DanhSachDonHang
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lv_combo);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.search1);
            this.Name = "DanhSachDonHang";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.BindingSource tourisBindingSource;
        private TimKiemDonHang search1;
        private Button btn_them;
        private Button btn_xoa;
        private BindingSource tourBindingSource;
        private DataGridViewTextBoxColumn catalogIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDetailDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private ListView lv_combo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}
