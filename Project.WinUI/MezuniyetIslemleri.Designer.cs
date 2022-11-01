namespace Project.WinUI
{
    partial class MezuniyetIslemleri
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
            this.dgvOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSiniflar = new System.Windows.Forms.ComboBox();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOkulNumarasi = new System.Windows.Forms.TextBox();
            this.btnDersOrtalamaHesapla = new System.Windows.Forms.Button();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chbGuzDonemi = new System.Windows.Forms.CheckBox();
            this.chbBaharDonemi = new System.Windows.Forms.CheckBox();
            this.chbTesekkur = new System.Windows.Forms.CheckBox();
            this.chbTakdir = new System.Windows.Forms.CheckBox();
            this.chbOnur = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNotGoster = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSeciliDers = new System.Windows.Forms.TextBox();
            this.txtBirinciSinav = new System.Windows.Forms.TextBox();
            this.txtIkinciSinav = new System.Windows.Forms.TextBox();
            this.txtUcuncuSinav = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtOzurluDevamsizlik = new System.Windows.Forms.TextBox();
            this.txtOzursuzDevamsizlik = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnDonemOrtalamaHesapla = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtSube = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtGuzDonemNotu = new System.Windows.Forms.TextBox();
            this.txtBaharDonemNotu = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnYilSonuHesapla = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.txtYilsonuNotu = new System.Windows.Forms.TextBox();
            this.btnSinifGecmeKontrol = new System.Windows.Forms.Button();
            this.rdbGecti = new System.Windows.Forms.RadioButton();
            this.rdbTekrar = new System.Windows.Forms.RadioButton();
            this.rdbSistem = new System.Windows.Forms.RadioButton();
            this.label40 = new System.Windows.Forms.Label();
            this.lblAktifDonem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciListesi
            // 
            this.dgvOgrenciListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciListesi.Location = new System.Drawing.Point(29, 56);
            this.dgvOgrenciListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOgrenciListesi.Name = "dgvOgrenciListesi";
            this.dgvOgrenciListesi.Size = new System.Drawing.Size(563, 490);
            this.dgvOgrenciListesi.TabIndex = 0;
            this.dgvOgrenciListesi.TabStop = false;
            this.dgvOgrenciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciListesi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şubeler";
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiniflar.FormattingEnabled = true;
            this.cmbSiniflar.Location = new System.Drawing.Point(103, 23);
            this.cmbSiniflar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Size = new System.Drawing.Size(193, 25);
            this.cmbSiniflar.TabIndex = 0;
            this.cmbSiniflar.TabStop = false;
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(303, 23);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(193, 25);
            this.btnOgrenciListele.TabIndex = 0;
            this.btnOgrenciListele.TabStop = false;
            this.btnOgrenciListele.Text = "Öğrencileri Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 796);
            this.label8.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(900, 10);
            this.label3.TabIndex = 5;
            // 
            // txtOgrenciAdSoyad
            // 
            this.txtOgrenciAdSoyad.Location = new System.Drawing.Point(614, 76);
            this.txtOgrenciAdSoyad.Name = "txtOgrenciAdSoyad";
            this.txtOgrenciAdSoyad.ReadOnly = true;
            this.txtOgrenciAdSoyad.Size = new System.Drawing.Size(129, 23);
            this.txtOgrenciAdSoyad.TabIndex = 0;
            this.txtOgrenciAdSoyad.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğrenci Adı Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Okul Numarası";
            // 
            // txtOkulNumarasi
            // 
            this.txtOkulNumarasi.Location = new System.Drawing.Point(749, 76);
            this.txtOkulNumarasi.Name = "txtOkulNumarasi";
            this.txtOkulNumarasi.ReadOnly = true;
            this.txtOkulNumarasi.Size = new System.Drawing.Size(129, 23);
            this.txtOkulNumarasi.TabIndex = 0;
            this.txtOkulNumarasi.TabStop = false;
            // 
            // btnDersOrtalamaHesapla
            // 
            this.btnDersOrtalamaHesapla.Location = new System.Drawing.Point(28, 605);
            this.btnDersOrtalamaHesapla.Name = "btnDersOrtalamaHesapla";
            this.btnDersOrtalamaHesapla.Size = new System.Drawing.Size(147, 42);
            this.btnDersOrtalamaHesapla.TabIndex = 0;
            this.btnDersOrtalamaHesapla.TabStop = false;
            this.btnDersOrtalamaHesapla.Text = "Ders Ortalaması Hesapla";
            this.btnDersOrtalamaHesapla.UseVisualStyleBackColor = true;
            this.btnDersOrtalamaHesapla.Click += new System.EventHandler(this.btnDersOrtalamaHesapla_Click);
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(614, 287);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(194, 25);
            this.cmbDersler.TabIndex = 0;
            this.cmbDersler.TabStop = false;
            this.cmbDersler.SelectedIndexChanged += new System.EventHandler(this.cmbDonemDersleri_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(614, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Dersler";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label18.Location = new System.Drawing.Point(615, 25);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Seçili Öğrenci Bilgileri";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(598, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 796);
            this.label2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(29, 550);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sınıf Geçme / Mezuniyet İşlemleri";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(902, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 796);
            this.label15.TabIndex = 5;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(614, 472);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.ReadOnly = true;
            this.txtOrtalama.Size = new System.Drawing.Size(129, 23);
            this.txtOrtalama.TabIndex = 0;
            this.txtOrtalama.TabStop = false;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(12, 797);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(900, 10);
            this.label22.TabIndex = 5;
            // 
            // chbGuzDonemi
            // 
            this.chbGuzDonemi.AutoSize = true;
            this.chbGuzDonemi.Enabled = false;
            this.chbGuzDonemi.Location = new System.Drawing.Point(334, 605);
            this.chbGuzDonemi.Name = "chbGuzDonemi";
            this.chbGuzDonemi.Size = new System.Drawing.Size(105, 21);
            this.chbGuzDonemi.TabIndex = 22;
            this.chbGuzDonemi.Text = "Güz Dönemi";
            this.chbGuzDonemi.UseVisualStyleBackColor = true;
            // 
            // chbBaharDonemi
            // 
            this.chbBaharDonemi.AutoSize = true;
            this.chbBaharDonemi.Enabled = false;
            this.chbBaharDonemi.Location = new System.Drawing.Point(334, 626);
            this.chbBaharDonemi.Name = "chbBaharDonemi";
            this.chbBaharDonemi.Size = new System.Drawing.Size(117, 21);
            this.chbBaharDonemi.TabIndex = 22;
            this.chbBaharDonemi.Text = "Bahar Dönemi";
            this.chbBaharDonemi.UseVisualStyleBackColor = true;
            // 
            // chbTesekkur
            // 
            this.chbTesekkur.AutoSize = true;
            this.chbTesekkur.Enabled = false;
            this.chbTesekkur.Location = new System.Drawing.Point(28, 719);
            this.chbTesekkur.Name = "chbTesekkur";
            this.chbTesekkur.Size = new System.Drawing.Size(136, 21);
            this.chbTesekkur.TabIndex = 24;
            this.chbTesekkur.Text = "Teşekkür Belgesi";
            this.chbTesekkur.UseVisualStyleBackColor = true;
            // 
            // chbTakdir
            // 
            this.chbTakdir.AutoSize = true;
            this.chbTakdir.Enabled = false;
            this.chbTakdir.Location = new System.Drawing.Point(28, 746);
            this.chbTakdir.Name = "chbTakdir";
            this.chbTakdir.Size = new System.Drawing.Size(117, 21);
            this.chbTakdir.TabIndex = 24;
            this.chbTakdir.Text = "Takdir Belgesi";
            this.chbTakdir.UseVisualStyleBackColor = true;
            // 
            // chbOnur
            // 
            this.chbOnur.AutoSize = true;
            this.chbOnur.Enabled = false;
            this.chbOnur.Location = new System.Drawing.Point(28, 773);
            this.chbOnur.Name = "chbOnur";
            this.chbOnur.Size = new System.Drawing.Size(109, 21);
            this.chbOnur.TabIndex = 24;
            this.chbOnur.Text = "Onur Belgesi";
            this.chbOnur.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(29, 698);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Belge İşlemleri";
            // 
            // btnNotGoster
            // 
            this.btnNotGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnNotGoster.Location = new System.Drawing.Point(814, 287);
            this.btnNotGoster.Name = "btnNotGoster";
            this.btnNotGoster.Size = new System.Drawing.Size(82, 25);
            this.btnNotGoster.TabIndex = 0;
            this.btnNotGoster.TabStop = false;
            this.btnNotGoster.Text = "Not Göster";
            this.btnNotGoster.UseVisualStyleBackColor = true;
            this.btnNotGoster.Click += new System.EventHandler(this.btnNotGoster_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(615, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Seçili Ders";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(614, 360);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "1.Sınav Notu";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(749, 360);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 17);
            this.label26.TabIndex = 25;
            this.label26.Text = "2.Sınav Notu";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(614, 406);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 17);
            this.label27.TabIndex = 25;
            this.label27.Text = "3.Sınav Notu";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(614, 452);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(136, 17);
            this.label28.TabIndex = 26;
            this.label28.Text = "Ders Not Ortalaması";
            // 
            // txtSeciliDers
            // 
            this.txtSeciliDers.Location = new System.Drawing.Point(615, 334);
            this.txtSeciliDers.Name = "txtSeciliDers";
            this.txtSeciliDers.ReadOnly = true;
            this.txtSeciliDers.Size = new System.Drawing.Size(193, 23);
            this.txtSeciliDers.TabIndex = 0;
            this.txtSeciliDers.TabStop = false;
            // 
            // txtBirinciSinav
            // 
            this.txtBirinciSinav.Location = new System.Drawing.Point(614, 380);
            this.txtBirinciSinav.Name = "txtBirinciSinav";
            this.txtBirinciSinav.ReadOnly = true;
            this.txtBirinciSinav.Size = new System.Drawing.Size(129, 23);
            this.txtBirinciSinav.TabIndex = 0;
            this.txtBirinciSinav.TabStop = false;
            // 
            // txtIkinciSinav
            // 
            this.txtIkinciSinav.Location = new System.Drawing.Point(749, 380);
            this.txtIkinciSinav.Name = "txtIkinciSinav";
            this.txtIkinciSinav.ReadOnly = true;
            this.txtIkinciSinav.Size = new System.Drawing.Size(129, 23);
            this.txtIkinciSinav.TabIndex = 0;
            this.txtIkinciSinav.TabStop = false;
            // 
            // txtUcuncuSinav
            // 
            this.txtUcuncuSinav.Location = new System.Drawing.Point(614, 426);
            this.txtUcuncuSinav.Name = "txtUcuncuSinav";
            this.txtUcuncuSinav.ReadOnly = true;
            this.txtUcuncuSinav.Size = new System.Drawing.Size(129, 23);
            this.txtUcuncuSinav.TabIndex = 0;
            this.txtUcuncuSinav.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label29.Location = new System.Drawing.Point(614, 161);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(161, 20);
            this.label29.TabIndex = 0;
            this.label29.Text = "Devamsızlık Bilgileri";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(614, 184);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(128, 17);
            this.label30.TabIndex = 25;
            this.label30.Text = "Özürlü Devamsızlık";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(748, 184);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(139, 17);
            this.label31.TabIndex = 25;
            this.label31.Text = "Özürsüz Devamsızlık";
            // 
            // txtOzurluDevamsizlik
            // 
            this.txtOzurluDevamsizlik.Location = new System.Drawing.Point(614, 204);
            this.txtOzurluDevamsizlik.Name = "txtOzurluDevamsizlik";
            this.txtOzurluDevamsizlik.ReadOnly = true;
            this.txtOzurluDevamsizlik.Size = new System.Drawing.Size(129, 23);
            this.txtOzurluDevamsizlik.TabIndex = 0;
            this.txtOzurluDevamsizlik.TabStop = false;
            // 
            // txtOzursuzDevamsizlik
            // 
            this.txtOzursuzDevamsizlik.Location = new System.Drawing.Point(749, 204);
            this.txtOzursuzDevamsizlik.Name = "txtOzursuzDevamsizlik";
            this.txtOzursuzDevamsizlik.ReadOnly = true;
            this.txtOzursuzDevamsizlik.Size = new System.Drawing.Size(129, 23);
            this.txtOzursuzDevamsizlik.TabIndex = 0;
            this.txtOzursuzDevamsizlik.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label32.Location = new System.Drawing.Point(614, 243);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 20);
            this.label32.TabIndex = 0;
            this.label32.Text = "Not Bilgileri";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(598, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(305, 10);
            this.label16.TabIndex = 5;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label34.Location = new System.Drawing.Point(28, 576);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(341, 26);
            this.label34.TabIndex = 27;
            this.label34.Text = "Buradaki butonlar işlemlerini sağ tarafta bulunan \'Seçili Öğrenci Bilgileri\' \r\nkı" +
    "smındaki verilere göre işlem gerçekleştirir.";
            // 
            // btnDonemOrtalamaHesapla
            // 
            this.btnDonemOrtalamaHesapla.Location = new System.Drawing.Point(181, 605);
            this.btnDonemOrtalamaHesapla.Name = "btnDonemOrtalamaHesapla";
            this.btnDonemOrtalamaHesapla.Size = new System.Drawing.Size(147, 42);
            this.btnDonemOrtalamaHesapla.TabIndex = 0;
            this.btnDonemOrtalamaHesapla.TabStop = false;
            this.btnDonemOrtalamaHesapla.Text = "Dönem Ortalaması Hesapla";
            this.btnDonemOrtalamaHesapla.UseVisualStyleBackColor = true;
            this.btnDonemOrtalamaHesapla.Click += new System.EventHandler(this.btnDonemOrtalamaHesapla_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(614, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Öğrencinin Sınıfı";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(751, 102);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(124, 17);
            this.label33.TabIndex = 0;
            this.label33.Text = "Öğrencinin Şubesi";
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(614, 122);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.ReadOnly = true;
            this.txtSinif.Size = new System.Drawing.Size(129, 23);
            this.txtSinif.TabIndex = 0;
            this.txtSinif.TabStop = false;
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(749, 122);
            this.txtSube.Name = "txtSube";
            this.txtSube.ReadOnly = true;
            this.txtSube.Size = new System.Drawing.Size(129, 23);
            this.txtSube.TabIndex = 0;
            this.txtSube.TabStop = false;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label35.Location = new System.Drawing.Point(598, 230);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(305, 10);
            this.label35.TabIndex = 5;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(614, 501);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(132, 17);
            this.label36.TabIndex = 26;
            this.label36.Text = "Güz Not Ortalaması";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(752, 501);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(144, 17);
            this.label37.TabIndex = 26;
            this.label37.Text = "Bahar Not Ortalaması";
            // 
            // txtGuzDonemNotu
            // 
            this.txtGuzDonemNotu.Location = new System.Drawing.Point(614, 521);
            this.txtGuzDonemNotu.Name = "txtGuzDonemNotu";
            this.txtGuzDonemNotu.ReadOnly = true;
            this.txtGuzDonemNotu.Size = new System.Drawing.Size(129, 23);
            this.txtGuzDonemNotu.TabIndex = 0;
            this.txtGuzDonemNotu.TabStop = false;
            // 
            // txtBaharDonemNotu
            // 
            this.txtBaharDonemNotu.Location = new System.Drawing.Point(749, 521);
            this.txtBaharDonemNotu.Name = "txtBaharDonemNotu";
            this.txtBaharDonemNotu.ReadOnly = true;
            this.txtBaharDonemNotu.Size = new System.Drawing.Size(129, 23);
            this.txtBaharDonemNotu.TabIndex = 0;
            this.txtBaharDonemNotu.TabStop = false;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label38.Location = new System.Drawing.Point(601, 547);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(311, 10);
            this.label38.TabIndex = 5;
            // 
            // btnYilSonuHesapla
            // 
            this.btnYilSonuHesapla.Location = new System.Drawing.Point(28, 653);
            this.btnYilSonuHesapla.Name = "btnYilSonuHesapla";
            this.btnYilSonuHesapla.Size = new System.Drawing.Size(147, 42);
            this.btnYilSonuHesapla.TabIndex = 0;
            this.btnYilSonuHesapla.TabStop = false;
            this.btnYilSonuHesapla.Text = "Yılsonu Ortalaması Hesapla";
            this.btnYilSonuHesapla.UseVisualStyleBackColor = true;
            this.btnYilSonuHesapla.Click += new System.EventHandler(this.btnYilSonuHesapla_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label39.Location = new System.Drawing.Point(182, 652);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 17);
            this.label39.TabIndex = 1;
            this.label39.Text = "Yıl Ortalaması";
            // 
            // txtYilsonuNotu
            // 
            this.txtYilsonuNotu.Enabled = false;
            this.txtYilsonuNotu.Location = new System.Drawing.Point(181, 672);
            this.txtYilsonuNotu.Name = "txtYilsonuNotu";
            this.txtYilsonuNotu.Size = new System.Drawing.Size(170, 23);
            this.txtYilsonuNotu.TabIndex = 19;
            this.txtYilsonuNotu.TextChanged += new System.EventHandler(this.txtYilsonuNotu_TextChanged);
            // 
            // btnSinifGecmeKontrol
            // 
            this.btnSinifGecmeKontrol.Enabled = false;
            this.btnSinifGecmeKontrol.Location = new System.Drawing.Point(287, 766);
            this.btnSinifGecmeKontrol.Name = "btnSinifGecmeKontrol";
            this.btnSinifGecmeKontrol.Size = new System.Drawing.Size(171, 28);
            this.btnSinifGecmeKontrol.TabIndex = 18;
            this.btnSinifGecmeKontrol.Text = "İşlemi Gerçekleştir";
            this.btnSinifGecmeKontrol.UseVisualStyleBackColor = true;
            this.btnSinifGecmeKontrol.Click += new System.EventHandler(this.btnSinifGecmeKontrol_Click);
            // 
            // rdbGecti
            // 
            this.rdbGecti.AutoSize = true;
            this.rdbGecti.Enabled = false;
            this.rdbGecti.Location = new System.Drawing.Point(287, 704);
            this.rdbGecti.Name = "rdbGecti";
            this.rdbGecti.Size = new System.Drawing.Size(93, 21);
            this.rdbGecti.TabIndex = 20;
            this.rdbGecti.TabStop = true;
            this.rdbGecti.Text = "Sınıfı Geçti";
            this.rdbGecti.UseVisualStyleBackColor = true;
            // 
            // rdbTekrar
            // 
            this.rdbTekrar.AutoSize = true;
            this.rdbTekrar.Enabled = false;
            this.rdbTekrar.Location = new System.Drawing.Point(386, 704);
            this.rdbTekrar.Name = "rdbTekrar";
            this.rdbTekrar.Size = new System.Drawing.Size(102, 21);
            this.rdbTekrar.TabIndex = 20;
            this.rdbTekrar.TabStop = true;
            this.rdbTekrar.Text = "Sınıf Tekrarı";
            this.rdbTekrar.UseVisualStyleBackColor = true;
            // 
            // rdbSistem
            // 
            this.rdbSistem.AutoSize = true;
            this.rdbSistem.Location = new System.Drawing.Point(494, 704);
            this.rdbSistem.Name = "rdbSistem";
            this.rdbSistem.Size = new System.Drawing.Size(68, 21);
            this.rdbSistem.TabIndex = 20;
            this.rdbSistem.TabStop = true;
            this.rdbSistem.Text = "Sistem";
            this.rdbSistem.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label40.Location = new System.Drawing.Point(287, 728);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(307, 30);
            this.label40.TabIndex = 21;
            this.label40.Text = "\'Sistem\' seçeneği İşaretli olduğu sürece Geçti/Kaldı \r\nişemleri bilgisayar tarafı" +
    "ndan otomatik hesaplanacaktır.\r\n";
            // 
            // lblAktifDonem
            // 
            this.lblAktifDonem.AutoSize = true;
            this.lblAktifDonem.Location = new System.Drawing.Point(615, 561);
            this.lblAktifDonem.Name = "lblAktifDonem";
            this.lblAktifDonem.Size = new System.Drawing.Size(0, 17);
            this.lblAktifDonem.TabIndex = 28;
            // 
            // MezuniyetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 814);
            this.Controls.Add(this.lblAktifDonem);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnNotGoster);
            this.Controls.Add(this.chbOnur);
            this.Controls.Add(this.chbTakdir);
            this.Controls.Add(this.chbTesekkur);
            this.Controls.Add(this.chbBaharDonemi);
            this.Controls.Add(this.chbGuzDonemi);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.rdbSistem);
            this.Controls.Add(this.rdbTekrar);
            this.Controls.Add(this.rdbGecti);
            this.Controls.Add(this.txtYilsonuNotu);
            this.Controls.Add(this.btnSinifGecmeKontrol);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.btnDonemOrtalamaHesapla);
            this.Controls.Add(this.btnYilSonuHesapla);
            this.Controls.Add(this.btnDersOrtalamaHesapla);
            this.Controls.Add(this.txtBaharDonemNotu);
            this.Controls.Add(this.txtGuzDonemNotu);
            this.Controls.Add(this.txtUcuncuSinav);
            this.Controls.Add(this.txtIkinciSinav);
            this.Controls.Add(this.txtBirinciSinav);
            this.Controls.Add(this.txtSube);
            this.Controls.Add(this.txtSinif);
            this.Controls.Add(this.txtOzurluDevamsizlik);
            this.Controls.Add(this.txtOzursuzDevamsizlik);
            this.Controls.Add(this.txtSeciliDers);
            this.Controls.Add(this.txtOkulNumarasi);
            this.Controls.Add(this.txtOgrenciAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.cmbSiniflar);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOgrenciListesi);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MezuniyetIslemleri";
            this.Text = "MezuniyetIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSiniflar;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOkulNumarasi;
        private System.Windows.Forms.Button btnDersOrtalamaHesapla;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chbGuzDonemi;
        private System.Windows.Forms.CheckBox chbBaharDonemi;
        private System.Windows.Forms.CheckBox chbTesekkur;
        private System.Windows.Forms.CheckBox chbTakdir;
        private System.Windows.Forms.CheckBox chbOnur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNotGoster;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSeciliDers;
        private System.Windows.Forms.TextBox txtBirinciSinav;
        private System.Windows.Forms.TextBox txtIkinciSinav;
        private System.Windows.Forms.TextBox txtUcuncuSinav;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtOzurluDevamsizlik;
        private System.Windows.Forms.TextBox txtOzursuzDevamsizlik;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnDonemOrtalamaHesapla;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtSube;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtGuzDonemNotu;
        private System.Windows.Forms.TextBox txtBaharDonemNotu;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnYilSonuHesapla;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtYilsonuNotu;
        private System.Windows.Forms.Button btnSinifGecmeKontrol;
        private System.Windows.Forms.RadioButton rdbGecti;
        private System.Windows.Forms.RadioButton rdbTekrar;
        private System.Windows.Forms.RadioButton rdbSistem;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblAktifDonem;
    }
}