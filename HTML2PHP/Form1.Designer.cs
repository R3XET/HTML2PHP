namespace HTML2PHP
{
    partial class html2php_form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(html2php_form));
            this.select_html_folder_btn = new System.Windows.Forms.Button();
            this.html_files_lbl = new System.Windows.Forms.Label();
            this.convert_to_php_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_html_folder_btn
            // 
            this.select_html_folder_btn.AllowDrop = true;
            this.select_html_folder_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.select_html_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_html_folder_btn.Location = new System.Drawing.Point(37, 62);
            this.select_html_folder_btn.Name = "select_html_folder_btn";
            this.select_html_folder_btn.Size = new System.Drawing.Size(127, 77);
            this.select_html_folder_btn.TabIndex = 0;
            this.select_html_folder_btn.Text = "HTML Folder";
            this.select_html_folder_btn.UseVisualStyleBackColor = false;
            this.select_html_folder_btn.Click += new System.EventHandler(this.select_html_folder_btn_Click);
            // 
            // html_files_lbl
            // 
            this.html_files_lbl.AutoSize = true;
            this.html_files_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.html_files_lbl.Location = new System.Drawing.Point(159, 213);
            this.html_files_lbl.Name = "html_files_lbl";
            this.html_files_lbl.Size = new System.Drawing.Size(199, 25);
            this.html_files_lbl.TabIndex = 1;
            this.html_files_lbl.Text = "Loaded HTML files: 0";
            this.html_files_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convert_to_php_btn
            // 
            this.convert_to_php_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.convert_to_php_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_to_php_btn.Location = new System.Drawing.Point(373, 62);
            this.convert_to_php_btn.Name = "convert_to_php_btn";
            this.convert_to_php_btn.Size = new System.Drawing.Size(127, 77);
            this.convert_to_php_btn.TabIndex = 2;
            this.convert_to_php_btn.Text = "Convert to PHP";
            this.convert_to_php_btn.UseVisualStyleBackColor = false;
            this.convert_to_php_btn.Click += new System.EventHandler(this.convert_to_php_btn_Click);
            // 
            // html2php_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(552, 297);
            this.Controls.Add(this.convert_to_php_btn);
            this.Controls.Add(this.html_files_lbl);
            this.Controls.Add(this.select_html_folder_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "html2php_form";
            this.Text = "HTML2PHP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_html_folder_btn;
        private System.Windows.Forms.Label html_files_lbl;
        private System.Windows.Forms.Button convert_to_php_btn;
    }
}

