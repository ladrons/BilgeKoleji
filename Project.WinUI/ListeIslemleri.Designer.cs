namespace Project.WinUI
{
    partial class ListeIslemleri
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btnListeleTakdir = new System.Windows.Forms.Button();
            this.btnListeleTesekkur = new System.Windows.Forms.Button();
            this.btnListIlisikKesilen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(12, 12);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(705, 589);
            this.dgvListe.TabIndex = 0;
            // 
            // btnListeleTakdir
            // 
            this.btnListeleTakdir.Location = new System.Drawing.Point(12, 607);
            this.btnListeleTakdir.Name = "btnListeleTakdir";
            this.btnListeleTakdir.Size = new System.Drawing.Size(157, 43);
            this.btnListeleTakdir.TabIndex = 1;
            this.btnListeleTakdir.Text = "Takdir Belgesi Alan Öğrencileri Listele";
            this.btnListeleTakdir.UseVisualStyleBackColor = true;
            this.btnListeleTakdir.Click += new System.EventHandler(this.btnListeleTakdir_Click);
            // 
            // btnListeleTesekkur
            // 
            this.btnListeleTesekkur.Location = new System.Drawing.Point(175, 607);
            this.btnListeleTesekkur.Name = "btnListeleTesekkur";
            this.btnListeleTesekkur.Size = new System.Drawing.Size(157, 43);
            this.btnListeleTesekkur.TabIndex = 1;
            this.btnListeleTesekkur.Text = "Teşekkür Belgesi Alan Öğrencileri Listele";
            this.btnListeleTesekkur.UseVisualStyleBackColor = true;
            this.btnListeleTesekkur.Click += new System.EventHandler(this.btnListeleTesekkur_Click);
            // 
            // btnListIlisikKesilen
            // 
            this.btnListIlisikKesilen.Location = new System.Drawing.Point(397, 607);
            this.btnListIlisikKesilen.Name = "btnListIlisikKesilen";
            this.btnListIlisikKesilen.Size = new System.Drawing.Size(157, 43);
            this.btnListIlisikKesilen.TabIndex = 1;
            this.btnListIlisikKesilen.Text = "Okul İle İlişkisi Kesilmiş Olan Öğrencileri Listele";
            this.btnListIlisikKesilen.UseVisualStyleBackColor = true;
            this.btnListIlisikKesilen.Click += new System.EventHandler(this.btnListIlisikKesilen_Click);
            // 
            // ListeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 663);
            this.Controls.Add(this.btnListIlisikKesilen);
            this.Controls.Add(this.btnListeleTesekkur);
            this.Controls.Add(this.btnListeleTakdir);
            this.Controls.Add(this.dgvListe);
            this.Name = "ListeIslemleri";
            this.Text = "ListeIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnListeleTakdir;
        private System.Windows.Forms.Button btnListeleTesekkur;
        private System.Windows.Forms.Button btnListIlisikKesilen;
    }
}