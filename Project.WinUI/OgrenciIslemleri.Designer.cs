namespace Project.WinUI
{
    partial class OgreniIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSubeler = new System.Windows.Forms.ComboBox();
            this.btnSubeOgrenciListele = new System.Windows.Forms.Button();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNotuKaydet = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDevamsizlikKaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpBaslangicGunu = new System.Windows.Forms.DateTimePicker();
            this.chbRaporlu = new System.Windows.Forms.CheckBox();
            this.chbNobetci = new System.Windows.Forms.CheckBox();
            this.rdbBirinciSinav = new System.Windows.Forms.RadioButton();
            this.rdbIkinciSinav = new System.Windows.Forms.RadioButton();
            this.rdbUcuncuSinav = new System.Windows.Forms.RadioButton();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpBitisGunu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 618);
            this.label2.TabIndex = 0;
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(28, 55);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.Size = new System.Drawing.Size(584, 559);
            this.dgvListStudent.TabIndex = 0;
            this.dgvListStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStudent_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aktif Öğrenci Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(618, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Öğrenci Adı Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(618, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rapor Başlangıç Tarihi";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(618, 196);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.ReadOnly = true;
            this.txtOgrenciAdi.Size = new System.Drawing.Size(182, 23);
            this.txtOgrenciAdi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(618, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Devamsızlık İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(618, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Not Giriş İşlemleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(618, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şubeler";
            // 
            // cmbSubeler
            // 
            this.cmbSubeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubeler.FormattingEnabled = true;
            this.cmbSubeler.Location = new System.Drawing.Point(618, 55);
            this.cmbSubeler.Name = "cmbSubeler";
            this.cmbSubeler.Size = new System.Drawing.Size(181, 25);
            this.cmbSubeler.TabIndex = 0;
            // 
            // btnSubeOgrenciListele
            // 
            this.btnSubeOgrenciListele.Location = new System.Drawing.Point(618, 86);
            this.btnSubeOgrenciListele.Name = "btnSubeOgrenciListele";
            this.btnSubeOgrenciListele.Size = new System.Drawing.Size(232, 28);
            this.btnSubeOgrenciListele.TabIndex = 0;
            this.btnSubeOgrenciListele.Text = "Şubedeki Öğrencileri Listele";
            this.btnSubeOgrenciListele.UseVisualStyleBackColor = true;
            this.btnSubeOgrenciListele.Click += new System.EventHandler(this.btnSubeOgrenciListele_Click);
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(619, 476);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(182, 25);
            this.cmbDersler.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(618, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dersler";
            // 
            // btnNotuKaydet
            // 
            this.btnNotuKaydet.Location = new System.Drawing.Point(618, 583);
            this.btnNotuKaydet.Name = "btnNotuKaydet";
            this.btnNotuKaydet.Size = new System.Drawing.Size(107, 31);
            this.btnNotuKaydet.TabIndex = 0;
            this.btnNotuKaydet.Text = "Notu Kaydet";
            this.btnNotuKaydet.UseVisualStyleBackColor = true;
            this.btnNotuKaydet.Click += new System.EventHandler(this.btnNotuKaydet_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(864, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 618);
            this.label15.TabIndex = 0;
            // 
            // btnDevamsizlikKaydet
            // 
            this.btnDevamsizlikKaydet.Location = new System.Drawing.Point(618, 377);
            this.btnDevamsizlikKaydet.Name = "btnDevamsizlikKaydet";
            this.btnDevamsizlikKaydet.Size = new System.Drawing.Size(153, 31);
            this.btnDevamsizlikKaydet.TabIndex = 0;
            this.btnDevamsizlikKaydet.Text = "Devamsızlığı Kaydet";
            this.btnDevamsizlikKaydet.UseVisualStyleBackColor = true;
            this.btnDevamsizlikKaydet.Click += new System.EventHandler(this.btnDevamsizlikKaydet_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(611, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 10);
            this.label14.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(356, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(272, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Arama Yap";
            // 
            // dtpBaslangicGunu
            // 
            this.dtpBaslangicGunu.Location = new System.Drawing.Point(618, 245);
            this.dtpBaslangicGunu.Name = "dtpBaslangicGunu";
            this.dtpBaslangicGunu.Size = new System.Drawing.Size(233, 23);
            this.dtpBaslangicGunu.TabIndex = 0;
            // 
            // chbRaporlu
            // 
            this.chbRaporlu.AutoSize = true;
            this.chbRaporlu.Location = new System.Drawing.Point(618, 323);
            this.chbRaporlu.Name = "chbRaporlu";
            this.chbRaporlu.Size = new System.Drawing.Size(131, 21);
            this.chbRaporlu.TabIndex = 0;
            this.chbRaporlu.Text = "Raporlu Öğrenci";
            this.chbRaporlu.UseVisualStyleBackColor = true;
            // 
            // chbNobetci
            // 
            this.chbNobetci.AutoSize = true;
            this.chbNobetci.Location = new System.Drawing.Point(618, 350);
            this.chbNobetci.Name = "chbNobetci";
            this.chbNobetci.Size = new System.Drawing.Size(129, 21);
            this.chbNobetci.TabIndex = 0;
            this.chbNobetci.Text = "Nöbetçi Öğrenci";
            this.chbNobetci.UseVisualStyleBackColor = true;
            // 
            // rdbBirinciSinav
            // 
            this.rdbBirinciSinav.AutoSize = true;
            this.rdbBirinciSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbBirinciSinav.Location = new System.Drawing.Point(618, 556);
            this.rdbBirinciSinav.Name = "rdbBirinciSinav";
            this.rdbBirinciSinav.Size = new System.Drawing.Size(107, 21);
            this.rdbBirinciSinav.TabIndex = 1;
            this.rdbBirinciSinav.TabStop = true;
            this.rdbBirinciSinav.Text = "1.Sınav Notu";
            this.rdbBirinciSinav.UseVisualStyleBackColor = true;
            // 
            // rdbIkinciSinav
            // 
            this.rdbIkinciSinav.AutoSize = true;
            this.rdbIkinciSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbIkinciSinav.Location = new System.Drawing.Point(731, 556);
            this.rdbIkinciSinav.Name = "rdbIkinciSinav";
            this.rdbIkinciSinav.Size = new System.Drawing.Size(107, 21);
            this.rdbIkinciSinav.TabIndex = 1;
            this.rdbIkinciSinav.TabStop = true;
            this.rdbIkinciSinav.Text = "2.Sınav Notu";
            this.rdbIkinciSinav.UseVisualStyleBackColor = true;
            // 
            // rdbUcuncuSinav
            // 
            this.rdbUcuncuSinav.AutoSize = true;
            this.rdbUcuncuSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbUcuncuSinav.Location = new System.Drawing.Point(731, 588);
            this.rdbUcuncuSinav.Name = "rdbUcuncuSinav";
            this.rdbUcuncuSinav.Size = new System.Drawing.Size(107, 21);
            this.rdbUcuncuSinav.TabIndex = 1;
            this.rdbUcuncuSinav.TabStop = true;
            this.rdbUcuncuSinav.Text = "3.Sınav Notu";
            this.rdbUcuncuSinav.UseVisualStyleBackColor = true;
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Location = new System.Drawing.Point(618, 527);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(183, 23);
            this.txtDersNotu.TabIndex = 2;
            this.txtDersNotu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDersNotu_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(618, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ders Notu";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(12, 617);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(862, 10);
            this.label19.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(611, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 10);
            this.label12.TabIndex = 0;
            // 
            // dtpBitisGunu
            // 
            this.dtpBitisGunu.Location = new System.Drawing.Point(618, 294);
            this.dtpBitisGunu.Name = "dtpBitisGunu";
            this.dtpBitisGunu.Size = new System.Drawing.Size(233, 23);
            this.dtpBitisGunu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(618, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rapor Bitiş Tarihi";
            // 
            // OgreniIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 633);
            this.Controls.Add(this.txtDersNotu);
            this.Controls.Add(this.rdbUcuncuSinav);
            this.Controls.Add(this.rdbIkinciSinav);
            this.Controls.Add(this.rdbBirinciSinav);
            this.Controls.Add(this.chbNobetci);
            this.Controls.Add(this.chbRaporlu);
            this.Controls.Add(this.dtpBitisGunu);
            this.Controls.Add(this.dtpBaslangicGunu);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDevamsizlikKaydet);
            this.Controls.Add(this.btnNotuKaydet);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.btnSubeOgrenciListele);
            this.Controls.Add(this.cmbSubeler);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListStudent);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgreniIslemleri";
            this.Text = "OgrenciIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSubeler;
        private System.Windows.Forms.Button btnSubeOgrenciListele;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNotuKaydet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDevamsizlikKaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpBaslangicGunu;
        private System.Windows.Forms.CheckBox chbRaporlu;
        private System.Windows.Forms.CheckBox chbNobetci;
        private System.Windows.Forms.RadioButton rdbBirinciSinav;
        private System.Windows.Forms.RadioButton rdbIkinciSinav;
        private System.Windows.Forms.RadioButton rdbUcuncuSinav;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpBitisGunu;
        private System.Windows.Forms.Label label5;
    }
}