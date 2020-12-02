namespace DuLich.GUI.QuanLyTouris
{
    partial class SearchTour
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tv_combo = new System.Windows.Forms.Label();
            this.tv_searchbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(72, 18);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(126, 24);
            this.cb_search.TabIndex = 0;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(341, 18);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(273, 22);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // tv_combo
            // 
            this.tv_combo.AutoSize = true;
            this.tv_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_combo.Location = new System.Drawing.Point(6, 21);
            this.tv_combo.Name = "tv_combo";
            this.tv_combo.Size = new System.Drawing.Size(45, 16);
            this.tv_combo.TabIndex = 2;
            this.tv_combo.Text = "label1";
            // 
            // tv_searchbox
            // 
            this.tv_searchbox.AutoSize = true;
            this.tv_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_searchbox.Location = new System.Drawing.Point(253, 21);
            this.tv_searchbox.Name = "tv_searchbox";
            this.tv_searchbox.Size = new System.Drawing.Size(45, 16);
            this.tv_searchbox.TabIndex = 3;
            this.tv_searchbox.Text = "label2";
            // 
            // SearchTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv_searchbox);
            this.Controls.Add(this.tv_combo);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cb_search);
            this.Name = "SearchTour";
            this.Size = new System.Drawing.Size(629, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label tv_combo;
        private System.Windows.Forms.Label tv_searchbox;
    }
}
