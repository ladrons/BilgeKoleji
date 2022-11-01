using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.DTO.WinUI;
using Project.ENTITIES.Models;
using Project.ENTITIES.Enums;
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
    public partial class MezuniyetIslemleri : Form
    {
        StudentRepository _studentRep; ParentRepository _parentRep;
        ClassroomRepository _classroomRep; HomeworkRepository _homeworkRep;
        SemesterRepository _semesterRep; YearRepository _yearRep;
        ExamGradeRepository _examGradeRep; AbsenteeismRepository _absenteeismRep; DocumentRepository _documentRep;

        StudentAverageRepository _studentAverageRep; LessonInClassroomRepository _lessonInClassroomRep;

        public MezuniyetIslemleri()
        {
            InitializeComponent();

            SelectActiveSemester(); SelectActiveYear();

            ListClassroom(); //ListLesson();

            _absenteeismRep = new AbsenteeismRepository();
            _studentAverageRep = new StudentAverageRepository();

            rdbSistem.Checked = true;
        }

        #region METHODS

        Semester _activeSemester;
        public void SelectActiveSemester() //CHECK 
        {
            if (_semesterRep == null) _semesterRep = new SemesterRepository();
            _activeSemester = _semesterRep.GetLastData();

            string[] splits = _activeSemester.SemesterName.Split(' ');

            if (splits[4] == "Güz") chbGuzDonemi.Checked = true;
            else if (splits[4] == "Bahar") chbBaharDonemi.Checked = true;

            lblAktifDonem.Text = $"Bu sayfada görüntülenen ve yapılan bütün\nişlemler {_activeSemester.SemesterName}'ne aittir.";

            if (_activeSemester == null) MessageBox.Show("Aktif dönem bulunamadı. Lütfen yetikililer ile iletişime geçiniz.");
        }

        Year _activeYear;
        public void SelectActiveYear() //CHECK 
        {
            if (_yearRep == null) _yearRep = new YearRepository();
            _activeYear = _yearRep.GetLastData();
        }

        //--\\ //--\\

        public void ListClassroom() //CHECK 
        {
            if (_classroomRep == null) _classroomRep = new ClassroomRepository();

            cmbSiniflar.DataSource = _classroomRep.GetActives();

            cmbSiniflar.SelectedIndex = -1;
        }
        public void ListStundet() //CHECK 
        {
            if (cmbSiniflar.SelectedIndex > -1)
            {
                Classroom classroom = cmbSiniflar.SelectedItem as Classroom;

                if (_studentRep == null) _studentRep = new StudentRepository();

                dgvOgrenciListesi.DataSource = _studentRep.Where(x => x.ClassroomID == classroom.ID && x.AttendanceStatus == GraduateStatus.Continues).Select(x => new DTO.WinUI.StudentDTO
                {
                    SchoolNumber = x.SchoolNumber,
                    StudentName = $"{x.Firstname} {x.Lastname}",
                    Gender = x.Gender,
                    Class = x.Classroom.Class,
                    Branch = x.Classroom.Section

                }).ToList();

                //DeselectStudent(); //ClearTextBoxs();

                #region SutunIsimleri

                dgvOgrenciListesi.Columns[0].HeaderText = "Okul Numarası";
                dgvOgrenciListesi.Columns[1].HeaderText = "İsim Soyisim";
                dgvOgrenciListesi.Columns[2].HeaderText = "Sınıf Numarası";
                dgvOgrenciListesi.Columns[3].HeaderText = "Şube Kodu";
                dgvOgrenciListesi.Columns[4].HeaderText = "Cinsiyet";

                #endregion
            }
            else { MessageBox.Show("Lütfen öğrencilerini görüntülemek istediğiniz sınıfı seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        public void LessonOfTheClass() //CHECK 
        {
            if (_lessonInClassroomRep == null) _lessonInClassroomRep = new LessonInClassroomRepository(); //Instance kontrol.

            Classroom classroom = cmbSiniflar.SelectedItem as Classroom; //Seçili olan sınıfı bir değişkene atıyorum.

            List<Lesson> lessons = new List<Lesson>(); //Daha sonra kullanmak için bir Lesson list oluşturuyorum.

            if (classroom != null) //Seçili bir sınıf var ise;
            {
                List<LessonInClassroom> licList = _lessonInClassroomRep.Where(x => x.ClassroomID == classroom.ID).ToList(); //Seçili sınıfa atanmış bütün dersleri bulup bir list'de topluyorum.

                foreach (LessonInClassroom item in licList) //Topladığım verilerde dönüyorum.
                {
                    lessons.Add(item.Lesson); //Her denk gelen verinin Lesson'ını daha önce oluşturmuş olduğum list'e atıyorum.
                }
                cmbDersler.DataSource = lessons.ToList(); //Cmb'a atıyorum.
            }
        }

        //--\\ //--\\

        Lesson _selectedLesson; ExamGrade _selectedExamGrade;
        public void ShowExamGrade() //CHECK 
        {
            if (_student != null)
            {
                _selectedLesson = cmbDersler.SelectedItem as Lesson;

                if (_selectedLesson == null) //ToDo: mbox güzelleştirilebilir. (Düşük Öncelik)
                {
                    MessageBox.Show("Lütfen ders seçimi yapınız.");
                    return;
                }

                if (_examGradeRep == null) _examGradeRep = new ExamGradeRepository();
                _selectedExamGrade = _examGradeRep.Where(x => x.StudentID == _student.ID && x.SemesterID == _activeSemester.ID && x.LessonName == _selectedLesson.LessonName && x.Status != DataStatus.Deleted).FirstOrDefault();

                if (_selectedExamGrade != null)
                {
                    _firstValue = _selectedExamGrade.FirstResult;
                    _secondValue = _selectedExamGrade.SecondResult;

                    txtBirinciSinav.Text = $"{_firstValue}";
                    txtIkinciSinav.Text = $"{_secondValue}";

                    if (_selectedExamGrade.ThirdResult != null)
                    {
                        _thirdValue = _selectedExamGrade.ThirdResult;

                        txtUcuncuSinav.Text = $"{_thirdValue}";
                    }
                    else
                    {
                        txtUcuncuSinav.Text = $"Not girişi yok";
                        _thirdValue = null;
                    }

                    if (_selectedExamGrade.LessonAverage != null) { txtOrtalama.Text = _selectedExamGrade.LessonAverage.ToString(); }
                    else { txtOrtalama.Text = "Ortalama Yok"; }
                }
                else
                {
                    MessageBox.Show($"{_student.Firstname} İsimli öğrencinin {_selectedLesson.LessonName} dersine ait sınav notu bulunmamaktadır.");

                    _firstValue = _secondValue = 0;
                    _thirdValue = null;
                }
            }
            else MessageBox.Show("Lütfen sınav sonuçlarını görüntülemek istediğiniz öğrenciyi seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        int? _firstValue, _secondValue, _thirdValue, _lessonAverage;
        public void CalculateLessonAverage(int? firstValue, int? secondValue, int? thirdValue) //CHECK 
        {
            if (_student != null && cmbDersler.SelectedIndex > -1)
            {
                if (_selectedExamGrade == null) { MessageBox.Show("Öncelikle işlem yapacağınız dersin notlarını görüntüleyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (_selectedExamGrade.LessonAverage != null)
                {
                    MessageBox.Show($"{_student.Firstname} isimli öğrencinin {_selectedLesson.LessonName} ders ortalaması sisteme kaydedilmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (firstValue != null && secondValue != null) // 1. VE 2. Sınav notları null değilse işleme başlıyor.
                {
                    int? totalValue = firstValue + secondValue; // 1. ve 2.sınav notları toplanıp tek bir değişkene atanıyor.

                    if (thirdValue != null) // 3. Sınav notu girişi var mı diye kontrol ediliyor.
                    {
                        totalValue += Convert.ToInt32(thirdValue); // 3.Sınav notuda diğer notların eklendiği değişkene ekleniyor

                        _lessonAverage = totalValue / 3; // Toplam 3 sınav olduğu için sınavların toplamı 3 sayısına bölünüyor ve dönem ortalaması değişkenine atanıyor.
                    }
                    else { _lessonAverage = totalValue / 2; } // 3. Sınav notu yoksa 1. ve 2.sınav notları toplamı 2 ye bölünüyor ve dönem ortalaması değişkenine atanıyor.

                    DialogResult confirmGPA = MessageBox.Show($"'{_student.Firstname}' isimli öğrencinin '{_selectedLesson.LessonName}' dersi not ortalaması {_lessonAverage} puandır. \n\nHesaplanan puanı sisteme kaydetmek istiyorsanız 'TAMAM' butonuna tıklayınız \nİşlemi iptal etmek istiyorsanız 'İPTAL' butonuna tıklayınız", "Ortalama Hesaplanadı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (confirmGPA == DialogResult.OK)
                    {
                        if (_selectedExamGrade.LessonAverage != null) { MessageBox.Show("Sistemde kayıtlı ortalama bilgisi bulunmaktadır"); } // Daha önce kaydedilmiş dönem not ort. var mı diye kontrol ediliyor.
                        else
                        {
                            _selectedExamGrade.LessonAverage = _lessonAverage; // Seçili sınav bilgisine dönemin ortalaması ekleniyor.
                            _examGradeRep.Update(_selectedExamGrade); // DB ye kaydediliyor.

                            MessageBox.Show("Ortalama kayıt işlemi başarılı bir şekilde gerçekleştirildi.");

                            _selectedLesson = null; _selectedExamGrade = null;
                            _thirdValue = _lessonAverage = null;
                            //_student = null;

                            ShowExamGrade();
                            //ClearTextBoxs(); dgvOgrenciListesi.ClearSelection();
                        }
                    }
                    else { MessageBox.Show("İşlem başarılı bir şekilde iptal edildi."); }
                }
            }
            else MessageBox.Show("Bu işlemi gerçekleştirmek için öncelikle öğrenci ve ders seçimi yapmalısınız");
        }
        public void CalculateSemesterAverage() //CHECK 
        {
            if (_student != null)
            {
                StudentAverage checkStudentAverage = _studentAverageRep.Where(x => x.StudentID == _student.ID && x.YearID == _activeYear.ID).FirstOrDefault();

                if (checkStudentAverage != null)
                {
                    if (chbGuzDonemi.Checked)
                    {
                        if (checkStudentAverage.AutumnAverage != null)
                        {
                            MessageBox.Show("Seçili öğrencinin güz dönem not ortalaması hesaplanıp sisteme kaydedilmiştir.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else if (chbBaharDonemi.Checked)
                    {
                        if (checkStudentAverage.SpringAverage != null)
                        {
                            MessageBox.Show("Seçili öğrencinin bütün dönem ortalamaları hesaplanıp sisteme kaydedilmiştir.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                if (_examGradeRep == null) _examGradeRep = new ExamGradeRepository();
                List<int?> lessonAverages = _examGradeRep.Where(x => x.StudentID == _student.ID && x.SemesterID == _activeSemester.ID).Select(x => x.LessonAverage).ToList();
                /* Seçili olan öğrencinin mevcut dönemdeki bütün derslerinin ortalamalarını list'e atar */

                foreach (var item in lessonAverages)
                {
                    if (item == null) // Eğer öğrenciye girilmiş not yoksa burası tetiklenir. (Öğrenci not olarak 0 da alabileceği için 'null' olarak ayarladım.)
                    {
                        MessageBox.Show("Seçili öğrencinin hesaplanmayan ders ortalaması bulunmakta. Lütfen bütün derslerin ortalamalarını hesaplayın.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int totalLesson = cmbDersler.Items.Count; //Dönemde kayıtlı olan bütün dersler cmb'da olduğu için oradaki ders sayısından yararlanabilirim.
                if (lessonAverages.Count == 0 || lessonAverages.Count > totalLesson || lessonAverages.Count < totalLesson) //Bütün derslere ait ortalama var mı diye kontrol ediyorum.
                {
                    MessageBox.Show("Lütfen dönemde aktif olan bütün derslerin ortalamalarını hesaplayın. ");
                    return;
                }
                else
                {
                    int totalValue = 0;

                    for (int i = 0; i < lessonAverages.Count; i++)
                    {
                        totalValue += Convert.ToInt32(lessonAverages[i]); // Her ders ortalamasını toplayarak değişkene atıyorum.
                    }
                    int semesterAverage = totalValue / lessonAverages.Count; //son olarak toplam ders sayısına bölüyorum.

                    if (chbGuzDonemi.Checked) //Öğrenci güz döneminde evrak kazandımı diye kontrol etmek için;
                    {
                        if (semesterAverage >= 70 && semesterAverage <= 84) chbTesekkur.Checked = true;
                        else if (semesterAverage >= 85 && semesterAverage <= 100) chbTakdir.Checked = true;
                    }

                    DialogResult confirmSemesterAverage = MessageBox.Show($"{_student.Firstname} isimli öğrencinin {_activeSemester.SemesterName} ortalaması {semesterAverage} puandır.\n\nİşlemi onaylıyor musunuz?", "Dönem Ortalama Hesaplama", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (confirmSemesterAverage == DialogResult.OK)
                    {
                        if (chbGuzDonemi.Checked)
                        {
                            // Güz dönemi işaretli ise sistemde yeni bir yıl oluşturulmuştur. Daha önce hiç dönem notu girilmemiştir. Bu sebebten dolayı yeni bir 'YearAverage' oluşturulmalıdır.

                            StudentAverage yearAverage = new StudentAverage();

                            yearAverage.YearID = _activeYear.ID;
                            yearAverage.StudentID = _student.ID;

                            yearAverage.AutumnAverage = semesterAverage;

                            DocumentProcess(semesterAverage);

                            _studentAverageRep.Add(yearAverage);

                            DeleteExamGrades();

                            chbTakdir.Checked = chbTesekkur.Checked = false;
                        }
                        else if (chbBaharDonemi.Checked)
                        {
                            // Bahar dönemi işaretli ise sistemde kayıtlı bir yıl vardır. Daha önce güz dönemi notları girildiği için 'YearAverage' oluşturulmuştur. Oluşturulan verinin üzerine veri kaydetmeliyiz.

                            StudentAverage dbStudentAverage = _studentAverageRep.Where(x => x.StudentID == _student.ID && x.YearID == _activeYear.ID).FirstOrDefault();

                            dbStudentAverage.SpringAverage = semesterAverage;

                            _studentAverageRep.UpdateStudentAverage(dbStudentAverage);

                            DeleteExamGrades();
                        }
                        MessageBox.Show("Dönem notu sisteme başarılı bir şekilde kaydedilmiştir.");
                        ShowStudentInfo();

                    }
                    else { MessageBox.Show("Ortalama hesaplama işlemi iptal edilmiştir. Herhangi bir not kaydı yapılmamıştır."); chbTakdir.Checked = chbTesekkur.Checked = false; }
                }
            }
            else { MessageBox.Show("Dönem ortalaması hesaplanacak öğrenciyi seçiniz."); }
        }
        public void CalculateYearAverage() //CHECK 
        {
            if (_student != null)
            {
                StudentAverage dbStudentAverage = _studentAverageRep.FindNotDeletedStudentAverage(_activeYear.ID, _student.ID); //Öğrencinin aktif yıla ait ortalama bilgilerine ulaşıyorum.

                if (dbStudentAverage == null) //Aktif yıla ait ortalama bilgisi yok ise;
                {
                    MessageBox.Show("Seçili öğrencinin sisteme kayıtlı ortalama bilgisi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentAverageDTO studentAverageDTO = new StudentAverageDTO(); //İşlemler sırasında sorun yaşamamak için DTO kullanıyorum.

                studentAverageDTO.AutumnAverage = dbStudentAverage.AutumnAverage; // DB'den gelen güz dönem ortalamasını DTO'ya atıyoruz.

                if (dbStudentAverage.SpringAverage == null)
                {
                    MessageBox.Show("Yılsonu ortalaması hesaplamak için 2 döneminde not bilgilerini sisteme girmeniz gereklidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                studentAverageDTO.SpringAverage = dbStudentAverage.SpringAverage; //DB'den gelen bahar dönem ortalamasını DTO'ya atıyoruz.

                studentAverageDTO.YearAverage = (studentAverageDTO.AutumnAverage + studentAverageDTO.SpringAverage) / 2; //Ortalama bulma işlemi yapılıyor.

                DialogResult confirmYearAverage = MessageBox.Show($"{_student.Firstname} {_student.Lastname} isimli öğrencinin yılsonu notu {studentAverageDTO.YearAverage} puandır.\nPuanı sisteme kaydetmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirmYearAverage == DialogResult.Yes)
                {
                    dbStudentAverage.YearAverage = studentAverageDTO.YearAverage;

                    _studentAverageRep.UpdateStudentAverage(dbStudentAverage);

                    ShowStudentInfo();

                    MessageBox.Show($"{_student.Firstname} isimli öğrencinin yılsonu ortalaması sisteme kaydedilmiştir. Bu öğrenci için sınıf geçti/kaldı işlemleri gerçekleştirebilirsiniz.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Yılsonu ortalama hesaplama işlemi iptal edilmiştir.", "İşlem İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
            }
            else MessageBox.Show("Lütfen öğrenci seçimi yapınız.");
        }

        /// <summary>
        /// Öğrencinin yılsonu notuna göre sınıf geçme ya da kalma methodlarını tetikler
        /// </summary>
        /// <param name="yearAverageGrade">Seçili öğrencinin yılsonu notu</param>
        public void ClassPassProcess(int yearAverageGrade) //CHECK 
        {
            if (_student != null)
            {
                if (rdbSistem.Checked)
                {
                    DocumentProcess(yearAverageGrade); //Evrak kontrolü yapar.

                    if (yearAverageGrade > 0 && yearAverageGrade <= 49) ClassRepeatProcress(); // 1
                    else if (yearAverageGrade >= 50 && yearAverageGrade <= 59) ClassRepeatProcress(); // 2
                    else if (yearAverageGrade >= 60 && yearAverageGrade <= 69) ClassAndSectionUpgrade(); // 3
                    else if (yearAverageGrade >= 70 && yearAverageGrade <= 84) ClassAndSectionUpgrade(); // 4
                    else if (yearAverageGrade >= 85 && yearAverageGrade <= 100) ClassAndSectionUpgrade(); // 5
                }
                else if (rdbGecti.Checked)
                {
                    DocumentProcess(yearAverageGrade);
                    ClassAndSectionUpgrade();
                }
                else if (rdbTekrar.Checked)
                {
                    ClassRepeatProcress();
                }
            }
        }
        /// <summary>
        /// Sınıf tekrarı işlemlerini gerçekleştirir.
        /// </summary>
        public void ClassRepeatProcress() //CHECK 
        {
            DeleteAbsenteeism(); DeleteStudentAverages();

            _student.ClassRepetitionCount += 1;

            if (_student.ClassRepetitionCount == 2)
            {
                DialogResult result = MessageBox.Show($"{_student.Firstname} {_student.Lastname} isimli öğrenci sınıfta kalma hakkını doldurmuştur. Öğrencinin okul ile olan ilişkisi kesilecektir", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    _student.AttendanceStatus = GraduateStatus.Separated; //İlişkisi kesilmiş olarak işaretlendi.

                    _studentRep.Delete(_student); //Öğrenciyi pasife çektim.

                    DeleteParent();

                    ListStundet(); dgvOgrenciListesi.ClearSelection();
                    MessageBox.Show("İlgili öğrencinin okul ile olan ilişkisi kesilmiştir.");
                    return;
                }
            }
            else
            {
                _studentRep.Update(_student);

                ShowStudentInfo();

                MessageBox.Show($"{_student.Firstname} {_student.Lastname} isimli öğrenci sınıf tekrarı yapmak zorundadır. Şuana kadar bu öğrenci toplam {_student.ClassRepetitionCount} kere sınıf tekrarı yapmıştır.\n\nToplamda 2 kere sınıf tekrarı yapan öğrencinin okul ile ilişiği kesilir.");
            }

            //ToDo: mbox eklenmeli.
        }
        /// <summary>
        /// Öğrenciye sınıf atlatır ve DB'e işler.
        /// </summary>
        public void ClassAndSectionUpgrade()
        {
            //- Sınıf numarası arttırma işlemleri -\\

            string oldClass = _student.Classroom.Class; // Öğrencinin eski sınıfı

            string[] classNameArrays = oldClass.Split('.'); // Class'ın adını array'a atıyoruz. İlk basamağını int e dönüştürüp bir arttıracağız.

            int classNumber = Convert.ToInt32(classNameArrays[0]);
            int newClassNumber = ++classNumber;

            string newClass = $"{newClassNumber}.Sınıf"; // Öğrencinin yeni sınıfını buluyoruz.

            //- Şube numarası arttırma işlemleri -\\

            string oldSection = _student.Classroom.Section; // Öğrencinin eski şubesi

            string[] sectionNameArrays = oldSection.Split('-');

            int sectionNumber = Convert.ToInt32(sectionNameArrays[0]); //Şubenin sayısını int'e çeviriyoruz.
            int newSectionNumber = ++sectionNumber; //Şubenin sayısını bir arttırıyoruz.

            #region Şube harfini değiştirme
            //char sectionAscii = Convert.ToChar(sectionNameArrays[1]);

            //int sectionLetter = Convert.ToInt32(sectionAscii); //Burada şubenin harfini ASCII karşılığına çeviriyoruz.
            //int newSectionLetter = ++sectionLetter; //ASCII sayısını bir arttırıyoruz. 
            #endregion

            string newSection = $"{newSectionNumber}-{sectionNameArrays[1]}"; // Öğrencinin yeni şubesini buluyoruz.

            #region Mezuniyet İşlemleri

            if (newClass == "5.Sınıf") //Böyle bir sınıf olmadığı için öğrenci teknik olarak mezun olmuş olacak. Bu yüzden bu if içerisinde mezuniyet işlemleri yapılacak.
            {
                DeleteAbsenteeism(); //Öğrencinin aktif yıldaki devamsızlıklarını pasife çeker.
                DeleteStudentAverages(); //Öğrencinin aktif yıldaki ortalamalarını pasife çeker.
                DeleteDocuments(); //Öğrencinin bütün aktif olan evraklarını pasife çeker.

                GraduationProcess(); //Mezuniyet işlemini gerçekleştirir.

                MessageBox.Show("İlgili öğrenci başarılı bir şekilde mezun olmuştur.");
                ListStundet(); ClearTextBoxs();
                return;
            }

            #endregion

            //- Update ve DB işlemleri -\\

            Classroom newClassroom = _classroomRep.Where(x => x.Class == newClass && x.Section == newSection).FirstOrDefault(); // Öğrencinin yeni sınıfını buluyoruz.

            DeleteAbsenteeism(); DeleteStudentAverages();

            _student.Classroom = newClassroom; // Yeni sınıfı öğrenciye atıyoruz.
            _studentRep.Update(_student);

            ListStundet(); dgvOgrenciListesi.ClearSelection();
            ClearTextBoxs();

            MessageBox.Show($"{_student.Firstname} {_student.Lastname} isimli öğrenci bir üst sınıfa geçmeye hak kazanmıştır.\n\nÖğrencinin yeni sınıfı {_student.Classroom.Section} olarak güncellenmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        /// <summary>
        /// Mezuniyet işlemlerini gerçekleştirir.
        /// </summary>
        public void GraduationProcess()
        {
            _student.AttendanceStatus = GraduateStatus.Graduated; //Mezun olarak işaretledim.

            DeleteHomeworks();

            _studentRep.Delete(_student); //Öğrenciyi pasife çekiyorum.

            DeleteParent(); //Öğrencinin bağlı olduğu veliyi kontrol ediyorum ve duruma göre onuda pasife çekiyorum.
        }
        /// <summary>
        /// Bu method öğrencinin bağlı olduğu veliyi kontrol eder ve duruma göre pasife çeker.
        /// </summary>
        public void DeleteParent()
        {
            Parent deleteParent = _student.Parent; //Seçili öğrencinin veli bilgisini değişkene atıyorum.

            if (deleteParent.Students.Count == 1) //Veliye kayıtlı bir öğrenci var ise;
            {
                if (deleteParent.Students[0].Status == DataStatus.Deleted) //Ve bu kayıtlı olan öğrenci pasif ise;
                {
                    if (_parentRep == null) _parentRep = new ParentRepository();

                    _parentRep.Delete(deleteParent); //Parent Silinecek.
                }
            }
            else //Veliye kayıtlı birden fazla öğrenci var ise;
            {
                List<Student> activeStudents = new List<Student>();

                foreach (Student student in deleteParent.Students)
                {
                    if (student.Status != DataStatus.Deleted) //Denk gelinen öğrenci hala aktif ise;
                    {
                        activeStudents.Add(student); //Gelen her veriyi list'e atıyorum.
                    }
                }
                if (activeStudents.Count == 0)
                {
                    if (_parentRep == null) _parentRep = new ParentRepository();

                    _parentRep.Delete(deleteParent);
                }
            }
        }
        /// <summary>
        /// Seçili öğrencinin aktif olan devamsızlık bilgilerini pasif yapar.
        /// </summary>
        public void DeleteAbsenteeism()
        {
            try
            {
                List<Absenteeism> oldAbsenteeisms = _absenteeismRep.Where(x => x.StudentID == _student.ID && x.Status != DataStatus.Deleted).ToList();
                if (oldAbsenteeisms.Count == 0) return;

                _absenteeismRep.DeleteRange(oldAbsenteeisms);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata ile karşılaşıldı {ex.Message}");
            }
        }
        /// <summary>
        /// Seçili öğrencinin aktif olan bütün sınavlarını pasif yapar. (Dönemsel çalışır.)
        /// </summary>
        public void DeleteExamGrades()
        {
            if (_examGradeRep == null) _examGradeRep = new ExamGradeRepository();

            try
            {
                List<ExamGrade> oldExamGrades = _examGradeRep.Where(x => x.StudentID == _student.ID && x.SemesterID == _activeSemester.ID && x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();
                _examGradeRep.DeleteRange(oldExamGrades);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata ile karşılaşıldı. {ex.Message}");
            }
        }
        /// <summary>
        /// Seçili öğrencinin aktif olan yıl ortalama bilgilerini pasif yapar.
        /// </summary>
        public void DeleteStudentAverages()
        {
            try
            {
                StudentAverage oldAverages = _studentAverageRep.Where(x => x.StudentID == _student.ID && x.YearID == _activeYear.ID && x.Status != ENTITIES.Enums.DataStatus.Deleted).FirstOrDefault();
                _studentAverageRep.Delete(oldAverages);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata ile karşılaşıldı. {ex.Message}");
            }
        }
        /// <summary>
        /// Öğrencinin sistemde kayıtlı olan ödevlerini pasif yapar.
        /// </summary>
        public void DeleteHomeworks()
        {
            if (_homeworkRep == null) _homeworkRep = new HomeworkRepository();

            try
            {
                List<Homework> oldHomeworks = _homeworkRep.Where(x => x.StudentID == _student.ID).ToList();
                if (oldHomeworks.Count == 0) return;

                _homeworkRep.DeleteRange(oldHomeworks);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata ile karşılaşıldı. {ex.Message}");
            }
        }
        /// <summary>
        /// Öğrencinin bütün dönemlerde kazandığı evrakları bulur ve mezun olacağı zaman hepsini pasife çeker.
        /// </summary>
        public void DeleteDocuments()
        {
            List<Document> oldDocuments = _documentRep.Where(x => x.StudentID == _student.ID).ToList();
            _documentRep.DeleteRange(oldDocuments);
        }
        /// <summary>
        /// Seçili öğrenci eğer evrak kazanmış ise ilgili işlemleri yapar ve DB'e kaydeder.
        /// </summary>
        /// <param name="yearAverageGrade">Öğrencinin mevcut yıl ortalaması</param>
        public void DocumentProcess(int average)
        {
            /* Öğrencinin herhangi bir belgeyi alabilmesi için 5 günden az 'özürsüz' devamsızlığı olması gerekmektedir. */

            List<int> studentAbsenteeism = _absenteeismRep.GetExcusedCount(_student.ID); //Devamsızlıkları toplamak için bir list oluşturdum.
            int totalExcused = 0; //Local bir değişken yarattım.

            foreach (int item in studentAbsenteeism) //Öğrencinin bütün devamsızlıklarında dönüp hepsini topluyorum.
            {
                totalExcused += item;
            }

            if (totalExcused < 5) //Eğer devamsızlığı 5 den küçük ise;
            {
                if (_documentRep == null) _documentRep = new DocumentRepository();

                if (average >= 70 && average <= 84) // Ortalama 70 ile 84 arasında ise Teşekkür;
                {
                    Document newDocument = new Document();

                    newDocument.CertificateOfParticipation = true; //Teşekkür belgesi kazandığı için True;
                    newDocument.CertificateOfAppreciation = false; //Aynı anda iki evrağıda kazanamaz. O yüzden diğer evrak False;

                    newDocument.StudentID = _student.ID; newDocument.SemesterID = _activeSemester.ID; //Kazanan öğrencinin ID'si ve kazandığı dönemin ID'sini kaydediyorum.

                    _documentRep.Add(newDocument); //DB kayıt.
                }
                else if (average >= 85 && average <= 100) // Ortalama 85 den büyük ise Takdir;
                {
                    Document newDocument = new Document();

                    newDocument.CertificateOfAppreciation = true; //Takdir belgesi kazandığı için True;
                    newDocument.CertificateOfParticipation = false; //Aynı anda iki evrağıda kazanamaz. O yüzden diğer evrak False;

                    newDocument.StudentID = _student.ID; newDocument.SemesterID = _activeSemester.ID; //Kazanan öğrencinin ID'si ve kazandığı dönemin ID'sini kaydediyorum.

                    _documentRep.Add(newDocument); //DB kayıt.
                }
            }
        }

        //--\\ //--\\

        int _totalExcusedCount, _totalUnexcusedCount;
        /// <summary>
        /// Seçili öğrencinin kayıtlı olan (Aktif yıldaki) bütün devamsızlıklarını gösterir.
        /// </summary>
        public void ShowAbsenteeismInfo() //CHECK 
        {
            _totalExcusedCount = _totalUnexcusedCount = 0;

            List<int> ExcusedCounts = _absenteeismRep.GetExcusedCount(_student.ID);
            List<int> UnexcusedCounts = _absenteeismRep.GetUnexcusedCount(_student.ID);

            foreach (int item in ExcusedCounts)
            {
                _totalExcusedCount += item;
            }
            foreach (int item in UnexcusedCounts)
            {
                _totalUnexcusedCount += item;
            }

            txtOzurluDevamsizlik.Text = _totalExcusedCount.ToString();

            txtOzursuzDevamsizlik.Text = _totalUnexcusedCount.ToString();
        }

        /// <summary>
        /// Seçili olan öğrencinin dönem ve yılsonu ortalama notlarını gösterir.
        /// </summary>
        public void FindYearAverageInfo() //CHECK 
        {

            //ToDo: Test Aşamasında 001
            //StudentAverage averageInfo = _studentAverageRep.FindStudentAverage(_activeYear.ID, _student.ID);

            StudentAverage averageInfo = _studentAverageRep.FindNotDeletedStudentAverage(_activeYear.ID, _student.ID);

            if (averageInfo == null) return;

            if (averageInfo.AutumnAverage == null) txtGuzDonemNotu.Text = "Not girişi yapılmadı";
            else txtGuzDonemNotu.Text = averageInfo.AutumnAverage.ToString();

            if (averageInfo.SpringAverage == null) txtBaharDonemNotu.Text = "Not girişi yapılmadı.";
            else txtBaharDonemNotu.Text = averageInfo.SpringAverage.ToString();

            if (averageInfo.YearAverage == null) txtYilsonuNotu.Text = string.Empty;
            else txtYilsonuNotu.Text = averageInfo.YearAverage.ToString();
        }

        /// <summary>
        /// Seçili öğrencinin bütün bilgilerini form üzerinde gösterir.
        /// </summary>
        public void ShowStudentInfo() //CHECK 
        {
            ClearTextBoxs();

            txtOgrenciAdSoyad.Text = $"{_student.Firstname} {_student.Lastname}"; //Seçili öğrenci adı, soyadı

            txtOkulNumarasi.Text = _student.SchoolNumber; //Seçili öğrenci okul numarası

            txtSinif.Text = _student.Classroom.Class; //Seçili öğrenci sınıfı
            txtSube.Text = _student.Classroom.Section; //Seçili öğrenci şubesi

            ShowAbsenteeismInfo(); FindYearAverageInfo();
        }

        //--\\ //--\\

        /// <summary>
        /// Form üzerindeki bütün TextBox girdilerini temizler.
        /// </summary>
        public void ClearTextBoxs() //CHECK 
        {
            //Öğrencinin temel bilgileri
            txtOkulNumarasi.Text = txtOgrenciAdSoyad.Text = txtSinif.Text = txtSube.Text = String.Empty;

            //Öğrencinin devamsızlık bilgileri
            txtOzurluDevamsizlik.Text = txtOzursuzDevamsizlik.Text = String.Empty;

            //Öğrencinin not bilgileri
            txtOrtalama.Text = txtBirinciSinav.Text = txtIkinciSinav.Text = txtUcuncuSinav.Text = String.Empty;

            //Öğrencinin dönemsonu ortalama bilgileri
            txtGuzDonemNotu.Text = txtBaharDonemNotu.Text = String.Empty;

            //Öğrencinin yılsonu ortalama bilgisi
            txtYilsonuNotu.Text = String.Empty;
        }
        #endregion

        //--||--\\ //--||--\\ //--||--\\ //--||--\\ //--||--\\ //--||--\\ //--||--\\

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            ListStundet(); dgvOgrenciListesi.ClearSelection();
            LessonOfTheClass();

            if (cmbDersler.Items.Count == 0) txtSeciliDers.Text = string.Empty;
        }
        private void btnNotGoster_Click(object sender, EventArgs e)
        {
            txtBirinciSinav.Text = txtIkinciSinav.Text = txtUcuncuSinav.Text = txtOrtalama.Text = string.Empty;

            ShowExamGrade();
        }
        private void btnDersOrtalamaHesapla_Click(object sender, EventArgs e)
        {
            CalculateLessonAverage(_firstValue, _secondValue, _thirdValue);
        }
        private void btnDonemOrtalamaHesapla_Click(object sender, EventArgs e)
        {
            CalculateSemesterAverage();
        }
        private void btnYilSonuHesapla_Click(object sender, EventArgs e)
        {
            CalculateYearAverage();
        }

        private void btnSinifGecmeKontrol_Click(object sender, EventArgs e)
        {
            StudentAverage studentAverage = _studentAverageRep.FindStudentAverage(_activeYear.ID, _student.ID);
            if (studentAverage == null) { MessageBox.Show("Lütfen önce seçili öğrencinin yılsonu ortalamasını hesaplayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            ClassPassProcess(Convert.ToInt32(studentAverage.YearAverage));
        }

        Student _student;
        private void dgvOgrenciListesi_CellClick(object sender, DataGridViewCellEventArgs e) // CHECK 
        {
            string studentNumber = dgvOgrenciListesi.CurrentRow.Cells[0].Value.ToString();

            _student = _studentRep.Where(x => x.SchoolNumber == studentNumber).FirstOrDefault();

            ShowStudentInfo();
        }
        private void cmbDonemDersleri_SelectedIndexChanged(object sender, EventArgs e) // CHECK 
        {
            if (cmbDersler.SelectedIndex > -1)
            {
                txtSeciliDers.Text = cmbDersler.SelectedItem.ToString();
            }
            else return;
        }
        private void txtYilsonuNotu_TextChanged(object sender, EventArgs e) // CHECK 
        {
            if (txtYilsonuNotu.Text == string.Empty)
            {
                chbTakdir.Checked = chbTesekkur.Checked = false;
                btnSinifGecmeKontrol.Enabled = false;

                return;
            }
            else btnSinifGecmeKontrol.Enabled = true;

            int average = Convert.ToInt32(txtYilsonuNotu.Text);

            if (average >= 70 && average <= 84) { chbTesekkur.Checked = true; chbTakdir.Checked = false; }
            else if (average >= 85) { chbTakdir.Checked = true; chbTesekkur.Checked = false; }
            else { chbTesekkur.Checked = chbTakdir.Checked = false; }
        }
    }
}