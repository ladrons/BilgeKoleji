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
    public partial class DersIslemleri : Form
    {
        LessonRepository _lRep; SubLessonRepository _slRep;

        public DersIslemleri()
        {
            InitializeComponent();
        }

        #region METHODS

        public void ListLesson()
        {
            if (_lRep == null) _lRep = new LessonRepository();
            if (_slRep != null) _slRep = null;

            dgvDersListele.DataSource = _lRep.GetLessonDTO(x => new DTO.WinUI.ListLessonDTO
            {
                ID = x.ID,

                LessonName = x.LessonName,
                LessonCreatedDate = x.CreatedDate,
                LessonUpdateDate = x.ModifiedDate

            }).ToList();

            #region SutunIsimleri

            dgvDersListele.Columns[0].HeaderText = "Ana Ders Adı";
            dgvDersListele.Columns[1].HeaderText = "Oluşturulma Tarihi";
            dgvDersListele.Columns[2].HeaderText = "Güncelleme Tarihi";

            #endregion
        }
        public void ListSubLesson()
        {
            if (_slRep == null) _slRep = new SubLessonRepository();
            if (_lRep != null) _lRep = null;

            _lesson = null;

            dgvDersListele.DataSource = _slRep.GetSubLessonDTO(x => new DTO.WinUI.ListSubLessonDTO
            {
                ID = x.ID,

                SubLessonName = x.SubLessonName,
                SubLessonCode = x.SubLessonCode,

                SubLessonCreatedDate = x.CreatedDate,
                SubLessonUpdateDate = x.ModifiedDate,

                LessonName = x.Lesson.LessonName,

            }).ToList();

            #region SutunIsimleri

            dgvDersListele.Columns[0].HeaderText = "Alt Ders Adı";
            dgvDersListele.Columns[1].HeaderText = "Alt Ders Kodu";
            dgvDersListele.Columns[2].HeaderText = "Oluşturulma Tarihi";
            dgvDersListele.Columns[3].HeaderText = "Güncelleme Tarihi";
            dgvDersListele.Columns[4].HeaderText = "Ana Ders Adı";

            #endregion
        }

        public void CreateLesson(string lessonName)
        {
            try
            {
                if (lessonName != "")
                {
                    if (_lRep == null) _lRep = new LessonRepository();

                    Lesson dbLesson = _lRep.FirstOrDefault(x => x.LessonName == lessonName);

                    if (dbLesson == null)
                    {
                        Lesson lesson = new Lesson();

                        lesson.LessonName = lessonName;
                        _lRep.Add(lesson);

                        MessageBox.Show($"Ders başarılı bir şekilde oluşturuldu. Yeni dersin adı; {lesson.LessonName}");

                        ClearTxt(); ListLesson();
                    }
                    else if (dbLesson.LessonName == lessonName)
                    {
                        MessageBox.Show("Sistemde bu isimde bir ders kayıtlı.");
                        ClearTxt();
                    }
                }
                else MessageBox.Show("Lütfen oluşturmak istediğiniz dersin adını giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }
        public void CreateSubLesson(string subLessonName, string subLessonCode)
        {
            // Burada yaratılacak olan ders 'alt ders' olacağı için seçili olan bir 'ana ders' olmalı..

            try
            {
                if (_lesson == null)
                {
                    MessageBox.Show("Lütfen alt dersin ekleneceği ana dersi seçiniz.");
                    return;
                }
                else if (_lesson != null)
                {
                    if (_slRep == null) _slRep = new SubLessonRepository();

                    if (subLessonName != "" && subLessonCode != "")
                    {
                        SubLesson dbSubLesson = _slRep.FirstOrDefault(x => x.SubLessonName == subLessonName);

                        if (dbSubLesson == null)
                        {
                            SubLesson subLesson = new SubLesson();

                            subLesson.LessonID = _lesson.ID;

                            subLesson.SubLessonName = subLessonName;
                            subLesson.SubLessonCode = subLessonCode;

                            _slRep.Add(subLesson);
                            MessageBox.Show($"Alt ders başarılı bir şekilde oluşturuldu. Oluşturulan alt dersin adı; {subLesson.SubLessonName}");

                            ClearTxt(); ListSubLesson();

                            _lesson = null;
                        }
                        else if (dbSubLesson.SubLessonName == subLessonName || dbSubLesson.SubLessonCode == subLessonCode)
                        {
                            MessageBox.Show("Sistemde bu bilgileri içeren bir alt ders bulunmakta.");
                            ClearTxt();
                        }
                    }
                    else MessageBox.Show("Lütfen kaydedilecek olan alt dersin adını ve kodunu giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }

        public void DeleteLesson()
        {
            try
            {
                if (_lesson != null)
                {
                    if (_lesson.SubLessons.Count == 0)
                    {
                        _lRep.Delete(_lesson);
                        MessageBox.Show("Seçili ders başarılı bir şekilde silinmiştir.");

                        ClearTxt(); 
                        dgvDersListele.ClearSelection();

                        _lesson = null;
                    }
                    else if (_lesson.SubLessons.Count > 0)
                    {
                        foreach (SubLesson item in _lesson.SubLessons)
                        {
                            if (item.Status != ENTITIES.Enums.DataStatus.Deleted)
                            {
                                MessageBox.Show("Lütfen önce bütün alt dersleri siliniz.");

                                ClearTxt();
                                _lesson = null;

                                return;
                            }

                            _lRep.Delete(_lesson);
                            MessageBox.Show("Seçili ders başarılı bir şekilde silinmiştir.");

                            ClearTxt(); 

                            _lesson = null;
                        }
                    }
                    else MessageBox.Show("Lütfen önce ilgili derse ait alt dersleri siliniz.");
                    return;
                }
                else MessageBox.Show("Lütfen silinmesini istediğiniz dersi seçiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }
        public void DeleteSubLesson()
        {
            try
            {
                if (_subLesson != null)
                {
                    _slRep.Delete(_subLesson);
                    MessageBox.Show("Seçili alt ders başarılı bir şekilde silinmiştir.");

                    ListSubLesson(); 
                    ClearTxt(); ListSubLesson();

                    _subLesson = null;

                }
                else MessageBox.Show("Lütfen silinmesini istediğiniz alt dersi seçiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }

        public void UpdateLesson(string newLessonName)
        {
            try
            {
                if (_lesson != null)
                {
                    if (newLessonName != "")
                    {
                        Lesson dbLesson = _lRep.FirstOrDefault(x => x.LessonName == newLessonName);

                        if (dbLesson == null)
                        {
                            _lesson.LessonName = newLessonName;
                            _lRep.Update(_lesson);

                            MessageBox.Show("Seçtiğiniz ders başarılı bir şekilde güncellenmiştir.");
                            ClearTxt(); ListLesson();

                            _lesson = null;
                        }
                        else if (dbLesson.LessonName == newLessonName) 
                        {
                            MessageBox.Show("Sistemde bu isimde bir ders kayıtlı.");
                            ClearTxt();
                        }
                    }
                    else MessageBox.Show("Lütfen güncellemek istediğiniz dersin yeni bilgilerini giriniz.");
                }
                else MessageBox.Show("Lütfen güncellemek istediğiniz dersi seçiniz.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }
        public void UpdateSubLesson(string newSubLessonName, string newSubLessonCode)
        {
            try
            {
                if (_subLesson != null)
                {
                    if (newSubLessonName != "" && newSubLessonCode != "")
                    {
                        SubLesson dbSubLesson = _slRep.FirstOrDefault(x => x.SubLessonName == newSubLessonName);

                        if (dbSubLesson == null)
                        {
                            _subLesson.SubLessonName = newSubLessonName;
                            _subLesson.SubLessonCode = newSubLessonCode;

                            _slRep.Update(_subLesson);

                            MessageBox.Show("Seçtiğiniz alt ders baraşılı bir şekilde güncellenmiştir.");
                            ClearTxt(); ListSubLesson();

                            _subLesson = null;
                        }
                        else if (dbSubLesson.SubLessonName == newSubLessonName) 
                        {
                            MessageBox.Show("Sistemde bu isimde bir alt ders bulunmakta.");
                            ClearTxt();
                        }
                    }
                    else MessageBox.Show("Lütfen güncellemek istediğiniz alt dersin yeni bilgilerini giriniz.");
                }
                else MessageBox.Show("Lütfen güncellemek istediğiniz alt dersi seçiniz.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }

        public void ClearTxt()
        {
            txtAnaDersAdi.Text = txtDersKodu.Text = txtAltDersAdi.Text = string.Empty;
        }

        #endregion

        private void btnAnaDersler_Click(object sender, EventArgs e)
        {
            ListLesson(); ClearTxt();

            dgvDersListele.ClearSelection();

            txtAnaDersAdi.ReadOnly = false;
        }
        private void btnAltDersler_Click(object sender, EventArgs e)
        {
            ListSubLesson(); ClearTxt();

            dgvDersListele.ClearSelection();

            txtAnaDersAdi.ReadOnly = true;
        }

        private void btnAnaDersEkle_Click(object sender, EventArgs e)
        {
            CreateLesson(txtAnaDersAdi.Text);
        }
        private void btnAltDersEkle_Click(object sender, EventArgs e)
        {
            CreateSubLesson(txtAltDersAdi.Text, txtDersKodu.Text);
        }

        private void btnDersiSil_Click(object sender, EventArgs e)
        {
            if (_lesson != null)
            {
                DeleteLesson(); dgvDersListele.ClearSelection();
                return;
            }
            else if (_subLesson != null)
            {
                DeleteSubLesson(); dgvDersListele.ClearSelection();
            }
            else MessageBox.Show("Lütfen önce dersleri veya alt dersleri listeleyin ardından silmek istediğiniz derse tıklayın.");
        }

        private void btnDersiDuzenle_Click(object sender, EventArgs e)
        {
            if (_lesson != null)
            {
                UpdateLesson(txtAnaDersAdi.Text);
            }
            else if (_subLesson != null)
            {
                UpdateSubLesson(txtAltDersAdi.Text, txtDersKodu.Text);
            }
            else MessageBox.Show("Lütfen önce güncellemek istediğiniz dersi veya alt dersi seçiniz.");
            return;
        }

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ 

        Lesson _lesson; SubLesson _subLesson;
        private void dgvDersListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_lRep != null)
            {
                _lesson = _lRep.Find(Convert.ToInt32(dgvDersListele.CurrentRow.Cells[3].Value));

                txtAnaDersAdi.Text = _lesson.LessonName;

                _subLesson = null;
            }
            else if (_slRep != null)
            {
                _subLesson = _slRep.Find(Convert.ToInt32(dgvDersListele.CurrentRow.Cells[5].Value));

                txtAnaDersAdi.Text = _subLesson.Lesson.LessonName;
                txtAltDersAdi.Text = _subLesson.SubLessonName;
                txtDersKodu.Text = _subLesson.SubLessonCode;

                _lesson = null;
            }
        }
    }
}