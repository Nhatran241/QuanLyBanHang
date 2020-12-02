
namespace DuLich.GUI.QuanLyDiaDiem
{
    partial class ChiTietDiaDiem
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.tb_tendiadiem = new System.Windows.Forms.TextBox();
            this.tb_madiadiem = new System.Windows.Forms.TextBox();
            this.tv_tendiadiem = new System.Windows.Forms.Label();
            this.tv_madiadiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(409, 97);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(50, 40);
            this.btn_huy.TabIndex = 15;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(409, 25);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(50, 40);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // tb_tendiadiem
            // 
            this.tb_tendiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tendiadiem.Location = new System.Drawing.Point(134, 100);
            this.tb_tendiadiem.Name = "tb_tendiadiem";
            this.tb_tendiadiem.Size = new System.Drawing.Size(258, 26);
            this.tb_tendiadiem.TabIndex = 13;
            this.tb_tendiadiem.TextChanged += new System.EventHandler(this.tb_TenDiaDiem_TextChanged);
            // 
            // tb_madiadiem
            // 
            this.tb_madiadiem.Enabled = false;
            this.tb_madiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_madiadiem.Location = new System.Drawing.Point(134, 28);
            this.tb_madiadiem.Name = "tb_madiadiem";
            this.tb_madiadiem.ReadOnly = true;
            this.tb_madiadiem.Size = new System.Drawing.Size(258, 26);
            this.tb_madiadiem.TabIndex = 12;
            // 
            // tv_tendiadiem
            // 
            this.tv_tendiadiem.AutoSize = true;
            this.tv_tendiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_tendiadiem.Location = new System.Drawing.Point(12, 103);
            this.tv_tendiadiem.Name = "tv_tendiadiem";
            this.tv_tendiadiem.Size = new System.Drawing.Size(105, 20);
            this.tv_tendiadiem.TabIndex = 11;
            this.tv_tendiadiem.Text = "Tên Địa Điểm";
            // 
            // tv_madiadiem
            // 
            this.tv_madiadiem.AutoSize = true;
            this.tv_madiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_madiadiem.Location = new System.Drawing.Point(16, 31);
            this.tv_madiadiem.Name = "tv_madiadiem";
            this.tv_madiadiem.Size = new System.Drawing.Size(100, 20);
            this.tv_madiadiem.TabIndex = 10;
            this.tv_madiadiem.Text = "Mã Địa Điểm";
            // 
            // ChiTietDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 169);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tb_tendiadiem);
            this.Controls.Add(this.tb_madiadiem);
            this.Controls.Add(this.tv_tendiadiem);
            this.Controls.Add(this.tv_madiadiem);
            this.Name = "ChiTietDiaDiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox tb_tendiadiem;
        private System.Windows.Forms.TextBox tb_madiadiem;
        private System.Windows.Forms.Label tv_tendiadiem;
        private System.Windows.Forms.Label tv_madiadiem;
    }
}
