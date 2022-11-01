namespace Project.WinUI
{
    partial class OgrenciAtama
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
            this.dgvOgrenciListele = new System.Windows.Forms.DataGridView();
            this.btnOgrenciAta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSiniflar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciListele
            // 
            this.dgvOgrenciListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOgrenciListele.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOgrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciListele.Location = new System.Drawing.Point(29, 23);
            this.dgvOgrenciListele.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOgrenciListele.Name = "dgvOgrenciListele";
            this.dgvOgrenciListele.ReadOnly = true;
            this.dgvOgrenciListele.Size = new System.Drawing.Size(462, 574);
            this.dgvOgrenciListele.TabIndex = 0;
            this.dgvOgrenciListele.TabStop = false;
            this.dgvOgrenciListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciListele_CellClick);
            // 
            // btnOgrenciAta
            // 
            this.btnOgrenciAta.Location = new System.Drawing.Point(351, 605);
            this.btnOgrenciAta.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciAta.Name = "btnOgrenciAta";
            this.btnOgrenciAta.Size = new System.Drawing.Size(140, 43);
            this.btnOgrenciAta.TabIndex = 0;
            this.btnOgrenciAta.Text = "Atamayı Gerçekleştir";
            this.btnOgrenciAta.UseVisualStyleBackColor = true;
            this.btnOgrenciAta.Click += new System.EventHandler(this.btnOgrenciAta_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 663);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 10);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(498, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 663);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 10);
            this.label4.TabIndex = 0;
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiniflar.FormattingEnabled = true;
            this.cmbSiniflar.Location = new System.Drawing.Point(30, 630);
            this.cmbSiniflar.MaxDropDownItems = 5;
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Size = new System.Drawing.Size(219, 25);
            this.cmbSiniflar.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrencinin Atanacak Sınıfı Seçiniz";
            // 
            // OgrenciAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 682);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSiniflar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOgrenciAta);
            this.Controls.Add(this.dgvOgrenciListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(537, 721);
            this.MinimumSize = new System.Drawing.Size(537, 721);
            this.Name = "OgrenciAtama";
            this.Text = "OgrenciAtama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciListele;
        private System.Windows.Forms.Button btnOgrenciAta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSiniflar;
        private System.Windows.Forms.Label label7;
    }
}