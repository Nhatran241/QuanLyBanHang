using System.Windows.Forms;

namespace DuLich.GUI.QuanLyTouris
{
    partial class DanhSachChonDiaDiem : UserControl
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
            this.listbox_tatcadiadiem = new System.Windows.Forms.ListBox();
            this.listbox_tatcakhach = new System.Windows.Forms.ListBox();
            this.tv_khachtrongdoan = new System.Windows.Forms.Label();
            this.tv_tatcakhach = new System.Windows.Forms.Label();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_tatcadiadiem
            // 
            this.listbox_tatcadiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_tatcadiadiem.FormattingEnabled = true;
            this.listbox_tatcadiadiem.ItemHeight = 16;
            this.listbox_tatcadiadiem.Location = new System.Drawing.Point(8, 45);
            this.listbox_tatcadiadiem.Name = "listbox_tatcadiadiem";
            this.listbox_tatcadiadiem.Size = new System.Drawing.Size(300, 340);
            this.listbox_tatcadiadiem.TabIndex = 0;
            this.listbox_tatcadiadiem.SelectedIndexChanged += new System.EventHandler(this.listbox_chondiadiem_SelectedIndexChanged);
            // 
            // listbox_tatcakhach
            // 
            this.listbox_tatcakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_tatcakhach.FormattingEnabled = true;
            this.listbox_tatcakhach.ItemHeight = 16;
            this.listbox_tatcakhach.Location = new System.Drawing.Point(455, 45);
            this.listbox_tatcakhach.Name = "listbox_tatcakhach";
            this.listbox_tatcakhach.Size = new System.Drawing.Size(300, 340);
            this.listbox_tatcakhach.TabIndex = 1;
            // 
            // tv_khachtrongdoan
            // 
            this.tv_khachtrongdoan.AutoSize = true;
            this.tv_khachtrongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_khachtrongdoan.Location = new System.Drawing.Point(559, 13);
            this.tv_khachtrongdoan.Name = "tv_khachtrongdoan";
            this.tv_khachtrongdoan.Size = new System.Drawing.Size(120, 16);
            this.tv_khachtrongdoan.TabIndex = 4;
            this.tv_khachtrongdoan.Text = "Địa Điểm Của Tour";
            // 
            // tv_tatcakhach
            // 
            this.tv_tatcakhach.AutoSize = true;
            this.tv_tatcakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tatcakhach.Location = new System.Drawing.Point(77, 13);
            this.tv_tatcakhach.Name = "tv_tatcakhach";
            this.tv_tatcakhach.Size = new System.Drawing.Size(105, 16);
            this.tv_tatcakhach.TabIndex = 5;
            this.tv_tatcakhach.Text = "Tất Cả Địa Điểm";
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up.Image = global::DuLich.Properties.Resources.up_arrow;
            this.btn_up.Location = new System.Drawing.Point(358, 185);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(50, 50);
            this.btn_up.TabIndex = 6;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::DuLich.Properties.Resources.download;
            this.btn_luu.Location = new System.Drawing.Point(358, 335);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 50);
            this.btn_luu.TabIndex = 0;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::DuLich.Properties.Resources.plus;
            this.btn_them.Location = new System.Drawing.Point(358, 43);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(50, 50);
            this.btn_them.TabIndex = 3;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::DuLich.Properties.Resources.remove;
            this.btn_xoa.Location = new System.Drawing.Point(358, 111);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(50, 50);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_down.Image = global::DuLich.Properties.Resources.down_arrow;
            this.btn_down.Location = new System.Drawing.Point(358, 258);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(50, 50);
            this.btn_down.TabIndex = 7;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // DanhSachChonDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tv_tatcakhach);
            this.Controls.Add(this.tv_khachtrongdoan);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.listbox_tatcakhach);
            this.Controls.Add(this.listbox_tatcadiadiem);
            this.Name = "DanhSachChonDiaDiem";
            this.Size = new System.Drawing.Size(767, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listbox_tatcadiadiem;
        private ListBox listbox_tatcakhach;
        private Button btn_xoa;
        private Button btn_them;
        private Label tv_khachtrongdoan;
        private Label tv_tatcakhach;
        private Button btn_luu;
        private Button btn_up;
        private Button btn_down;
    }
}
