namespace Project.WinUI
{
    partial class DersIslemleri
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
            this.dgvDersListele = new System.Windows.Forms.DataGridView();
            this.txtAnaDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnaDersEkle = new System.Windows.Forms.Button();
            this.btnDersiDuzenle = new System.Windows.Forms.Button();
            this.btnDersiSil = new System.Windows.Forms.Button();
            this.btnAnaDersler = new System.Windows.Forms.Button();
            this.btnAltDersler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAltDersEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAltDersAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDersListele
            // 
            this.dgvDersListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDersListele.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDersListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersListele.Location = new System.Drawing.Point(28, 22);
            this.dgvDersListele.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDersListele.Name = "dgvDersListele";
            this.dgvDersListele.ReadOnly = true;
            this.dgvDersListele.Size = new System.Drawing.Size(580, 602);
            this.dgvDersListele.TabIndex = 0;
            this.dgvDersListele.TabStop = false;
            this.dgvDersListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDersListele_CellClick);
            // 
            // txtAnaDersAdi
            // 
            this.txtAnaDersAdi.Location = new System.Drawing.Point(615, 138);
            this.txtAnaDersAdi.Multiline = true;
            this.txtAnaDersAdi.Name = "txtAnaDersAdi";
            this.txtAnaDersAdi.Size = new System.Drawing.Size(191, 52);
            this.txtAnaDersAdi.TabIndex = 0;
            this.txtAnaDersAdi.TabStop = false;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(615, 265);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(191, 23);
            this.txtDersKodu.TabIndex = 0;
            this.txtDersKodu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(615, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ana Ders Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(615, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders Kodu";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 629);
            this.label6.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(15, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(807, 10);
            this.label8.TabIndex = 4;
            // 
            // btnAnaDersEkle
            // 
            this.btnAnaDersEkle.Location = new System.Drawing.Point(613, 478);
            this.btnAnaDersEkle.Name = "btnAnaDersEkle";
            this.btnAnaDersEkle.Size = new System.Drawing.Size(193, 32);
            this.btnAnaDersEkle.TabIndex = 0;
            this.btnAnaDersEkle.TabStop = false;
            this.btnAnaDersEkle.Text = "Ana Ders Ekle";
            this.btnAnaDersEkle.UseVisualStyleBackColor = true;
            this.btnAnaDersEkle.Click += new System.EventHandler(this.btnAnaDersEkle_Click);
            // 
            // btnDersiDuzenle
            // 
            this.btnDersiDuzenle.Location = new System.Drawing.Point(613, 554);
            this.btnDersiDuzenle.Name = "btnDersiDuzenle";
            this.btnDersiDuzenle.Size = new System.Drawing.Size(193, 32);
            this.btnDersiDuzenle.TabIndex = 0;
            this.btnDersiDuzenle.TabStop = false;
            this.btnDersiDuzenle.Text = "Dersi Düzenle";
            this.btnDersiDuzenle.UseVisualStyleBackColor = true;
            this.btnDersiDuzenle.Click += new System.EventHandler(this.btnDersiDuzenle_Click);
            // 
            // btnDersiSil
            // 
            this.btnDersiSil.Location = new System.Drawing.Point(613, 592);
            this.btnDersiSil.Name = "btnDersiSil";
            this.btnDersiSil.Size = new System.Drawing.Size(193, 32);
            this.btnDersiSil.TabIndex = 0;
            this.btnDersiSil.TabStop = false;
            this.btnDersiSil.Text = "Dersi Sil";
            this.btnDersiSil.UseVisualStyleBackColor = true;
            this.btnDersiSil.Click += new System.EventHandler(this.btnDersiSil_Click);
            // 
            // btnAnaDersler
            // 
            this.btnAnaDersler.Location = new System.Drawing.Point(615, 22);
            this.btnAnaDersler.Name = "btnAnaDersler";
            this.btnAnaDersler.Size = new System.Drawing.Size(191, 42);
            this.btnAnaDersler.TabIndex = 0;
            this.btnAnaDersler.TabStop = false;
            this.btnAnaDersler.Text = "Aktif Ana Dersleri Listele";
            this.btnAnaDersler.UseVisualStyleBackColor = true;
            this.btnAnaDersler.Click += new System.EventHandler(this.btnAnaDersler_Click);
            // 
            // btnAltDersler
            // 
            this.btnAltDersler.Location = new System.Drawing.Point(614, 70);
            this.btnAltDersler.Name = "btnAltDersler";
            this.btnAltDersler.Size = new System.Drawing.Size(192, 42);
            this.btnAltDersler.TabIndex = 0;
            this.btnAltDersler.TabStop = false;
            this.btnAltDersler.Text = "Aktif Alt Dersleri Listele";
            this.btnAltDersler.UseVisualStyleBackColor = true;
            this.btnAltDersler.Click += new System.EventHandler(this.btnAltDersler_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 10);
            this.label1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(812, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 629);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ders kodu seçeneği sadece \r\nalt derslerde mevcuttur.\r\n";
            // 
            // btnAltDersEkle
            // 
            this.btnAltDersEkle.Location = new System.Drawing.Point(613, 516);
            this.btnAltDersEkle.Name = "btnAltDersEkle";
            this.btnAltDersEkle.Size = new System.Drawing.Size(193, 32);
            this.btnAltDersEkle.TabIndex = 0;
            this.btnAltDersEkle.TabStop = false;
            this.btnAltDersEkle.Text = "Alt Ders Ekle";
            this.btnAltDersEkle.UseVisualStyleBackColor = true;
            this.btnAltDersEkle.Click += new System.EventHandler(this.btnAltDersEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(615, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Alt Ders Adı";
            // 
            // txtAltDersAdi
            // 
            this.txtAltDersAdi.Location = new System.Drawing.Point(615, 216);
            this.txtAltDersAdi.Name = "txtAltDersAdi";
            this.txtAltDersAdi.Size = new System.Drawing.Size(191, 23);
            this.txtAltDersAdi.TabIndex = 0;
            this.txtAltDersAdi.TabStop = false;
            // 
            // DersIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAltDersler);
            this.Controls.Add(this.btnAnaDersler);
            this.Controls.Add(this.btnAltDersEkle);
            this.Controls.Add(this.btnDersiSil);
            this.Controls.Add(this.btnDersiDuzenle);
            this.Controls.Add(this.btnAnaDersEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltDersAdi);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.txtAnaDersAdi);
            this.Controls.Add(this.dgvDersListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 687);
            this.MinimumSize = new System.Drawing.Size(850, 687);
            this.Name = "DersIslemleri";
            this.Text = "Ders İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDersListele;
        private System.Windows.Forms.TextBox txtAnaDersAdi;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnaDersEkle;
        private System.Windows.Forms.Button btnDersiDuzenle;
        private System.Windows.Forms.Button btnDersiSil;
        private System.Windows.Forms.Button btnAnaDersler;
        private System.Windows.Forms.Button btnAltDersler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAltDersEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAltDersAdi;
    }
}