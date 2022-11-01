namespace Project.WinUI
{
    partial class DersAtama
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
            this.dgvSinifListesi = new System.Windows.Forms.DataGridView();
            this.cmbAnaDersler = new System.Windows.Forms.ComboBox();
            this.lstOgretmenler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtamaYap = new System.Windows.Forms.Button();
            this.lblSeciliSinif = new System.Windows.Forms.Label();
            this.lblSeciliAnaDers = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSeciliOgretmen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinifListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıflar";
            // 
            // dgvSinifListesi
            // 
            this.dgvSinifListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSinifListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinifListesi.Location = new System.Drawing.Point(25, 53);
            this.dgvSinifListesi.Name = "dgvSinifListesi";
            this.dgvSinifListesi.Size = new System.Drawing.Size(262, 462);
            this.dgvSinifListesi.TabIndex = 1;
            this.dgvSinifListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinifListesi_CellClick);
            // 
            // cmbAnaDersler
            // 
            this.cmbAnaDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnaDersler.FormattingEnabled = true;
            this.cmbAnaDersler.Location = new System.Drawing.Point(294, 53);
            this.cmbAnaDersler.Name = "cmbAnaDersler";
            this.cmbAnaDersler.Size = new System.Drawing.Size(248, 25);
            this.cmbAnaDersler.TabIndex = 2;
            this.cmbAnaDersler.SelectedIndexChanged += new System.EventHandler(this.cmbAnaDersler_SelectedIndexChanged);
            // 
            // lstOgretmenler
            // 
            this.lstOgretmenler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstOgretmenler.FormattingEnabled = true;
            this.lstOgretmenler.ItemHeight = 17;
            this.lstOgretmenler.Location = new System.Drawing.Point(294, 108);
            this.lstOgretmenler.Name = "lstOgretmenler";
            this.lstOgretmenler.Size = new System.Drawing.Size(248, 208);
            this.lstOgretmenler.TabIndex = 3;
            this.lstOgretmenler.SelectedIndexChanged += new System.EventHandler(this.lstOgretmenler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(293, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ana Dersler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(293, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seçili Derse Atanmış Öğretmenler";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 10);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 509);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(548, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 519);
            this.label6.TabIndex = 6;
            // 
            // btnAtamaYap
            // 
            this.btnAtamaYap.Location = new System.Drawing.Point(294, 322);
            this.btnAtamaYap.Name = "btnAtamaYap";
            this.btnAtamaYap.Size = new System.Drawing.Size(248, 35);
            this.btnAtamaYap.TabIndex = 7;
            this.btnAtamaYap.Text = "Atama İşlemini Gerçekleştir";
            this.btnAtamaYap.UseVisualStyleBackColor = true;
            this.btnAtamaYap.Click += new System.EventHandler(this.btnAtamaYap_Click);
            // 
            // lblSeciliSinif
            // 
            this.lblSeciliSinif.AutoSize = true;
            this.lblSeciliSinif.Location = new System.Drawing.Point(293, 370);
            this.lblSeciliSinif.Name = "lblSeciliSinif";
            this.lblSeciliSinif.Size = new System.Drawing.Size(13, 17);
            this.lblSeciliSinif.TabIndex = 8;
            this.lblSeciliSinif.Text = "-";
            // 
            // lblSeciliAnaDers
            // 
            this.lblSeciliAnaDers.AutoSize = true;
            this.lblSeciliAnaDers.Location = new System.Drawing.Point(293, 387);
            this.lblSeciliAnaDers.Name = "lblSeciliAnaDers";
            this.lblSeciliAnaDers.Size = new System.Drawing.Size(13, 17);
            this.lblSeciliAnaDers.TabIndex = 8;
            this.lblSeciliAnaDers.Text = "-";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(9, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(551, 10);
            this.label15.TabIndex = 6;
            // 
            // lblSeciliOgretmen
            // 
            this.lblSeciliOgretmen.AutoSize = true;
            this.lblSeciliOgretmen.Location = new System.Drawing.Point(293, 404);
            this.lblSeciliOgretmen.Name = "lblSeciliOgretmen";
            this.lblSeciliOgretmen.Size = new System.Drawing.Size(13, 17);
            this.lblSeciliOgretmen.TabIndex = 9;
            this.lblSeciliOgretmen.Text = "-";
            // 
            // DersAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 537);
            this.Controls.Add(this.lblSeciliOgretmen);
            this.Controls.Add(this.lblSeciliAnaDers);
            this.Controls.Add(this.lblSeciliSinif);
            this.Controls.Add(this.btnAtamaYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstOgretmenler);
            this.Controls.Add(this.cmbAnaDersler);
            this.Controls.Add(this.dgvSinifListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DersAtama";
            this.Text = "DersAtama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinifListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinifListesi;
        private System.Windows.Forms.ComboBox cmbAnaDersler;
        private System.Windows.Forms.ListBox lstOgretmenler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtamaYap;
        private System.Windows.Forms.Label lblSeciliSinif;
        private System.Windows.Forms.Label lblSeciliAnaDers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSeciliOgretmen;
    }
}