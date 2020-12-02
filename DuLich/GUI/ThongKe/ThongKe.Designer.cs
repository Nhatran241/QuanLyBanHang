using DuLich.BUS;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DuLich.GUI.ThongKe
{
    partial class ThongKe : UserControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.listview_solanditour = new System.Windows.Forms.ListView();
            this.ma_nhanvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten_nhanvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tv_tongloinhuan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tv_tongchiphi = new System.Windows.Forms.Label();
            this.tv_tongdanhthu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tv_tongtour = new System.Windows.Forms.Label();
            this.tv_tongkhach = new System.Windows.Forms.Label();
            this.listview_thongketheodoan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.datepicker_den_doanhthutour = new System.Windows.Forms.DateTimePicker();
            this.datepicker_tu_doanhthutour = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tv_tongdoan = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tourisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thống kê theo tour";
            // 
            // listview_solanditour
            // 
            this.listview_solanditour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ma_nhanvien,
            this.ten_nhanvien,
            this.solan});
            this.listview_solanditour.HideSelection = false;
            this.listview_solanditour.Location = new System.Drawing.Point(20, 101);
            this.listview_solanditour.Name = "listview_solanditour";
            this.listview_solanditour.Size = new System.Drawing.Size(458, 302);
            this.listview_solanditour.TabIndex = 8;
            this.listview_solanditour.UseCompatibleStateImageBehavior = false;
            this.listview_solanditour.View = System.Windows.Forms.View.Details;
            // 
            // ma_nhanvien
            // 
            this.ma_nhanvien.Text = "Mã Nhân Viên";
            this.ma_nhanvien.Width = 150;
            // 
            // ten_nhanvien
            // 
            this.ten_nhanvien.Text = "Tên Nhân Viên";
            this.ten_nhanvien.Width = 150;
            // 
            // solan
            // 
            this.solan.Text = "Số Lần Đi Tour";
            this.solan.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thống Kê Số Lần Đi Tour Của Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thống Kê";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(552, 156);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đến ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tv_tongloinhuan);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tv_tongchiphi);
            this.panel2.Controls.Add(this.tv_tongdanhthu);
            this.panel2.Location = new System.Drawing.Point(19, 801);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 43);
            this.panel2.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tổng lợi nhuận :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tổng danh thu :";
            // 
            // tv_tongloinhuan
            // 
            this.tv_tongloinhuan.AutoSize = true;
            this.tv_tongloinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongloinhuan.Location = new System.Drawing.Point(618, 12);
            this.tv_tongloinhuan.Name = "tv_tongloinhuan";
            this.tv_tongloinhuan.Size = new System.Drawing.Size(19, 20);
            this.tv_tongloinhuan.TabIndex = 35;
            this.tv_tongloinhuan.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tổng chi phí :";
            // 
            // tv_tongchiphi
            // 
            this.tv_tongchiphi.AutoSize = true;
            this.tv_tongchiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongchiphi.Location = new System.Drawing.Point(376, 12);
            this.tv_tongchiphi.Name = "tv_tongchiphi";
            this.tv_tongchiphi.Size = new System.Drawing.Size(19, 20);
            this.tv_tongchiphi.TabIndex = 34;
            this.tv_tongchiphi.Text = "0";
            // 
            // tv_tongdanhthu
            // 
            this.tv_tongdanhthu.AutoSize = true;
            this.tv_tongdanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongdanhthu.Location = new System.Drawing.Point(141, 12);
            this.tv_tongdanhthu.Name = "tv_tongdanhthu";
            this.tv_tongdanhthu.Size = new System.Drawing.Size(19, 20);
            this.tv_tongdanhthu.TabIndex = 33;
            this.tv_tongdanhthu.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tv_tongdoan);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tv_tongtour);
            this.panel1.Controls.Add(this.tv_tongkhach);
            this.panel1.Location = new System.Drawing.Point(19, 850);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 42);
            this.panel1.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tổng số khách tham quan :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tổng số tour :";
            // 
            // tv_tongtour
            // 
            this.tv_tongtour.AutoSize = true;
            this.tv_tongtour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongtour.Location = new System.Drawing.Point(141, 10);
            this.tv_tongtour.Name = "tv_tongtour";
            this.tv_tongtour.Size = new System.Drawing.Size(19, 20);
            this.tv_tongtour.TabIndex = 31;
            this.tv_tongtour.Text = "0";
            // 
            // tv_tongkhach
            // 
            this.tv_tongkhach.AutoSize = true;
            this.tv_tongkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongkhach.Location = new System.Drawing.Point(643, 10);
            this.tv_tongkhach.Name = "tv_tongkhach";
            this.tv_tongkhach.Size = new System.Drawing.Size(19, 20);
            this.tv_tongkhach.TabIndex = 32;
            this.tv_tongkhach.Text = "0";
            // 
            // listview_thongketheodoan
            // 
            this.listview_thongketheodoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listview_thongketheodoan.FullRowSelect = true;
            this.listview_thongketheodoan.HideSelection = false;
            this.listview_thongketheodoan.Location = new System.Drawing.Point(19, 506);
            this.listview_thongketheodoan.Name = "listview_thongketheodoan";
            this.listview_thongketheodoan.Size = new System.Drawing.Size(708, 289);
            this.listview_thongketheodoan.TabIndex = 43;
            this.listview_thongketheodoan.UseCompatibleStateImageBehavior = false;
            this.listview_thongketheodoan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Tour";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doanh thu";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chi Phí";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lợi Nhuận";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số khách";
            this.columnHeader5.Width = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(488, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "Đến";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(222, 474);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Từ";
            // 
            // datepicker_den_doanhthutour
            // 
            this.datepicker_den_doanhthutour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_den_doanhthutour.Location = new System.Drawing.Point(526, 470);
            this.datepicker_den_doanhthutour.Name = "datepicker_den_doanhthutour";
            this.datepicker_den_doanhthutour.Size = new System.Drawing.Size(201, 20);
            this.datepicker_den_doanhthutour.TabIndex = 40;
            this.datepicker_den_doanhthutour.ValueChanged += new System.EventHandler(this.datepicker_den_doanhthutour_ValueChanged_1);
            // 
            // datepicker_tu_doanhthutour
            // 
            this.datepicker_tu_doanhthutour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_tu_doanhthutour.Location = new System.Drawing.Point(263, 469);
            this.datepicker_tu_doanhthutour.Name = "datepicker_tu_doanhthutour";
            this.datepicker_tu_doanhthutour.Size = new System.Drawing.Size(205, 20);
            this.datepicker_tu_doanhthutour.TabIndex = 39;
            this.datepicker_tu_doanhthutour.ValueChanged += new System.EventHandler(this.datepicker_tu_doanhthutour_ValueChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(250, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Tổng số đoàn :";
            // 
            // tv_tongdoan
            // 
            this.tv_tongdoan.AutoSize = true;
            this.tv_tongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongdoan.Location = new System.Drawing.Point(376, 11);
            this.tv_tongdoan.Name = "tv_tongdoan";
            this.tv_tongdoan.Size = new System.Drawing.Size(19, 20);
            this.tv_tongdoan.TabIndex = 34;
            this.tv_tongdoan.Text = "0";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng số đoàn";
            this.columnHeader6.Width = 140;
            // 
            // tourisBindingSource1
            // 
            this.tourisBindingSource1.DataSource = typeof(DuLich.BUS.Tour);
            // 
            // giaBindingSource
            // 
            this.giaBindingSource.DataSource = typeof(DuLich.BUS.Gia);
            // 
            // tourisBindingSource
            // 
            this.tourisBindingSource.DataSource = typeof(DuLich.BUS.Tour);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listview_thongketheodoan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.datepicker_den_doanhthutour);
            this.Controls.Add(this.datepicker_tu_doanhthutour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listview_solanditour);
            this.Controls.Add(this.label3);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(767, 911);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private BindingSource tourisBindingSource;
        private BindingSource giaBindingSource;
        private Label label3;
        private Series series1; 
        private BindingSource tourisBindingSource1;
        private ListView listview_solanditour;
        private ColumnHeader ma_nhanvien;
        private ColumnHeader ten_nhanvien;
        private ColumnHeader solan;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label tv_tongloinhuan;
        private Label label11;
        private Label tv_tongchiphi;
        private Label tv_tongdanhthu;
        private Panel panel1;
        private Label label16;
        private Label tv_tongdoan;
        private Label label12;
        private Label label13;
        private Label tv_tongtour;
        private Label tv_tongkhach;
        private ListView listview_thongketheodoan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label14;
        private Label label15;
        private DateTimePicker datepicker_den_doanhthutour;
        private DateTimePicker datepicker_tu_doanhthutour;
    }
}
