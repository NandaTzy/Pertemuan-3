namespace TugasTiga1
{
    partial class frmTulisanBerjalan
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
            this.lblTampil = new System.Windows.Forms.Button();
            this.lblHilangkan = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblKelas1 = new System.Windows.Forms.Label();
            this.lblNama1 = new System.Windows.Forms.Label();
            this.lblNIM1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTampil
            // 
            this.lblTampil.Location = new System.Drawing.Point(71, 179);
            this.lblTampil.Name = "lblTampil";
            this.lblTampil.Size = new System.Drawing.Size(75, 23);
            this.lblTampil.TabIndex = 0;
            this.lblTampil.Text = "Tampilkan";
            this.lblTampil.UseVisualStyleBackColor = true;
            this.lblTampil.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHilangkan
            // 
            this.lblHilangkan.Location = new System.Drawing.Point(211, 179);
            this.lblHilangkan.Name = "lblHilangkan";
            this.lblHilangkan.Size = new System.Drawing.Size(75, 23);
            this.lblHilangkan.TabIndex = 1;
            this.lblHilangkan.Text = "Hilangkan";
            this.lblHilangkan.UseVisualStyleBackColor = true;
            this.lblHilangkan.Click += new System.EventHandler(this.lblHilangkan_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(49, 84);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(41, 13);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama :";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(49, 116);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(39, 13);
            this.lblKelas.TabIndex = 3;
            this.lblKelas.Text = "Kelas :";
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Location = new System.Drawing.Point(49, 48);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(36, 13);
            this.lblNIM.TabIndex = 4;
            this.lblNIM.Text = "NIM  :";
            // 
            // lblKelas1
            // 
            this.lblKelas1.AutoSize = true;
            this.lblKelas1.Location = new System.Drawing.Point(111, 116);
            this.lblKelas1.Name = "lblKelas1";
            this.lblKelas1.Size = new System.Drawing.Size(0, 13);
            this.lblKelas1.TabIndex = 5;
            // 
            // lblNama1
            // 
            this.lblNama1.AutoSize = true;
            this.lblNama1.Location = new System.Drawing.Point(111, 84);
            this.lblNama1.Name = "lblNama1";
            this.lblNama1.Size = new System.Drawing.Size(0, 13);
            this.lblNama1.TabIndex = 6;
            // 
            // lblNIM1
            // 
            this.lblNIM1.AutoSize = true;
            this.lblNIM1.Location = new System.Drawing.Point(111, 48);
            this.lblNIM1.Name = "lblNIM1";
            this.lblNIM1.Size = new System.Drawing.Size(0, 13);
            this.lblNIM1.TabIndex = 7;
            this.lblNIM1.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmTulisanBerjalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 263);
            this.Controls.Add(this.lblNIM1);
            this.Controls.Add(this.lblNama1);
            this.Controls.Add(this.lblKelas1);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblHilangkan);
            this.Controls.Add(this.lblTampil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmTulisanBerjalan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tulisan Berjalan";
            this.Load += new System.EventHandler(this.frmTulisanBerjalan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblTampil;
        private System.Windows.Forms.Button lblHilangkan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblKelas1;
        private System.Windows.Forms.Label lblNama1;
        private System.Windows.Forms.Label lblNIM1;
    }
}

