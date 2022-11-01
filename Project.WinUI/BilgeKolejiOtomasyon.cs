using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class BilgeKolejiOtomasyon : Form
    {
        SemesterRepository _semesterRep; YearRepository _yearRep;

        public BilgeKolejiOtomasyon()
        {
            InitializeComponent();

            CheckActiveSemester();
        }

        private void BilgeKolejiOtomasyon_Load(object sender, EventArgs e)
        {
            //ToolTip Aciklama = new ToolTip();

            //Aciklama.SetToolTip(btnOgrenciKayitForm, "Öğrenci kayıt işlemi için gerekli olan formu açar");
            //Aciklama.ToolTipTitle = "Bilgilendirme";

            //ToDo: Butonlara Tooltipler eklenecek (Düşük Öncelik)
        }

        #region METHODS

        public void CheckActiveSemester()
        {
            if (_semesterRep == null) _semesterRep = new SemesterRepository();

            Semester activeSemester = _semesterRep.Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).FirstOrDefault();

            if (activeSemester != null)
            {
                if (activeSemester.EndingDate <= DateTime.Now)
                {
                    _semesterRep.Delete(activeSemester);

                    if (activeSemester.SemesterStatus == ENTITIES.Enums.SemesterStatus.Autumn)
                    {
                        chbGuzDonem.Enabled = false;
                    }
                    else
                    {
                        chbBaharDonem.Enabled = false;

                        if (_yearRep == null) _yearRep = new YearRepository();

                        Year activeYear = _yearRep.GetLastData();
                        _yearRep.Delete(activeYear);
                    }

                    MessageBox.Show("Aktif dönemin bitiş tarihine ulaşılmıştır. Lütfen işlem gerçekleştirebilmek için yeni bir dönem yaratın.");
                    btnDonemOlustur.Enabled = true;
                    return;
                }

                ActiveButtons(); txtDonemAdi.Text = activeSemester.SemesterName;

                lblBaslangicTarihi.Text = $"Dönem Başlangıç Tarihi: {activeSemester.StartingDate.ToShortDateString()}";
                lblBitisTarihi.Text = $"Dönem Bitiş Tarihi: {activeSemester.EndingDate.ToShortDateString()}";

                if (activeSemester.SemesterStatus == ENTITIES.Enums.SemesterStatus.Spring)
                {
                    btnOgrenciKayitForm.Enabled = false;
                    btnOgrenciAtama.Enabled = false;
                    btnDersAta.Enabled = false;
                }
                btnDonemOlustur.Enabled = false;
            }
            else
            {
                lblAktifDonemBilgisi.Text = $"Şuan da aktif dönem bulunmamaktadır\nLütfen önce dönem oluşturunuz.";
                btnDonemOlustur.Enabled = true;

                if (_yearRep == null) _yearRep = new YearRepository();
                Year activeYear = _yearRep.GetLastData();

                if (activeYear != null)
                {
                    chbGuzDonem.Enabled = true; chbBaharDonem.Enabled = true;
                }
                else
                {
                    chbBaharDonem.Enabled = false;
                }
            }
        }
        Year _newYear;
        public void CreateSemester()
        {
            if (_yearRep == null) _yearRep = new YearRepository();

            Semester newSemester = new Semester();

            if (chbBaharDonem.Checked && chbGuzDonem.Checked)
            {
                MessageBox.Show("Bahar ve Güz dönemleri aynı anda seçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chbBaharDonem.Checked = chbGuzDonem.Checked = false;

                return;
            }
            else if (chbGuzDonem.Checked)
            {
                _newYear = new Year();

                _newYear.YearName = $"{dtpBaslangicTarihi.Value.Year.ToString().Substring(2)} - {dtpBitisTarihi.Value.Year.ToString().Substring(2)} Yılı";

                newSemester.SemesterName = $"{_newYear.YearName} Güz Dönemi";
                newSemester.SemesterStatus = ENTITIES.Enums.SemesterStatus.Autumn;

            }
            else if (chbBaharDonem.Checked)
            {
                Year activeYear = _yearRep.GetLastData();

                if (activeYear == null)
                {
                    MessageBox.Show("Şuan da aktif bir yıl bulunmamaktadır. Lütfen güz dönemi seçerek işleme devam ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                newSemester.SemesterName = $"{activeYear.YearName} Bahar Dönemi";
                newSemester.SemesterStatus = ENTITIES.Enums.SemesterStatus.Spring;
            }
            else
            {
                MessageBox.Show("Lütfen 'Güz veya Bahar' dönemlerinden birini işaretleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpBaslangicTarihi.Value >= DateTime.Now)
            {
                newSemester.StartingDate = dtpBaslangicTarihi.Value.Date;

                if (dtpBitisTarihi.Value > newSemester.StartingDate)
                {
                    newSemester.EndingDate = dtpBitisTarihi.Value.Date;

                    if (_newYear != null) _yearRep.Add(_newYear);
                    _semesterRep.Add(newSemester);

                    txtDonemAdi.Text = newSemester.SemesterName;
                    ActiveButtons();

                    lblAktifDonemBilgisi.Text = String.Empty;
                    chbBaharDonem.Checked = chbGuzDonem.Checked = false;

                    MessageBox.Show($"Dönem oluşturulma işlemi başarılı bir şekilde gerçekleştirildi.", "İşlem Gerçekleştirildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CheckActiveSemester();
                }
                else { MessageBox.Show("Dönem bitiş tarihi dönemin başlangıç tarihinden önce olamaz. Lütfen başka bir tarih seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Dönem başlangıç tarihi bugünün tarihinden önce olamaz. Lütfen ileri bir tarih seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //--\\ //--\\

        public void ActiveButtons()
        {
            btnMezuniyetIslemleri.Enabled = true;
            btnDersAta.Enabled = true;
            btnOgretmenBrans.Enabled = true;
            btnDersEkleDuzenle.Enabled = true;
            btnOgrenciIslemleri.Enabled = true;
            btnOgrenciAtama.Enabled = true;
            btnOgrenciKayitForm.Enabled = true;
        }

        #endregion

        private void btnDonemOlustur_Click(object sender, EventArgs e)
        {
            CreateSemester();
        }
        private void btnOgrenciKayitForm_Click(object sender, EventArgs e)
        {
            OgrenciKayit ogrenciKayit = new OgrenciKayit();
            ogrenciKayit.ShowDialog();
        }
        private void btnOgrenciAtama_Click(object sender, EventArgs e)
        {
            OgrenciAtama ogrenciAtama = new OgrenciAtama();
            ogrenciAtama.ShowDialog();
        }
        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            OgreniIslemleri ogrenciIslemleri = new OgreniIslemleri();
            ogrenciIslemleri.ShowDialog();
        }
        private void btnDersEkleDuzenle_Click(object sender, EventArgs e)
        {
            DersIslemleri dersIslemleri = new DersIslemleri();
            dersIslemleri.ShowDialog();
        }
        private void btnOgretmenBrans_Click(object sender, EventArgs e)
        {
            OgretmenIslemleri ogretmenIslemleri = new OgretmenIslemleri();
            ogretmenIslemleri.ShowDialog();
        }
        private void btnDersAta_Click(object sender, EventArgs e)
        {
            DersAtama dersAtama = new DersAtama();
            dersAtama.ShowDialog();
        }
        private void btnMezuniyetIslemleri_Click(object sender, EventArgs e)
        {
            MezuniyetIslemleri mezuniyetIslemleri = new MezuniyetIslemleri();
            mezuniyetIslemleri.ShowDialog();
        }
        private void btnListeler_Click(object sender, EventArgs e)
        {
            ListeIslemleri listeIslemleri = new ListeIslemleri();
            listeIslemleri.ShowDialog();
        }
    }
}
