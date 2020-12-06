
namespace DuLich.GUI.QuanLyKhoHang
{
    partial class TimKiemKhoHang
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
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.tv_combo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickketthuc = new System.Windows.Forms.DateTimePicker();
            this.datepickbatdau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pricefrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_priceto = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(77, 6);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(126, 24);
            this.cb_search.TabIndex = 0;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged);
            // 
            // tv_combo
            // 
            this.tv_combo.AutoSize = true;
            this.tv_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_combo.Location = new System.Drawing.Point(3, 9);
            this.tv_combo.Name = "tv_combo";
            this.tv_combo.Size = new System.Drawing.Size(69, 16);
            this.tv_combo.TabIndex = 2;
            this.tv_combo.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời gian tạo từ";
            // 
            // datepickketthuc
            // 
            this.datepickketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepickketthuc.Location = new System.Drawing.Point(382, 38);
            this.datepickketthuc.Name = "datepickketthuc";
            this.datepickketthuc.Size = new System.Drawing.Size(200, 20);
            this.datepickketthuc.TabIndex = 9;
            this.datepickketthuc.ValueChanged += new System.EventHandler(this.datepickketthuc_ValueChanged);
            // 
            // datepickbatdau
            // 
            this.datepickbatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datepickbatdau.Location = new System.Drawing.Point(108, 38);
            this.datepickbatdau.Name = "datepickbatdau";
            this.datepickbatdau.Size = new System.Drawing.Size(221, 20);
            this.datepickbatdau.TabIndex = 8;
            this.datepickbatdau.ValueChanged += new System.EventHandler(this.datepickbatdau_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lượng từ";
            // 
            // tb_pricefrom
            // 
            this.tb_pricefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pricefrom.Location = new System.Drawing.Point(348, 64);
            this.tb_pricefrom.MaxLength = 18;
            this.tb_pricefrom.Name = "tb_pricefrom";
            this.tb_pricefrom.Size = new System.Drawing.Size(139, 22);
            this.tb_pricefrom.TabIndex = 12;
            this.tb_pricefrom.TextChanged += new System.EventHandler(this.tb_pricefrom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "đến";
            // 
            // tb_priceto
            // 
            this.tb_priceto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_priceto.Location = new System.Drawing.Point(541, 61);
            this.tb_priceto.MaxLength = 18;
            this.tb_priceto.Name = "tb_priceto";
            this.tb_priceto.Size = new System.Drawing.Size(139, 22);
            this.tb_priceto.TabIndex = 14;
            this.tb_priceto.TextChanged += new System.EventHandler(this.tb_priceto_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Phiếu nhập";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Phiếu xuất";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // TimKiemKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_priceto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pricefrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datepickketthuc);
            this.Controls.Add(this.datepickbatdau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_combo);
            this.Controls.Add(this.cb_search);
            this.Name = "TimKiemKhoHang";
            this.Size = new System.Drawing.Size(683, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Label tv_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepickketthuc;
        private System.Windows.Forms.DateTimePicker datepickbatdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pricefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_priceto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
