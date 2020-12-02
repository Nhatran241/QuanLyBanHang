using DuLich.BUS;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DuLich.View.QuanLyTouris
{
    partial class ThongKeTheoTour : UserControl
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datepicker_den_doanhthutour = new System.Windows.Forms.DateTimePicker();
            this.datepicker_tu_doanhthutour = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.listview_thongketheodoan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tv_tongdoan = new System.Windows.Forms.Label();
            this.tv_tongkhach = new System.Windows.Forms.Label();
            this.tv_tongdanhthu = new System.Windows.Forms.Label();
            this.tv_tongchiphi = new System.Windows.Forms.Label();
            this.tv_tongloinhuan = new System.Windows.Forms.Label();
            this.tourisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Từ";
            // 
            // datepicker_den_doanhthutour
            // 
            this.datepicker_den_doanhthutour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_den_doanhthutour.Location = new System.Drawing.Point(520, 10);
            this.datepicker_den_doanhthutour.Name = "datepicker_den_doanhthutour";
            this.datepicker_den_doanhthutour.Size = new System.Drawing.Size(201, 20);
            this.datepicker_den_doanhthutour.TabIndex = 22;
            this.datepicker_den_doanhthutour.ValueChanged += new System.EventHandler(this.datepicker_den_doanhthutour_ValueChanged);
            // 
            // datepicker_tu_doanhthutour
            // 
            this.datepicker_tu_doanhthutour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_tu_doanhthutour.Location = new System.Drawing.Point(229, 10);
            this.datepicker_tu_doanhthutour.Name = "datepicker_tu_doanhthutour";
            this.datepicker_tu_doanhthutour.Size = new System.Drawing.Size(205, 20);
            this.datepicker_tu_doanhthutour.TabIndex = 21;
            this.datepicker_tu_doanhthutour.ValueChanged += new System.EventHandler(this.datepicker_tu_doanhthutour_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Thống kê theo đoàn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listview_thongketheodoan
            // 
            this.listview_thongketheodoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listview_thongketheodoan.FullRowSelect = true;
            this.listview_thongketheodoan.HideSelection = false;
            this.listview_thongketheodoan.Location = new System.Drawing.Point(13, 46);
            this.listview_thongketheodoan.Name = "listview_thongketheodoan";
            this.listview_thongketheodoan.Size = new System.Drawing.Size(708, 289);
            this.listview_thongketheodoan.TabIndex = 25;
            this.listview_thongketheodoan.UseCompatibleStateImageBehavior = false;
            this.listview_thongketheodoan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Đoàn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Danh thu";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chi Phí";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lợi Nhuận";
            this.columnHeader4.Width = 175;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tổng số đoàn triển khai tour này : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tổng số khách tham quan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tổng danh thu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tổng chi phí :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tổng lợi nhuận :";
            // 
            // tv_tongdoan
            // 
            this.tv_tongdoan.AutoSize = true;
            this.tv_tongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongdoan.Location = new System.Drawing.Point(280, 10);
            this.tv_tongdoan.Name = "tv_tongdoan";
            this.tv_tongdoan.Size = new System.Drawing.Size(19, 20);
            this.tv_tongdoan.TabIndex = 31;
            this.tv_tongdoan.Text = "0";
            // 
            // tv_tongkhach
            // 
            this.tv_tongkhach.AutoSize = true;
            this.tv_tongkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongkhach.Location = new System.Drawing.Point(600, 10);
            this.tv_tongkhach.Name = "tv_tongkhach";
            this.tv_tongkhach.Size = new System.Drawing.Size(19, 20);
            this.tv_tongkhach.TabIndex = 32;
            this.tv_tongkhach.Text = "0";
            // 
            // tv_tongdanhthu
            // 
            this.tv_tongdanhthu.AutoSize = true;
            this.tv_tongdanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongdanhthu.Location = new System.Drawing.Point(151, 12);
            this.tv_tongdanhthu.Name = "tv_tongdanhthu";
            this.tv_tongdanhthu.Size = new System.Drawing.Size(19, 20);
            this.tv_tongdanhthu.TabIndex = 33;
            this.tv_tongdanhthu.Text = "0";
            // 
            // tv_tongchiphi
            // 
            this.tv_tongchiphi.AutoSize = true;
            this.tv_tongchiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongchiphi.Location = new System.Drawing.Point(358, 12);
            this.tv_tongchiphi.Name = "tv_tongchiphi";
            this.tv_tongchiphi.Size = new System.Drawing.Size(19, 20);
            this.tv_tongchiphi.TabIndex = 34;
            this.tv_tongchiphi.Text = "0";
            // 
            // tv_tongloinhuan
            // 
            this.tv_tongloinhuan.AutoSize = true;
            this.tv_tongloinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongloinhuan.Location = new System.Drawing.Point(600, 12);
            this.tv_tongloinhuan.Name = "tv_tongloinhuan";
            this.tv_tongloinhuan.Size = new System.Drawing.Size(19, 20);
            this.tv_tongloinhuan.TabIndex = 35;
            this.tv_tongloinhuan.Text = "0";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tv_tongdoan);
            this.panel1.Controls.Add(this.tv_tongkhach);
            this.panel1.Location = new System.Drawing.Point(13, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 42);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tv_tongloinhuan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tv_tongchiphi);
            this.panel2.Controls.Add(this.tv_tongdanhthu);
            this.panel2.Location = new System.Drawing.Point(13, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 43);
            this.panel2.TabIndex = 37;
            // 
            // ThongKeTheoTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listview_thongketheodoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datepicker_den_doanhthutour);
            this.Controls.Add(this.datepicker_tu_doanhthutour);
            this.Controls.Add(this.label4);
            this.Name = "ThongKeTheoTour";
            this.Size = new System.Drawing.Size(767, 472);
            this.Load += new System.EventHandler(this.ThongKeTheoTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourisBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private BindingSource tourisBindingSource;
        private BindingSource giaBindingSource;
        private Series series1; 
        private BindingSource tourisBindingSource1;
        private Label label6;
        private Label label7;
        private DateTimePicker datepicker_den_doanhthutour;
        private DateTimePicker datepicker_tu_doanhthutour;
        private Label label4;
        private ListView listview_thongketheodoan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label tv_tongdoan;
        private Label tv_tongkhach;
        private Label tv_tongdanhthu;
        private Label tv_tongchiphi;
        private Label tv_tongloinhuan;
        private Panel panel1;
        private Panel panel2;
    }
}
