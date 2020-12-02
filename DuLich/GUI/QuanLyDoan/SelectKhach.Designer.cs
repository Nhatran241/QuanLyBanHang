using DuLich.BUS;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyDoan
{
    partial class SelectKhach : UserControl
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
            this.tv_khachtrongdoan = new System.Windows.Forms.Label();
            this.tv_tatcakhach = new System.Windows.Forms.Label();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.listbox_tatcakhach = new System.Windows.Forms.ListView();
            this.tv_makhach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tv_tenkhach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tv_sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listbox_khachtrongdoan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_khachtrongdoan
            // 
            this.tv_khachtrongdoan.AutoSize = true;
            this.tv_khachtrongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_khachtrongdoan.Location = new System.Drawing.Point(535, 15);
            this.tv_khachtrongdoan.Name = "tv_khachtrongdoan";
            this.tv_khachtrongdoan.Size = new System.Drawing.Size(119, 16);
            this.tv_khachtrongdoan.TabIndex = 4;
            this.tv_khachtrongdoan.Text = "Khách Trong Đoàn";
            this.tv_khachtrongdoan.Click += new System.EventHandler(this.tv_khachtrongdoan_Click);
            // 
            // tv_tatcakhach
            // 
            this.tv_tatcakhach.AutoSize = true;
            this.tv_tatcakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tatcakhach.Location = new System.Drawing.Point(126, 15);
            this.tv_tatcakhach.Name = "tv_tatcakhach";
            this.tv_tatcakhach.Size = new System.Drawing.Size(88, 16);
            this.tv_tatcakhach.TabIndex = 5;
            this.tv_tatcakhach.Text = "Tất Cả Khách";
            this.tv_tatcakhach.Click += new System.EventHandler(this.tv_tatcakhach_Click);
            // 
            // btn_up
            // 
            this.btn_up.Image = global::DuLich.Properties.Resources.up_arrow;
            this.btn_up.Location = new System.Drawing.Point(356, 337);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(50, 50);
            this.btn_up.TabIndex = 6;
            this.btn_up.Visible = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DuLich.Properties.Resources.download;
            this.btn_luu.Location = new System.Drawing.Point(356, 180);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 50);
            this.btn_luu.TabIndex = 0;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DuLich.Properties.Resources.plus;
            this.btn_them.Location = new System.Drawing.Point(356, 45);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(50, 50);
            this.btn_them.TabIndex = 3;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::DuLich.Properties.Resources.remove;
            this.btn_xoa.Location = new System.Drawing.Point(356, 113);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(50, 50);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DuLich.Properties.Resources.down_arrow;
            this.btn_down.Location = new System.Drawing.Point(356, 260);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(50, 50);
            this.btn_down.TabIndex = 7;
            this.btn_down.Visible = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // listbox_tatcakhach
            // 
            this.listbox_tatcakhach.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listbox_tatcakhach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tv_makhach,
            this.tv_tenkhach,
            this.tv_sdt});
            this.listbox_tatcakhach.FullRowSelect = true;
            this.listbox_tatcakhach.HideSelection = false;
            this.listbox_tatcakhach.HoverSelection = true;
            this.listbox_tatcakhach.Location = new System.Drawing.Point(0, 45);
            this.listbox_tatcakhach.MultiSelect = false;
            this.listbox_tatcakhach.Name = "listbox_tatcakhach";
            this.listbox_tatcakhach.Size = new System.Drawing.Size(342, 342);
            this.listbox_tatcakhach.TabIndex = 8;
            this.listbox_tatcakhach.UseCompatibleStateImageBehavior = false;
            this.listbox_tatcakhach.View = System.Windows.Forms.View.Details;
            // 
            // tv_makhach
            // 
            this.tv_makhach.Text = "Mã Khách";
            this.tv_makhach.Width = 114;
            // 
            // tv_tenkhach
            // 
            this.tv_tenkhach.Text = "Tên Khách";
            this.tv_tenkhach.Width = 114;
            // 
            // tv_sdt
            // 
            this.tv_sdt.Text = "Số Điện Thoại";
            this.tv_sdt.Width = 110;
            // 
            // listbox_khachtrongdoan
            // 
            this.listbox_khachtrongdoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listbox_khachtrongdoan.FullRowSelect = true;
            this.listbox_khachtrongdoan.HideSelection = false;
            this.listbox_khachtrongdoan.Location = new System.Drawing.Point(421, 45);
            this.listbox_khachtrongdoan.MultiSelect = false;
            this.listbox_khachtrongdoan.Name = "listbox_khachtrongdoan";
            this.listbox_khachtrongdoan.Size = new System.Drawing.Size(343, 342);
            this.listbox_khachtrongdoan.TabIndex = 9;
            this.listbox_khachtrongdoan.UseCompatibleStateImageBehavior = false;
            this.listbox_khachtrongdoan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Khách";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khách";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Điện Thoại";
            this.columnHeader3.Width = 110;
            // 
            // khachBindingSource
            // 
            this.khachBindingSource.DataSource = typeof(DuLich.BUS.Khach);
            // 
            // SelectKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listbox_khachtrongdoan);
            this.Controls.Add(this.listbox_tatcakhach);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tv_tatcakhach);
            this.Controls.Add(this.tv_khachtrongdoan);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Name = "SelectKhach";
            this.Size = new System.Drawing.Size(767, 404);
            this.Load += new System.EventHandler(this.SelectKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_xoa;
        private Button btn_them;
        private Label tv_khachtrongdoan;
        private Label tv_tatcakhach;
        private Button btn_luu;
        private Button btn_up;
        private Button btn_down;
        private ListView listbox_tatcakhach;
        private ColumnHeader tv_makhach;
        private ColumnHeader tv_tenkhach;
        private ColumnHeader tv_sdt;
        private ListView listbox_khachtrongdoan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private BindingSource khachBindingSource;
    }
}
