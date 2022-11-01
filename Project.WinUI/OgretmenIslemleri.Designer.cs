namespace Project.WinUI
{
    partial class OgretmenIslemleri
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
            this.dgvOgretmenListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeciliOgretmenAdi = new System.Windows.Forms.TextBox();
            this.btnOgretmenKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBransAdi = new System.Windows.Forms.TextBox();
            this.cmbAktifBranslar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBransKaydet = new System.Windows.Forms.Button();
            this.btnBransDuzenle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOgretmenListele = new System.Windows.Forms.Button();
            this.btnBransSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.btnDersAta = new System.Windows.Forms.Button();
            this.btnDersKaldir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOgretmenDuzenle = new System.Windows.Forms.Button();
            this.txtOgretmenAdi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOgretmenSoyadi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbButunBranslar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGunler = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnDersPrograminiKaydet = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtSekiz = new System.Windows.Forms.TextBox();
            this.txtAlti = new System.Windows.Forms.TextBox();
            this.txtBes = new System.Windows.Forms.TextBox();
            this.txtDort = new System.Windows.Forms.TextBox();
            this.txtYedi = new System.Windows.Forms.TextBox();
            this.lstOgretmenSiniflari = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtIki = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtUc = new System.Windows.Forms.TextBox();
            this.txtBir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizleSekiz = new System.Windows.Forms.Button();
            this.btnTemizleDort = new System.Windows.Forms.Button();
            this.btnTemizleAlti = new System.Windows.Forms.Button();
            this.btnTemizleYedi = new System.Windows.Forms.Button();
            this.btnTemizleIki = new System.Windows.Forms.Button();
            this.btnTemizleBes = new System.Windows.Forms.Button();
            this.btnTemizleUc = new System.Windows.Forms.Button();
            this.btnTemizleBir = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgretmenListe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOgretmenListe
            // 
            this.dgvOgretmenListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOgretmenListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgretmenListe.Location = new System.Drawing.Point(29, 50);
            this.dgvOgretmenListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOgretmenListe.Name = "dgvOgretmenListe";
            this.dgvOgretmenListe.Size = new System.Drawing.Size(544, 455);
            this.dgvOgretmenListe.TabIndex = 0;
            this.dgvOgretmenListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgretmenListe_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçili Öğretmen Adı";
            // 
            // txtSeciliOgretmenAdi
            // 
            this.txtSeciliOgretmenAdi.Enabled = false;
            this.txtSeciliOgretmenAdi.Location = new System.Drawing.Point(169, 23);
            this.txtSeciliOgretmenAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeciliOgretmenAdi.Name = "txtSeciliOgretmenAdi";
            this.txtSeciliOgretmenAdi.Size = new System.Drawing.Size(178, 23);
            this.txtSeciliOgretmenAdi.TabIndex = 0;
            this.txtSeciliOgretmenAdi.TextChanged += new System.EventHandler(this.txtSeciliOgretmenAdi_TextChanged);
            // 
            // btnOgretmenKaydet
            // 
            this.btnOgretmenKaydet.Location = new System.Drawing.Point(580, 230);
            this.btnOgretmenKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgretmenKaydet.Name = "btnOgretmenKaydet";
            this.btnOgretmenKaydet.Size = new System.Drawing.Size(178, 28);
            this.btnOgretmenKaydet.TabIndex = 0;
            this.btnOgretmenKaydet.Text = "Öğretmen Oluştur";
            this.btnOgretmenKaydet.UseVisualStyleBackColor = true;
            this.btnOgretmenKaydet.Click += new System.EventHandler(this.btnOgretmenKaydet_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 796);
            this.label2.TabIndex = 0;
            // 
            // txtBransAdi
            // 
            this.txtBransAdi.Location = new System.Drawing.Point(781, 125);
            this.txtBransAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBransAdi.Name = "txtBransAdi";
            this.txtBransAdi.Size = new System.Drawing.Size(179, 23);
            this.txtBransAdi.TabIndex = 0;
            // 
            // cmbAktifBranslar
            // 
            this.cmbAktifBranslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktifBranslar.FormattingEnabled = true;
            this.cmbAktifBranslar.Location = new System.Drawing.Point(580, 198);
            this.cmbAktifBranslar.Name = "cmbAktifBranslar";
            this.cmbAktifBranslar.Size = new System.Drawing.Size(179, 25);
            this.cmbAktifBranslar.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(781, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seçili Branş Bilgileri";
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.Location = new System.Drawing.Point(581, 327);
            this.btnOgretmenSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(179, 43);
            this.btnOgretmenSil.TabIndex = 0;
            this.btnOgretmenSil.Text = "Seçili Öğretmeni Sil";
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(963, 10);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Branş Adı";
            // 
            // btnBransKaydet
            // 
            this.btnBransKaydet.Location = new System.Drawing.Point(781, 225);
            this.btnBransKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnBransKaydet.Name = "btnBransKaydet";
            this.btnBransKaydet.Size = new System.Drawing.Size(179, 29);
            this.btnBransKaydet.TabIndex = 0;
            this.btnBransKaydet.Text = "Yeni Branş Oluştur";
            this.btnBransKaydet.UseVisualStyleBackColor = true;
            this.btnBransKaydet.Click += new System.EventHandler(this.btnBransKaydet_Click_1);
            // 
            // btnBransDuzenle
            // 
            this.btnBransDuzenle.Location = new System.Drawing.Point(782, 153);
            this.btnBransDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBransDuzenle.Name = "btnBransDuzenle";
            this.btnBransDuzenle.Size = new System.Drawing.Size(178, 29);
            this.btnBransDuzenle.TabIndex = 0;
            this.btnBransDuzenle.Text = "Seçili Branşı Düzenle";
            this.btnBransDuzenle.UseVisualStyleBackColor = true;
            this.btnBransDuzenle.Click += new System.EventHandler(this.btnBransDuzenle_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(12, 795);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(965, 10);
            this.label8.TabIndex = 0;
            // 
            // btnOgretmenListele
            // 
            this.btnOgretmenListele.Location = new System.Drawing.Point(579, 49);
            this.btnOgretmenListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgretmenListele.Name = "btnOgretmenListele";
            this.btnOgretmenListele.Size = new System.Drawing.Size(178, 33);
            this.btnOgretmenListele.TabIndex = 0;
            this.btnOgretmenListele.Text = "Öğretmenleri Listele";
            this.btnOgretmenListele.UseVisualStyleBackColor = true;
            this.btnOgretmenListele.Click += new System.EventHandler(this.btnOgretmenListele_Click);
            // 
            // btnBransSil
            // 
            this.btnBransSil.Location = new System.Drawing.Point(782, 189);
            this.btnBransSil.Name = "btnBransSil";
            this.btnBransSil.Size = new System.Drawing.Size(178, 29);
            this.btnBransSil.TabIndex = 5;
            this.btnBransSil.Text = "Seçili Branşı Sil";
            this.btnBransSil.UseVisualStyleBackColor = true;
            this.btnBransSil.Click += new System.EventHandler(this.btnBransSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(581, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Aktif Dersler";
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(579, 431);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(181, 25);
            this.cmbDersler.TabIndex = 9;
            // 
            // btnDersAta
            // 
            this.btnDersAta.Location = new System.Drawing.Point(579, 475);
            this.btnDersAta.Name = "btnDersAta";
            this.btnDersAta.Size = new System.Drawing.Size(159, 30);
            this.btnDersAta.TabIndex = 10;
            this.btnDersAta.Text = "Öğretmene Dersi Ata";
            this.btnDersAta.UseVisualStyleBackColor = true;
            this.btnDersAta.Click += new System.EventHandler(this.btnDersAta_Click);
            // 
            // btnDersKaldir
            // 
            this.btnDersKaldir.Location = new System.Drawing.Point(744, 475);
            this.btnDersKaldir.Name = "btnDersKaldir";
            this.btnDersKaldir.Size = new System.Drawing.Size(159, 30);
            this.btnDersKaldir.TabIndex = 10;
            this.btnDersKaldir.Text = "Atanmış Dersi Kaldır";
            this.btnDersKaldir.UseVisualStyleBackColor = true;
            this.btnDersKaldir.Click += new System.EventHandler(this.btnDersKaldir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.Location = new System.Drawing.Point(584, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Öğretmen İşlemleri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.Location = new System.Drawing.Point(781, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Branş İşlemleri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.Location = new System.Drawing.Point(580, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(282, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Öğretmene Ders Atama İşlemleri";
            // 
            // btnOgretmenDuzenle
            // 
            this.btnOgretmenDuzenle.Location = new System.Drawing.Point(580, 275);
            this.btnOgretmenDuzenle.Name = "btnOgretmenDuzenle";
            this.btnOgretmenDuzenle.Size = new System.Drawing.Size(179, 45);
            this.btnOgretmenDuzenle.TabIndex = 12;
            this.btnOgretmenDuzenle.Text = "Seçili Öğretmeni Düzenle";
            this.btnOgretmenDuzenle.UseVisualStyleBackColor = true;
            this.btnOgretmenDuzenle.Click += new System.EventHandler(this.btnOgretmenDuzenle_Click);
            // 
            // txtOgretmenAdi
            // 
            this.txtOgretmenAdi.Location = new System.Drawing.Point(580, 106);
            this.txtOgretmenAdi.Name = "txtOgretmenAdi";
            this.txtOgretmenAdi.Size = new System.Drawing.Size(180, 23);
            this.txtOgretmenAdi.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(581, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Öğretmen Adı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(581, 132);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Öğretmen Soyadı";
            // 
            // txtOgretmenSoyadi
            // 
            this.txtOgretmenSoyadi.Location = new System.Drawing.Point(580, 152);
            this.txtOgretmenSoyadi.Name = "txtOgretmenSoyadi";
            this.txtOgretmenSoyadi.Size = new System.Drawing.Size(180, 23);
            this.txtOgretmenSoyadi.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(765, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 375);
            this.label17.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Location = new System.Drawing.Point(767, 374);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(210, 10);
            this.label18.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(580, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "Aktif Branşlar";
            // 
            // cmbButunBranslar
            // 
            this.cmbButunBranslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbButunBranslar.FormattingEnabled = true;
            this.cmbButunBranslar.Location = new System.Drawing.Point(781, 50);
            this.cmbButunBranslar.Name = "cmbButunBranslar";
            this.cmbButunBranslar.Size = new System.Drawing.Size(179, 25);
            this.cmbButunBranslar.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(567, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 10);
            this.label4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(967, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 796);
            this.label9.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(28, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ders Programı Oluşturma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Seçili Öğretmenin Dersine Girdiği Sınıflar";
            // 
            // cmbGunler
            // 
            this.cmbGunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGunler.FormattingEnabled = true;
            this.cmbGunler.Location = new System.Drawing.Point(167, 588);
            this.cmbGunler.Name = "cmbGunler";
            this.cmbGunler.Size = new System.Drawing.Size(169, 25);
            this.cmbGunler.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(167, 568);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(144, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Atama Yapılacak Gün";
            // 
            // btnDersPrograminiKaydet
            // 
            this.btnDersPrograminiKaydet.Location = new System.Drawing.Point(167, 669);
            this.btnDersPrograminiKaydet.Name = "btnDersPrograminiKaydet";
            this.btnDersPrograminiKaydet.Size = new System.Drawing.Size(169, 25);
            this.btnDersPrograminiKaydet.TabIndex = 21;
            this.btnDersPrograminiKaydet.Text = "Ders Programı Oluştur";
            this.btnDersPrograminiKaydet.UseVisualStyleBackColor = true;
            this.btnDersPrograminiKaydet.Click += new System.EventHandler(this.btnDersPrograminiKaydet_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(12, 509);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(964, 10);
            this.label19.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 19);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 17);
            this.label35.TabIndex = 23;
            this.label35.Text = "Birinci Ders";
            // 
            // txtSekiz
            // 
            this.txtSekiz.Enabled = false;
            this.txtSekiz.Location = new System.Drawing.Point(325, 117);
            this.txtSekiz.Name = "txtSekiz";
            this.txtSekiz.Size = new System.Drawing.Size(100, 23);
            this.txtSekiz.TabIndex = 24;
            // 
            // txtAlti
            // 
            this.txtAlti.Enabled = false;
            this.txtAlti.Location = new System.Drawing.Point(113, 117);
            this.txtAlti.Name = "txtAlti";
            this.txtAlti.Size = new System.Drawing.Size(100, 23);
            this.txtAlti.TabIndex = 24;
            // 
            // txtBes
            // 
            this.txtBes.Enabled = false;
            this.txtBes.Location = new System.Drawing.Point(7, 117);
            this.txtBes.Name = "txtBes";
            this.txtBes.Size = new System.Drawing.Size(100, 23);
            this.txtBes.TabIndex = 24;
            // 
            // txtDort
            // 
            this.txtDort.Enabled = false;
            this.txtDort.Location = new System.Drawing.Point(324, 39);
            this.txtDort.Name = "txtDort";
            this.txtDort.Size = new System.Drawing.Size(100, 23);
            this.txtDort.TabIndex = 24;
            // 
            // txtYedi
            // 
            this.txtYedi.Enabled = false;
            this.txtYedi.Location = new System.Drawing.Point(219, 117);
            this.txtYedi.Name = "txtYedi";
            this.txtYedi.Size = new System.Drawing.Size(100, 23);
            this.txtYedi.TabIndex = 24;
            // 
            // lstOgretmenSiniflari
            // 
            this.lstOgretmenSiniflari.FormattingEnabled = true;
            this.lstOgretmenSiniflari.ItemHeight = 17;
            this.lstOgretmenSiniflari.Location = new System.Drawing.Point(28, 566);
            this.lstOgretmenSiniflari.Name = "lstOgretmenSiniflari";
            this.lstOgretmenSiniflari.Size = new System.Drawing.Size(133, 225);
            this.lstOgretmenSiniflari.TabIndex = 25;
            this.lstOgretmenSiniflari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstOgretmenSiniflari_MouseDoubleClick);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(342, 509);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 296);
            this.label22.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(112, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 23;
            this.label23.Text = "İkinci Ders";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(218, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 17);
            this.label24.TabIndex = 23;
            this.label24.Text = "Üçüncü Ders";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(324, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 17);
            this.label25.TabIndex = 23;
            this.label25.Text = "Dördüncü Ders";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 17);
            this.label26.TabIndex = 23;
            this.label26.Text = "Beşinci Ders";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(113, 97);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 17);
            this.label27.TabIndex = 23;
            this.label27.Text = "Altıncı Ders";
            // 
            // txtIki
            // 
            this.txtIki.Enabled = false;
            this.txtIki.Location = new System.Drawing.Point(112, 39);
            this.txtIki.Name = "txtIki";
            this.txtIki.Size = new System.Drawing.Size(100, 23);
            this.txtIki.TabIndex = 24;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(219, 97);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 17);
            this.label28.TabIndex = 23;
            this.label28.Text = "Yedinci Ders";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(325, 97);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 17);
            this.label29.TabIndex = 23;
            this.label29.Text = "Sekizinci Ders";
            // 
            // txtUc
            // 
            this.txtUc.Enabled = false;
            this.txtUc.Location = new System.Drawing.Point(218, 39);
            this.txtUc.Name = "txtUc";
            this.txtUc.Size = new System.Drawing.Size(100, 23);
            this.txtUc.TabIndex = 24;
            // 
            // txtBir
            // 
            this.txtBir.Enabled = false;
            this.txtBir.Location = new System.Drawing.Point(6, 39);
            this.txtBir.Name = "txtBir";
            this.txtBir.Size = new System.Drawing.Size(100, 23);
            this.txtBir.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnTemizleSekiz);
            this.groupBox1.Controls.Add(this.btnTemizleDort);
            this.groupBox1.Controls.Add(this.btnTemizleAlti);
            this.groupBox1.Controls.Add(this.btnTemizleYedi);
            this.groupBox1.Controls.Add(this.btnTemizleIki);
            this.groupBox1.Controls.Add(this.btnTemizleBes);
            this.groupBox1.Controls.Add(this.btnTemizleUc);
            this.groupBox1.Controls.Add(this.btnTemizleBir);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtBir);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtIki);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtUc);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtDort);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtBes);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.txtAlti);
            this.groupBox1.Controls.Add(this.txtYedi);
            this.groupBox1.Controls.Add(this.txtSekiz);
            this.groupBox1.Location = new System.Drawing.Point(358, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 178);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnTemizleSekiz
            // 
            this.btnTemizleSekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleSekiz.Location = new System.Drawing.Point(324, 146);
            this.btnTemizleSekiz.Name = "btnTemizleSekiz";
            this.btnTemizleSekiz.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleSekiz.TabIndex = 29;
            this.btnTemizleSekiz.Tag = "8";
            this.btnTemizleSekiz.Text = "Seçimi Sil";
            this.btnTemizleSekiz.UseVisualStyleBackColor = true;
            this.btnTemizleSekiz.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleDort
            // 
            this.btnTemizleDort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleDort.Location = new System.Drawing.Point(324, 68);
            this.btnTemizleDort.Name = "btnTemizleDort";
            this.btnTemizleDort.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleDort.TabIndex = 29;
            this.btnTemizleDort.Tag = "4";
            this.btnTemizleDort.Text = "Seçimi Sil";
            this.btnTemizleDort.UseVisualStyleBackColor = true;
            this.btnTemizleDort.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleAlti
            // 
            this.btnTemizleAlti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleAlti.Location = new System.Drawing.Point(112, 146);
            this.btnTemizleAlti.Name = "btnTemizleAlti";
            this.btnTemizleAlti.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleAlti.TabIndex = 29;
            this.btnTemizleAlti.Tag = "6";
            this.btnTemizleAlti.Text = "Seçimi Sil";
            this.btnTemizleAlti.UseVisualStyleBackColor = true;
            this.btnTemizleAlti.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleYedi
            // 
            this.btnTemizleYedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleYedi.Location = new System.Drawing.Point(218, 146);
            this.btnTemizleYedi.Name = "btnTemizleYedi";
            this.btnTemizleYedi.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleYedi.TabIndex = 29;
            this.btnTemizleYedi.Tag = "7";
            this.btnTemizleYedi.Text = "Seçimi Sil";
            this.btnTemizleYedi.UseVisualStyleBackColor = true;
            this.btnTemizleYedi.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleIki
            // 
            this.btnTemizleIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleIki.Location = new System.Drawing.Point(112, 68);
            this.btnTemizleIki.Name = "btnTemizleIki";
            this.btnTemizleIki.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleIki.TabIndex = 29;
            this.btnTemizleIki.Tag = "2";
            this.btnTemizleIki.Text = "Seçimi Sil";
            this.btnTemizleIki.UseVisualStyleBackColor = true;
            this.btnTemizleIki.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleBes
            // 
            this.btnTemizleBes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleBes.Location = new System.Drawing.Point(6, 146);
            this.btnTemizleBes.Name = "btnTemizleBes";
            this.btnTemizleBes.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleBes.TabIndex = 29;
            this.btnTemizleBes.Tag = "5";
            this.btnTemizleBes.Text = "Seçimi Sil";
            this.btnTemizleBes.UseVisualStyleBackColor = true;
            this.btnTemizleBes.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleUc
            // 
            this.btnTemizleUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleUc.Location = new System.Drawing.Point(218, 68);
            this.btnTemizleUc.Name = "btnTemizleUc";
            this.btnTemizleUc.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleUc.TabIndex = 29;
            this.btnTemizleUc.Tag = "3";
            this.btnTemizleUc.Text = "Seçimi Sil";
            this.btnTemizleUc.UseVisualStyleBackColor = true;
            this.btnTemizleUc.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // btnTemizleBir
            // 
            this.btnTemizleBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTemizleBir.Location = new System.Drawing.Point(6, 68);
            this.btnTemizleBir.Name = "btnTemizleBir";
            this.btnTemizleBir.Size = new System.Drawing.Size(100, 26);
            this.btnTemizleBir.TabIndex = 29;
            this.btnTemizleBir.Tag = "1";
            this.btnTemizleBir.Text = "Seçimi Sil";
            this.btnTemizleBir.UseVisualStyleBackColor = true;
            this.btnTemizleBir.Click += new System.EventHandler(this.btnTemizleBir_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label30.Location = new System.Drawing.Point(358, 703);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(396, 80);
            this.label30.TabIndex = 28;
            this.label30.Text = "Yukarıdaki sınıflar seçili öğretmenin seçmiş olduğunuz gün için\r\nders programını " +
    "oluşturacaktır.\r\n\r\nDers seçme işlemini tamamladıktan sonra \'Ders Programı Oluştu" +
    "r\'\r\nbutonuna tıklayınız.\r\n";
            // 
            // OgretmenIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 814);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstOgretmenSiniflari);
            this.Controls.Add(this.btnDersPrograminiKaydet);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cmbGunler);
            this.Controls.Add(this.cmbButunBranslar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtOgretmenSoyadi);
            this.Controls.Add(this.txtOgretmenAdi);
            this.Controls.Add(this.btnOgretmenDuzenle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDersKaldir);
            this.Controls.Add(this.btnDersAta);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBransSil);
            this.Controls.Add(this.cmbAktifBranslar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOgretmenListele);
            this.Controls.Add(this.btnOgretmenSil);
            this.Controls.Add(this.btnBransDuzenle);
            this.Controls.Add(this.btnBransKaydet);
            this.Controls.Add(this.btnOgretmenKaydet);
            this.Controls.Add(this.txtBransAdi);
            this.Controls.Add(this.txtSeciliOgretmenAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgvOgretmenListe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OgretmenIslemleri";
            this.Text = "Öğretmen İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgretmenListe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgretmenListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeciliOgretmenAdi;
        private System.Windows.Forms.Button btnOgretmenKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBransAdi;
        private System.Windows.Forms.ComboBox cmbAktifBranslar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOgretmenSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBransKaydet;
        private System.Windows.Forms.Button btnBransDuzenle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOgretmenListele;
        private System.Windows.Forms.Button btnBransSil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.Button btnDersAta;
        private System.Windows.Forms.Button btnDersKaldir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnOgretmenDuzenle;
        private System.Windows.Forms.TextBox txtOgretmenAdi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOgretmenSoyadi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbButunBranslar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGunler;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDersPrograminiKaydet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtSekiz;
        private System.Windows.Forms.TextBox txtAlti;
        private System.Windows.Forms.TextBox txtBes;
        private System.Windows.Forms.TextBox txtDort;
        private System.Windows.Forms.TextBox txtYedi;
        private System.Windows.Forms.ListBox lstOgretmenSiniflari;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtIki;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtUc;
        private System.Windows.Forms.TextBox txtBir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTemizleSekiz;
        private System.Windows.Forms.Button btnTemizleDort;
        private System.Windows.Forms.Button btnTemizleAlti;
        private System.Windows.Forms.Button btnTemizleYedi;
        private System.Windows.Forms.Button btnTemizleIki;
        private System.Windows.Forms.Button btnTemizleBes;
        private System.Windows.Forms.Button btnTemizleUc;
        private System.Windows.Forms.Button btnTemizleBir;
        private System.Windows.Forms.Label label30;
    }
}