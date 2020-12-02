namespace DuLich.GUI.QuanLyTouris
{
    partial class ChiTietGia
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
            this.tv_magia = new System.Windows.Forms.Label();
            this.tv_giatri = new System.Windows.Forms.Label();
            this.tv_ngaybatdau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_magia = new System.Windows.Forms.TextBox();
            this.tb_giatri = new System.Windows.Forms.TextBox();
            this.datepicker_batdau = new System.Windows.Forms.DateTimePicker();
            this.datepicker_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv_magia
            // 
            this.tv_magia.AutoSize = true;
            this.tv_magia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_magia.Location = new System.Drawing.Point(17, 19);
            this.tv_magia.Name = "tv_magia";
            this.tv_magia.Size = new System.Drawing.Size(56, 20);
            this.tv_magia.TabIndex = 0;
            this.tv_magia.Text = "Mã giá";
            // 
            // tv_giatri
            // 
            this.tv_giatri.AutoSize = true;
            this.tv_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_giatri.Location = new System.Drawing.Point(17, 91);
            this.tv_giatri.Name = "tv_giatri";
            this.tv_giatri.Size = new System.Drawing.Size(51, 20);
            this.tv_giatri.TabIndex = 1;
            this.tv_giatri.Text = "Giá trị";
            // 
            // tv_ngaybatdau
            // 
            this.tv_ngaybatdau.AutoSize = true;
            this.tv_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_ngaybatdau.Location = new System.Drawing.Point(17, 172);
            this.tv_ngaybatdau.Name = "tv_ngaybatdau";
            this.tv_ngaybatdau.Size = new System.Drawing.Size(103, 20);
            this.tv_ngaybatdau.TabIndex = 2;
            this.tv_ngaybatdau.Text = "Ngày bắt đầu";
            this.tv_ngaybatdau.Click += new System.EventHandler(this.tv_ngaybatdau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày kết thúc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_magia
            // 
            this.tb_magia.Enabled = false;
            this.tb_magia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_magia.Location = new System.Drawing.Point(191, 16);
            this.tb_magia.Name = "tb_magia";
            this.tb_magia.Size = new System.Drawing.Size(181, 26);
            this.tb_magia.TabIndex = 4;
            // 
            // tb_giatri
            // 
            this.tb_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giatri.Location = new System.Drawing.Point(191, 88);
            this.tb_giatri.Name = "tb_giatri";
            this.tb_giatri.Size = new System.Drawing.Size(181, 26);
            this.tb_giatri.TabIndex = 5;
            this.tb_giatri.TextChanged += new System.EventHandler(this.tb_giatri_TextChanged);
            this.tb_giatri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_giatri_KeyPress_1);
            // 
            // datepicker_batdau
            // 
            this.datepicker_batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_batdau.Location = new System.Drawing.Point(191, 176);
            this.datepicker_batdau.Name = "datepicker_batdau";
            this.datepicker_batdau.Size = new System.Drawing.Size(181, 20);
            this.datepicker_batdau.TabIndex = 6;
            this.datepicker_batdau.ValueChanged += new System.EventHandler(this.datepicker_batdau_ValueChanged);
            // 
            // datepicker_ketthuc
            // 
            this.datepicker_ketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepicker_ketthuc.Location = new System.Drawing.Point(191, 258);
            this.datepicker_ketthuc.Name = "datepicker_ketthuc";
            this.datepicker_ketthuc.Size = new System.Drawing.Size(181, 20);
            this.datepicker_ketthuc.TabIndex = 7;
            this.datepicker_ketthuc.ValueChanged += new System.EventHandler(this.datepicker_ketthuc_ValueChanged);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(408, 19);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 40);
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(408, 91);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(50, 40);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // ChiTietGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 331);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.datepicker_ketthuc);
            this.Controls.Add(this.datepicker_batdau);
            this.Controls.Add(this.tb_giatri);
            this.Controls.Add(this.tb_magia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_ngaybatdau);
            this.Controls.Add(this.tv_giatri);
            this.Controls.Add(this.tv_magia);
            this.Name = "ChiTietGia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tv_magia;
        private System.Windows.Forms.Label tv_giatri;
        private System.Windows.Forms.Label tv_ngaybatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_magia;
        private System.Windows.Forms.TextBox tb_giatri;
        private System.Windows.Forms.DateTimePicker datepicker_batdau;
        private System.Windows.Forms.DateTimePicker datepicker_ketthuc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
    }
}
