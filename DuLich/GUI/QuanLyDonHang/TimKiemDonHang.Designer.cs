
namespace DuLich.GUI.QuanLyDonHang
{
    partial class TimKiemDonHang
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tv_searchbox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickketthuc = new System.Windows.Forms.DateTimePicker();
            this.datepickbatdau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pricefrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_priceto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(86, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(273, 22);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // tv_searchbox
            // 
            this.tv_searchbox.AutoSize = true;
            this.tv_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_searchbox.Location = new System.Drawing.Point(3, 6);
            this.tv_searchbox.Name = "tv_searchbox";
            this.tv_searchbox.Size = new System.Drawing.Size(77, 16);
            this.tv_searchbox.TabIndex = 3;
            this.tv_searchbox.Text = "Tên combo";
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
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giá từ";
            // 
            // tb_pricefrom
            // 
            this.tb_pricefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pricefrom.Location = new System.Drawing.Point(77, 64);
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
            this.label4.Location = new System.Drawing.Point(234, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "đến";
            // 
            // tb_priceto
            // 
            this.tb_priceto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_priceto.Location = new System.Drawing.Point(282, 64);
            this.tb_priceto.MaxLength = 18;
            this.tb_priceto.Name = "tb_priceto";
            this.tb_priceto.Size = new System.Drawing.Size(139, 22);
            this.tb_priceto.TabIndex = 14;
            this.tb_priceto.TextChanged += new System.EventHandler(this.tb_priceto_TextChanged);
            // 
            // TimKiemCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_priceto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pricefrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datepickketthuc);
            this.Controls.Add(this.datepickbatdau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_searchbox);
            this.Controls.Add(this.tb_search);
            this.Name = "TimKiemCombo";
            this.Size = new System.Drawing.Size(683, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label tv_searchbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepickketthuc;
        private System.Windows.Forms.DateTimePicker datepickbatdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pricefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_priceto;
    }
}
