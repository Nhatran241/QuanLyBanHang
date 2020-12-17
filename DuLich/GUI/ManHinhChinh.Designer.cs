using System.Windows.Forms;

namespace DuLich
{
    partial class ManHinhChinh
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
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main_content = new System.Windows.Forms.Panel();
            this.btn_quanlytour = new System.Windows.Forms.Button();
            this.btn_quanlydiadiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_quanlynhanvien = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_main_content
            // 
            this.panel_main_content.AutoScroll = true;
            this.panel_main_content.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main_content.Location = new System.Drawing.Point(196, 37);
            this.panel_main_content.Name = "panel_main_content";
            this.panel_main_content.Size = new System.Drawing.Size(800, 600);
            this.panel_main_content.TabIndex = 3;
            // 
            // btn_quanlytour
            // 
            this.btn_quanlytour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanlytour.Location = new System.Drawing.Point(11, 37);
            this.btn_quanlytour.Name = "btn_quanlytour";
            this.btn_quanlytour.Size = new System.Drawing.Size(165, 32);
            this.btn_quanlytour.TabIndex = 5;
            this.btn_quanlytour.Text = "Quản lý thiết bị";
            this.btn_quanlytour.UseVisualStyleBackColor = true;
            this.btn_quanlytour.Click += new System.EventHandler(this.Btn_DanhSachThietBiClick);
            // 
            // btn_quanlydiadiem
            // 
            this.btn_quanlydiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanlydiadiem.Location = new System.Drawing.Point(11, 173);
            this.btn_quanlydiadiem.Name = "btn_quanlydiadiem";
            this.btn_quanlydiadiem.Size = new System.Drawing.Size(165, 32);
            this.btn_quanlydiadiem.TabIndex = 7;
            this.btn_quanlydiadiem.Text = "Quản lý kho hàng";
            this.btn_quanlydiadiem.UseVisualStyleBackColor = true;
            this.btn_quanlydiadiem.Click += new System.EventHandler(this.btn_quanlykhoclick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quản lý combo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_DanhSachComboClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quản lý nhân viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_quanlynhanvien
            // 
            this.btn_quanlynhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanlynhanvien.Location = new System.Drawing.Point(11, 296);
            this.btn_quanlynhanvien.Name = "btn_quanlynhanvien";
            this.btn_quanlynhanvien.Size = new System.Drawing.Size(165, 32);
            this.btn_quanlynhanvien.TabIndex = 11;
            this.btn_quanlynhanvien.Text = "Quản lý đơn hàng";
            this.btn_quanlynhanvien.UseVisualStyleBackColor = true;
            this.btn_quanlynhanvien.Click += new System.EventHandler(this.btn_quanlydonhang_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.Location = new System.Drawing.Point(12, 355);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(165, 33);
            this.btn_thongke.TabIndex = 12;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.btn_quanlynhanvien);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_quanlydiadiem);
            this.Controls.Add(this.btn_quanlytour);
            this.Controls.Add(this.panel_main_content);
            this.Name = "ManHinhChinh";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Panel panel_main_content;
        private Button btn_quanlytour;
        private Button btn_quanlydiadiem;
        private Button button1;
        private Button button2;
        private Button btn_quanlynhanvien;
        private Button btn_thongke;
    }
}

