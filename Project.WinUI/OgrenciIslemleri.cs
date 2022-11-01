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
    //ToDo: Seçili öğrencinin kaç gün devamsızlık yaptığını gösteren bir tablo yapılabilir (Düşük Öncelik)
    //ToDo: Girilen notun düzenlenmesi için bir işlem yapılabilir (Düşük Öncelik)

    public partial class OgreniIslemleri : Form
    {
        StudentRepository _studentRep; AbsenteeismRepository _absenteeismRep; LessonRepository _lessonRep;
        ClassroomRepository _classroomRep; SemesterRepository _semesterRep; ExamGradeRepository _examGradeRep;

        LessonInClassroomRepository _lessonInClassroomRep;
        public OgreniIslemleri()
        {
            InitializeComponent();

            ListBranch();

            DeSelectComboBox();
        }

        #region METHODS

        public void LessonOfTheClass() //CHECK 
        {
            if (_lessonInClassroomRep == null) _lessonInClassroomRep = new LessonInClassroomRepository(); //Instance kontrol.

            Classroom classroom = cmbSubeler.SelectedItem as Classroom; //Seçili olan sınıfı bir değişkene atıyorum.

            List<Lesson> lessons = new List<Lesson>(); //Daha sonra kullanmak için bir Lesson list oluşturuyorum.

            if(classroom != null) //Seçili bir sınıf var ise;
            {
                List<LessonInClassroom> licList = _lessonInClassroomRep.Where(x => x.ClassroomID == classroom.ID).ToList(); //Seçili sınıfa atanmış bütün dersleri bulup bir list'de topluyorum.

                foreach (LessonInClassroom item in licList) //Topladığım verilerde dönüyorum.
                {
                    lessons.Add(item.Lesson); //Her denk gelen verinin Lesson'ını daha önce oluşturmuş olduğum list'e atıyorum.
                }
            }
            cmbDersler.DataSource = lessons.ToList(); //Cmb'a atıyorum.
        }
        public void ListBranch() //CHECK 
        {
            if (_classroomRep == null) _classroomRep = new ClassroomRepository();

            _classroomRep = new ClassroomRepository();

            cmbSubeler.DataSource = _classroomRep.GetActives();
        }
        public void ListBranchStudent() //ToDo: Adı düzeltilecek. 
        {
            if (_studentRep == null) _studentRep = new StudentRepository();

            if (cmbSubeler.SelectedIndex > -1)
            {
                Classroom classroom = cmbSubeler.SelectedItem as Classroom;

                dgvListStudent.DataSource = _studentRep.Where(x => x.ClassroomID == classroom.ID && x.Status != ENTITIES.Enums.DataStatus.Deleted).Select(x => new DTO.WinUI.StudentDTO
                {
                    SchoolNumber = x.SchoolNumber,
                    StudentName = $"{x.Firstname} {x.Lastname}",
                    Gender = x.Gender,
                    Class = x.Classroom.Class,
                    Branch = x.Classroom.Section

                }).ToList();

                #region SutunIsimleri

                dgvListStudent.Columns[0].HeaderText = "Okul Numarası";
                dgvListStudent.Columns[1].HeaderText = "İsim Soyisim";
                dgvListStudent.Columns[2].HeaderText = "Sınıf Numarası";
                dgvListStudent.Columns[3].HeaderText = "Şube Kodu";
                dgvListStudent.Columns[4].HeaderText = "Cinsiyet";

                #endregion
            }
            else { MessageBox.Show("Lütfen önce şube seçimi yapınız."); return; }
        }

        public void AddAbsences() //CHECK 
        {
            try
            {
                if (_student != null)
                {
                    if (_absenteeismRep == null) _absenteeismRep = new AbsenteeismRepository();

                    CreateAbsence();
                }
                else MessageBox.Show("Lütfen işlem yapılacak öğrenciyi seçiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATA {ex.Message}");
            }
        }
        public void CreateAbsence() //CHECK 
        {
            Absenteeism absenteeism = new Absenteeism(); // Absenteeism'den instance alıyoruz.

            absenteeism.StartingDate = dtpBaslangicGunu.Value.Date; //Geçmiş tarihli veri girilmesine bilerek izin verilmiştir.

            if (dtpBitisGunu.Value < absenteeism.StartingDate) { MessageBox.Show("Rapor bitiş tarihi raporun başlangıç tarihinden sonra olmalıdır."); return; }

            absenteeism.EndingDate = dtpBitisGunu.Value.Date;

            if (absenteeism.StartingDate != null && absenteeism.EndingDate != null)
            {
                TimeSpan timeSpan = absenteeism.EndingDate - absenteeism.StartingDate; //TimeSpan ile 2 tarih arasındaki farkı buluyoruz.

                absenteeism.AbsencesCount = Convert.ToInt32(timeSpan.TotalDays) + 1; // Seçili günü 0 olarak sayıyor. Bunu engellemek için +1 veriyoruz.

                //Alt kısımda öğrencinin devamsızlık nedeni ile ilgili detaylı bilgi alıyoruz (Raporlu mu, nöbetçi mi vb)
                if (chbNobetci.Checked && chbRaporlu.Checked)
                {
                    MessageBox.Show("Raporlu / Nöbetçi seçenekleri aynı anda seçilerek işlem yapılamaz.");

                    chbNobetci.Checked = chbRaporlu.Checked = false;
                    return;
                }

                else if (chbRaporlu.Checked)
                {
                    absenteeism.Description = $"{_student.Firstname} İsimli öğrenci {absenteeism.StartingDate.ToShortDateString()} - {absenteeism.EndingDate.ToShortDateString()} Tarihleri arasında raporludur.";
                    absenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Excused;
                }
                else if (chbNobetci.Checked)
                {
                    absenteeism.Description = $"{_student.Firstname} İsimli öğrenci {absenteeism.StartingDate.ToShortDateString()} - {absenteeism.EndingDate.ToShortDateString()} Tarihleri arasında nöbetçidir.";
                    absenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Excused;
                }
                else
                {
                    absenteeism.Description = $"{_student.Firstname} İsimli öğrenci {absenteeism.StartingDate.ToShortDateString()} - {absenteeism.EndingDate.ToShortDateString()} Tarihleri arasında okula gelmemiştir.";
                    absenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Unexcused;
                }

                DialogResult confirmAbsences = MessageBox.Show($"{absenteeism.Description}\nBu devamsızlık verisini sisteme kaydetmek istiyor musunuz?", "Devamsızlık Bilgisi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmAbsences == DialogResult.OK)
                {
                    if (_absenteeismRep == null) _absenteeismRep = new AbsenteeismRepository();

                    absenteeism.DataEntryPerson = "Sistem";

                    absenteeism.StudentID = _student.ID;
                    _absenteeismRep.Add(absenteeism);

                    _student.Absenteeisms.Add(absenteeism);

                    _student = null; dgvListStudent.ClearSelection();
                    chbNobetci.Checked = chbRaporlu.Checked = false;
                    dtpBaslangicGunu.Value = dtpBitisGunu.Value = DateTime.Now;
                    txtOgrenciAdi.Text = "";

                    MessageBox.Show("Devamsızlık işlemi başarılı bir şekilde sisteme kaydedilmiştir.");
                }
                else
                {
                    MessageBox.Show("Devamsızlık kaydı iptal edilmiştir.");

                    _student = null; dgvListStudent.ClearSelection();
                    chbNobetci.Checked = chbRaporlu.Checked = false;
                    dtpBaslangicGunu.Value = dtpBitisGunu.Value = DateTime.Now;
                }
            }
            else { MessageBox.Show("Lütfen tarih seçiniz."); return; }
        }

        public void AddExamGrade() //CHECK 
        {
            if (_student != null)
            {
                if (cmbDersler.SelectedIndex > -1)
                {
                    Lesson selectedLesson = cmbDersler.SelectedItem as Lesson;

                    if (txtDersNotu.Text == "")
                    {
                        MessageBox.Show("Lütfen geçerli bir not girişi yapınız");

                        txtDersNotu.Text = "";
                        return;
                    }


                    if (_semesterRep == null) _semesterRep = new SemesterRepository();
                    Semester selectedSemester = _semesterRep.GetLastData(); //Aktif olan dönem bilgisini alıyoruz.

                    if (_examGradeRep == null) _examGradeRep = new ExamGradeRepository();
                    ExamGrade updateExamGrade = _examGradeRep.FirstOrDefault(x => x.StudentID == _student.ID && x.LessonName == selectedLesson.LessonName && x.SemesterID == selectedSemester.ID); // Sistemde daha önce not girişi var mı kontrol ediyoruz. 

                    if (rdbBirinciSinav.Checked)
                    {
                        if (updateExamGrade == null)
                        {
                            ExamGrade examGrade = new ExamGrade();

                            examGrade.StudentID = _student.ID;
                            examGrade.SemesterID = selectedSemester.ID;
                            examGrade.LessonName = selectedLesson.LessonName;

                            if (CheckExamCount(Convert.ToInt32(txtDersNotu.Text)) == true)
                            {
                                examGrade.FirstResult = Convert.ToInt32(txtDersNotu.Text);

                                _examGradeRep.Add(examGrade);
                                _student.ExamGrades.Add(examGrade);

                                MessageBox.Show($"{_student.Firstname} isimli öğrencinin {selectedLesson.LessonName} dersine ait 1.Sınav notu {examGrade.FirstResult} olarak sisteme kaydedilmiştir.");

                                _student = null; dgvListStudent.ClearSelection();
                                rdbBirinciSinav.Checked = false;
                                txtOgrenciAdi.Text = txtDersNotu.Text = String.Empty;
                                cmbDersler.SelectedIndex = -1;
                            }
                            return;
                        }
                        else { MessageBox.Show($"{_student.Firstname} İsimli öğrencinin sistemde {selectedLesson.LessonName} dersine ait 1.sınav notu bulunmaktadır."); rdbBirinciSinav.Checked = false; }
                    }
                    else if (rdbIkinciSinav.Checked)
                    {
                        if (updateExamGrade != null)
                        {
                            if (updateExamGrade.SecondResult == null)
                            {
                                if (CheckExamCount(Convert.ToInt32(txtDersNotu.Text)) == true)
                                {
                                    updateExamGrade.SecondResult = Convert.ToInt32(txtDersNotu.Text);

                                    _examGradeRep.Update(updateExamGrade);

                                    MessageBox.Show($"{_student.Firstname} isimli öğrencinin {selectedLesson.LessonName} dersine ait 2.Sınav notu {updateExamGrade.SecondResult} olarak sisteme kaydedilmiştir.");

                                    _student = null; dgvListStudent.ClearSelection();
                                    rdbIkinciSinav.Checked = false;
                                    txtOgrenciAdi.Text = txtDersNotu.Text = String.Empty;
                                    cmbDersler.SelectedIndex = -1;
                                }
                                return;
                            }
                            else { MessageBox.Show($"{_student.Firstname} isimli öğrencinin {selectedLesson.LessonName} dersine ait 2.sınav notu bulunmaktadır."); rdbIkinciSinav.Checked = false; }
                        }
                        else { MessageBox.Show($"{_student.Firstname} isimli öğrencinin sistemde 1.sınav notu bulunmamaktadır. Lütfen önce 1.sınav notu girişini tamamlayınız."); rdbIkinciSinav.Checked = false; }
                    }
                    else if (rdbUcuncuSinav.Checked)
                    {
                        if (updateExamGrade != null)
                        {
                            if (updateExamGrade.SecondResult != null)
                            {
                                if (updateExamGrade.ThirdResult == null)
                                {
                                    if (CheckExamCount(Convert.ToInt32(txtDersNotu.Text)) == true)
                                    {
                                        updateExamGrade.ThirdResult = Convert.ToInt32(txtDersNotu.Text);

                                        _examGradeRep.Update(updateExamGrade);

                                        MessageBox.Show($"{_student.Firstname} isimli öğrencinin {selectedLesson.LessonName} dersine ait 3.Sınav notu {updateExamGrade.ThirdResult} olarak sisteme kaydedilmiştir.");

                                        _student = null; dgvListStudent.ClearSelection();
                                        rdbUcuncuSinav.Checked = false;
                                        txtOgrenciAdi.Text = txtDersNotu.Text = String.Empty;
                                        cmbDersler.SelectedIndex = -1;
                                    }
                                    return;
                                }
                                else { MessageBox.Show($"{_student.Firstname} isimli öğrencinin {selectedLesson.LessonName} dersine ait 3.sınav notu bulunmaktadır."); rdbUcuncuSinav.Checked = false; }
                            }
                            else { MessageBox.Show($"{_student.Firstname} isimli öğrencinin sistemde 2.sınav notu bulunmamaktadır. Lütfen önce 2.sınav notu girişini tamamlayınız."); rdbUcuncuSinav.Checked = false; }
                        }
                        else { MessageBox.Show($"{_student.Firstname} isimli öğrencinin sistemde 1.sınav notu bulunmamaktadır. Lütfen önce 1.sınav notu girişini tamamlayınız."); rdbUcuncuSinav.Checked = false; }
                    }
                    else { MessageBox.Show("Kaçıncı sınavın notunu girecekseniz lütfen o sınavı işaretleyiniz."); }
                }
                else { MessageBox.Show("Not girişi yapmak istediğiniz dersi seçiniz."); }
            }
            else { MessageBox.Show("Lütfen not girişi yapılacak öğrenciyi seçiniz."); }
        }

        public void ClearSelection() //CHECK 
        {
            dgvListStudent.ClearSelection();
        }
        public void DeSelectComboBox() //CHECK 
        {
            cmbSubeler.SelectedIndex = -1; //cmbDersler.SelectedIndex = -1;
        }
        public bool CheckExamCount(int value) //CHECK 
        {
            if (value <= 100 && value >= 0)
            {
                return true;
            }
            else { MessageBox.Show("Sınav notu maksimum 100, minimum 0 olabilir."); return false; }
        }

        #endregion

        //--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\--//--\\

        /// <summary>
        /// TextBox'a girilen veriyi DGV üzerinde arar. Eşleşen veri varsa ilgili verinin hücresini mavi renk ile işaretler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtSearch.Text.ToUpper();

            for (int i = 0; i <= dgvListStudent.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dgvListStudent.Rows)
                {
                    foreach (DataGridViewCell cell in dgvListStudent.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                            else cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }
        private void txtDersNotu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        Student _student;
        private void dgvListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_studentRep != null)
            {
                string value = dgvListStudent.CurrentRow.Cells[0].Value.ToString();
                _student = _studentRep.FirstOrDefault(x => x.SchoolNumber == value);

                txtOgrenciAdi.Text = $"{_student.Firstname} {_student.Lastname}";
            }
        }

        private void btnDevamsizlikKaydet_Click(object sender, EventArgs e)
        {
            AddAbsences();
        }
        private void btnNotuKaydet_Click(object sender, EventArgs e)
        {
            AddExamGrade();
        }
        private void btnSubeOgrenciListele_Click(object sender, EventArgs e)
        {
            ListBranchStudent(); LessonOfTheClass(); ClearSelection();
            _student = null; txtOgrenciAdi.Text = string.Empty;
        }
    }
}