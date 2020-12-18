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
            this.mathietbi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenthietbi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tonkho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tonkhotu = new System.Windows.Forms.DateTimePicker();
            this.tonkhoden = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tv_tongtien = new System.Windows.Forms.Label();
            this.tv_tongdonhang = new System.Windows.Forms.Label();
            this.listview_thongkedonhang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.datepicker_den_doanhthutour = new System.Windows.Forms.DateTimePicker();
            this.datepicker_tu_doanhthutour = new System.Windows.Forms.DateTimePicker();
            this.tourisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thống kê đơn hàng";
            // 
            // listview_solanditour
            // 
            this.listview_solanditour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mathietbi,
            this.tenthietbi,
            this.tonkho,
            this.ngay});
            this.listview_solanditour.HideSelection = false;
            this.listview_solanditour.Location = new System.Drawing.Point(20, 101);
            this.listview_solanditour.Name = "listview_solanditour";
            this.listview_solanditour.Size = new System.Drawing.Size(744, 302);
            this.listview_solanditour.TabIndex = 8;
            this.listview_solanditour.UseCompatibleStateImageBehavior = false;
            this.listview_solanditour.View = System.Windows.Forms.View.Details;
            // 
            // mathietbi
            // 
            this.mathietbi.Text = "Mã thiết bị";
            this.mathietbi.Width = 150;
            // 
            // tenthietbi
            // 
            this.tenthietbi.Text = "Tên thiết bị";
            this.tenthietbi.Width = 150;
            // 
            // tonkho
            // 
            this.tonkho.Text = "Tồn kho";
            this.tonkho.Width = 150;
            // 
            // ngay
            // 
            this.ngay.Text = "Ngày";
            this.ngay.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thống kê tồn kho theo thời gian";
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
            // tonkhotu
            // 
            this.tonkhotu.Location = new System.Drawing.Point(298, 75);
            this.tonkhotu.Name = "tonkhotu";
            this.tonkhotu.Size = new System.Drawing.Size(200, 20);
            this.tonkhotu.TabIndex = 11;
            this.tonkhotu.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tonkhoden
            // 
            this.tonkhoden.Location = new System.Drawing.Point(563, 75);
            this.tonkhoden.Name = "tonkhoden";
            this.tonkhoden.Size = new System.Drawing.Size(200, 20);
            this.tonkhoden.TabIndex = 12;
            this.tonkhoden.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đến ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tv_tongtien);
            this.panel2.Controls.Add(this.tv_tongdonhang);
            this.panel2.Location = new System.Drawing.Point(19, 801);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 43);
            this.panel2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tổng đơn hàng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tổng tiền :";
            // 
            // tv_tongtien
            // 
            this.tv_tongtien.AutoSize = true;
            this.tv_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongtien.Location = new System.Drawing.Point(460, 12);
            this.tv_tongtien.Name = "tv_tongtien";
            this.tv_tongtien.Size = new System.Drawing.Size(19, 20);
            this.tv_tongtien.TabIndex = 34;
            this.tv_tongtien.Text = "0";
            // 
            // tv_tongdonhang
            // 
            this.tv_tongdonhang.AutoSize = true;
            this.tv_tongdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tongdonhang.Location = new System.Drawing.Point(141, 12);
            this.tv_tongdonhang.Name = "tv_tongdonhang";
            this.tv_tongdonhang.Size = new System.Drawing.Size(19, 20);
            this.tv_tongdonhang.TabIndex = 33;
            this.tv_tongdonhang.Text = "0";
            // 
            // listview_thongkedonhang
            // 
            this.listview_thongkedonhang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview_thongkedonhang.FullRowSelect = true;
            this.listview_thongkedonhang.HideSelection = false;
            this.listview_thongkedonhang.Location = new System.Drawing.Point(19, 506);
            this.listview_thongkedonhang.Name = "listview_thongkedonhang";
            this.listview_thongkedonhang.Size = new System.Drawing.Size(708, 289);
            this.listview_thongkedonhang.TabIndex = 43;
            this.listview_thongkedonhang.UseCompatibleStateImageBehavior = false;
            this.listview_thongkedonhang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đơn hàng";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng sản phẩm";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng tiền";
            this.columnHeader3.Width = 200;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Thiết bị";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listview_thongkedonhang);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.datepicker_den_doanhthutour);
            this.Controls.Add(this.datepicker_tu_doanhthutour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tonkhoden);
            this.Controls.Add(this.tonkhotu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listview_solanditour);
            this.Controls.Add(this.label3);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(767, 911);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private ColumnHeader tenthietbi;
        private ColumnHeader tonkho;
        private Label label1;
        private Label label2;
        private DateTimePicker tonkhotu;
        private DateTimePicker tonkhoden;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label7;
        private Label label11;
        private Label tv_tongtien;
        private Label tv_tongdonhang;
        private ListView listview_thongkedonhang;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label14;
        private Label label15;
        private DateTimePicker datepicker_den_doanhthutour;
        private DateTimePicker datepicker_tu_doanhthutour;
        private ColumnHeader mathietbi;
        private ColumnHeader ngay;
        private ComboBox comboBox1;
        private Label label8;
    }
}
