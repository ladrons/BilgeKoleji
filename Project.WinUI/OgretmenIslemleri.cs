using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.COMMON.Tools;
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
    public partial class OgretmenIslemleri : Form
    {
        TeacherRepository _teacherRep; LessonRepository _lessonRep; BranchRepository _branchRep;

        TeacherAndClassroomRepository _teacherAndClassroomRep;
        TeacherSyllabusRepository _teacherSyllabusRep;

        public OgretmenIslemleri()
        {
            InitializeComponent();

            ListDays(); ListLesson(); ListBranch();

            DeselectComboBox();

            _teacherAndClassroomRep = new TeacherAndClassroomRepository();
        }

        #region METHODS

        public void ListTeacher() //CHECK 
        {
            if (_teacherRep == null) _teacherRep = new TeacherRepository();
            dgvOgretmenListe.ClearSelection();

            List<Teacher> teachers = _teacherRep.GetActives(); //DB'de aktif olan bütün öğretmen verilerini list'e atıyorum.
            List<DTO.WinUI.TeacherDTO> teacherDTOs = new List<DTO.WinUI.TeacherDTO>(); //Yeni bir ListDTO oluşturuyorum.

            foreach (Teacher item in teachers)
            {
                DTO.WinUI.TeacherDTO teacherDTO = new DTO.WinUI.TeacherDTO();

                teacherDTO.ID = item.ID;
                teacherDTO.Name = $"{item.Firstname} {item.Lastname}";
                teacherDTO.BranchName = $"{item.Branch.StudyName}";

                if (item.Lesson != null) // Bu kısım olduğundan dolayı Select() methodu ile yapmadım. Çünkü NullReferance veriyor.
                {
                    teacherDTO.LessonName = $"{item.Lesson.LessonName}";
                }
                else teacherDTO.LessonName = $"Atama Yok";

                teacherDTOs.Add(teacherDTO);
            }
            dgvOgretmenListe.DataSource = teacherDTOs;

            #region SutunIsimleri

            dgvOgretmenListe.Columns[0].HeaderText = "Öğretmen Adı Soyadı";
            dgvOgretmenListe.Columns[1].HeaderText = "Branş Adı";
            dgvOgretmenListe.Columns[2].HeaderText = "Atandığı Ders";

            #endregion
        }
        public void ListBranch() //CHECK 
        {
            if (_branchRep == null) _branchRep = new BranchRepository();

            cmbAktifBranslar.DataSource = _branchRep.GetActives();
            cmbButunBranslar.DataSource = _branchRep.GetActives();

            //ToDo: Branşlar için 2 adet ComboBox kullanıyorum. Daha iyi nasıl yapabilirim kontrol edeceğim. (Düşük Öncelik)
        }
        public void ListLesson() //CHECK 
        {
            if (_lessonRep == null) _lessonRep = new LessonRepository();

            cmbDersler.DataSource = _lessonRep.GetActives();
        }
        public void ListDays() //CHECK 
        {
            string[] days = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };

            cmbGunler.DataSource = days;

            cmbGunler.SelectedIndex = -1;
        }

        //--\\

        public void CreateTeacher(string firstname, string lastname, Branch branch)
        {
            if (_teacherRep == null) _teacherRep = new TeacherRepository();

            if (firstname != "" && lastname != "" && branch != null)
            {
                Teacher dbTeacher = _teacherRep.FirstOrDefault(x => x.Firstname == firstname && x.Lastname == lastname && x.Status != ENTITIES.Enums.DataStatus.Deleted);

                if (dbTeacher == null /*|| dbTeacher.Status == ENTITIES.Enums.DataStatus.Deleted*/ )
                {
                    Teacher teacher = new Teacher();

                    teacher.Firstname = firstname;
                    teacher.Lastname = lastname.ToUpper();

                    teacher.Branch = branch;

                    teacher.UserName = $"{firstname}0{firstname.Length}".ToLower(); //Web sitesine giriş için.

                    string cryptPass = MyCrypt.Crypt($"{DateTime.Now.Year}bilge{firstname}");
                    teacher.Password = cryptPass.ToLower();

                    _teacherRep.Add(teacher);

                    MessageBox.Show($"{teacher.Firstname} {teacher.Lastname} İsimli öğretmen başarılı bir şekilde sisteme kaydedilmiştir.\nWeb portalı için giriş bilgileri aşağıdaki gibidir. Lütfen bilgileri not ediniz!\n\nKullanıcı adı: {teacher.UserName}\n\nŞifre: {DateTime.Now.Year}bilge{firstname.ToLower()}");

                    ListTeacher(); DeselectComboBox();
                    txtOgretmenAdi.Text = txtOgretmenSoyadi.Text = String.Empty;
                }
                else
                {
                    DialogResult devamEdilsinMi = MessageBox.Show($"Sistemde girmiş olduğunuz isim/soyisim bilgisine sahip başka bir öğretmen bulunmakta. Yine de kayıt işlemine devam etmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (devamEdilsinMi == DialogResult.Yes)
                    {
                        Teacher teacher = new Teacher();

                        teacher.Firstname = firstname;
                        teacher.Lastname = lastname.ToUpper();

                        teacher.Branch = branch;

                        teacher.UserName = $"{firstname}0{firstname.Length}".ToLower(); //Web sitesine giriş için.

                        string cryptPass = MyCrypt.Crypt($"{DateTime.Now.Year}bilge{firstname}");
                        teacher.Password = cryptPass.ToLower();

                        _teacherRep.Add(teacher);

                        MessageBox.Show($"{teacher.Firstname} {teacher.Lastname} İsimli öğretmen başarılı bir şekilde sisteme kaydedilmiştir.\nWeb portalı için giriş bilgileri aşağıdaki gibidir. Lütfen bilgileri not ediniz!\n\nKullanıcı adı: {teacher.UserName}\n\nŞifre: {DateTime.Now.Year}bilge{firstname.ToLower()}");

                        ListTeacher(); DeselectComboBox();
                        txtOgretmenAdi.Text = txtOgretmenSoyadi.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi iptal edildi.");

                        ListTeacher(); DeselectComboBox();
                        txtOgretmenAdi.Text = txtOgretmenSoyadi.Text = String.Empty;
                    }
                }
            }
            else { MessageBox.Show("Lütfen bütün bilgileri eksiksiz giriniz."); }
        }
        public void CreateBranch(string branchName)
        {
            if (branchName != "")
            {
                Branch dbBranch = _branchRep.FirstOrDefault(x => x.StudyName == branchName);

                if (dbBranch == null)
                {
                    Branch branch = new Branch();

                    branch.StudyName = branchName;

                    _branchRep.Add(branch);

                    MessageBox.Show("Branş sisteme başarılı bir şekilde kaydedildi.");

                    ListBranch(); DeselectComboBox();
                    txtBransAdi.Text = String.Empty;
                }
                else { MessageBox.Show("Sistemde bu isimde bir branş bulunmakta."); }
            }
            else { MessageBox.Show("Lütfen branş adı giriniz."); }
        }

        public void UpdateTeacher(string newFirstname, string newLastname, Branch newBranch)
        {
            if (newFirstname != "" && newLastname != "")
            {
                if (_teacher != null)
                {
                    Teacher dbTeacher = _teacherRep.FirstOrDefault(x => x.Firstname == newFirstname && x.Lastname == newLastname);

                    if (dbTeacher == null)
                    {
                        _teacher.Firstname = newFirstname;
                        _teacher.Lastname = newLastname.ToUpper();

                        if (newBranch != null)
                        {
                            _teacher.Branch = newBranch;
                        }

                        _teacherRep.Update(_teacher);

                        MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");

                        ListTeacher(); DeselectComboBox();
                        _teacher = null; dgvOgretmenListe.ClearSelection();
                        txtOgretmenAdi.Text = txtOgretmenSoyadi.Text = txtSeciliOgretmenAdi.Text = String.Empty;
                    }
                    else if (dbTeacher != null)
                    {
                        _teacher.Branch = newBranch;

                        _teacherRep.Update(_teacher);

                        MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");

                        ListTeacher(); DeselectComboBox();
                        _teacher = null; dgvOgretmenListe.ClearSelection();
                        txtOgretmenAdi.Text = txtOgretmenSoyadi.Text = txtSeciliOgretmenAdi.Text = String.Empty;
                    }
                }
            }
            else { MessageBox.Show("Lütfen bilgileri eksiksiz bir şekilde giriniz."); }
        }
        public void UpdateBranch()
        {
            if (cmbButunBranslar.SelectedIndex > -1)
            {
                Branch dbBranch = cmbButunBranslar.SelectedItem as Branch;

                if (txtBransAdi.Text != "" && txtBransAdi.Text != dbBranch.StudyName)
                {
                    dbBranch.StudyName = txtBransAdi.Text;
                    _branchRep.Update(dbBranch);

                    MessageBox.Show("Seçili branş başarılı bir şekilde güncellendi.");

                    ListBranch(); DeselectComboBox();
                    txtBransAdi.Text = String.Empty;
                }
                else { MessageBox.Show("Lütfen yeni branş adını giriniz."); }
            }
            else { MessageBox.Show("Düzenlemek istediğiniz branşı seçiniz."); }
        }

        public void DeleteTeacher()
        {
            if (_teacher != null)
            {
                DialogResult veriSilinsinMi = MessageBox.Show("Seçili olan öğretmen sistemden kaldırılacak. Devam edilsin mi?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (veriSilinsinMi == DialogResult.OK)
                {
                    _teacherRep.Delete(_teacher);

                    ListTeacher(); dgvOgretmenListe.ClearSelection();
                    _teacher = null; txtSeciliOgretmenAdi.Text = string.Empty;

                    MessageBox.Show("Seçili öğretmen sistemden kaldırıldı.");
                }
                else { MessageBox.Show("Silme işlemi iptal edildi."); return; }
            }
            else MessageBox.Show("Lütfen silme işlemini yapmak istediğiniz öğretmeni seçiniz.");
        }
        public void DeleteBranch()
        {
            if (cmbButunBranslar.SelectedIndex != -1)
            {
                if (_teacherRep == null) _teacherRep = new TeacherRepository();

                Branch selectedBranch = cmbButunBranslar.SelectedItem as Branch;

                List<Teacher> teachers = new List<Teacher>();
                teachers = _teacherRep.GetActives();

                foreach (Teacher item in teachers)
                {
                    if (item.Branch.StudyName == selectedBranch.StudyName)
                    {
                        MessageBox.Show("Silmek istediğiniz branş aktif olarak kullanılıyor. Silmek istediğiniz branşa kayıtlı olan bütün öğretmenlerin branşlarını değiştirip tekrardan silme işlemini gerçekleştiriniz. ");
                        ListBranch(); DeselectComboBox();

                        return;
                    }
                }
                _branchRep.Delete(selectedBranch);

                MessageBox.Show("Seçili branş başarılı bir şekilde silinmiştir.");

                ListBranch(); DeselectComboBox();
            }
            else MessageBox.Show("Lütfen bir branş seçiniz.");
        }

        //--\\

        public void LessonAssignment() //CHECK 
        {
            if (cmbDersler.SelectedIndex > -1)
            {
                Lesson SelectedLesson = cmbDersler.SelectedItem as Lesson;

                if (_teacher != null)
                {
                    if (_teacher.Lesson == null)
                    {
                        _teacher.Lesson = SelectedLesson;
                        _teacherRep.Update(_teacher);

                        MessageBox.Show($"{_teacher.Firstname} İsimli öğretmene {SelectedLesson.LessonName} dersi başarılı bir şekilde atanmıştır.", "İşlem Gerçekleştirildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListTeacher(); _teacher = null;
                        cmbDersler.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show($"{_teacher.Firstname} İsimli öğretmene atanmaış bir ders bulunmakta. Bir öğretmene sadece bir ders atanabilir.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cmbDersler.SelectedIndex = -1;
                        return;
                    }
                }
                else { MessageBox.Show("Lütfen öğretmen seçin."); }
            }
            else { MessageBox.Show("Lütfen ders seçimi yapın."); }
        }
        public void LessonRemoval() //CHECK 
        {
            if (_teacher != null)
            {
                if (_teacher.Lesson != null)
                {
                    _teacher.Lesson = null;
                    _teacherRep.Update(_teacher);

                    MessageBox.Show($"{_teacher.Firstname} İsimli öğretmene atanmış olan ders başarılı bir şekilde kaldırılmıştır.", "İşlem Gerçekleştirildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListTeacher(); _teacher = null;
                }
                else MessageBox.Show("Seçili öğretmene atanmış ders bulunmamaktadır.");
            }
            else { MessageBox.Show("Lütfen öğretmen seçin."); }
        }

        //--\\

        public void AddSyllabus()
        {
            if (cmbGunler.SelectedIndex != -1)
            {
                List<string> classes = new List<string>();

                foreach (object item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (((TextBox)item).Text == "")
                        {
                            MessageBox.Show("Lütfen ders programında boş seçenek bırakmayınız.");
                            return;
                        }

                        classes.Add(((TextBox)item).Text);
                    }
                }
                TeacherSyllabus teacherSyllabus = new TeacherSyllabus();

                teacherSyllabus.LessonName = _teacher.Lesson.LessonName;
                teacherSyllabus.Day = cmbGunler.SelectedItem.ToString();

                if (_teacherSyllabusRep == null) _teacherSyllabusRep = new TeacherSyllabusRepository();

                bool test = _teacherSyllabusRep.Any(x => x.TeacherID == _teacher.ID && x.Day == teacherSyllabus.Day); //ToDo: Test edilecek.

                if (test == true) { MessageBox.Show($"Seçili öğretmenin {teacherSyllabus.Day} gününe ait ders programı bulunmaktadır."); return; }

                teacherSyllabus.ClassOne = classes[0]; teacherSyllabus.ClassTwo = classes[1];
                teacherSyllabus.ClassThree = classes[2]; teacherSyllabus.ClassFour = classes[3];
                teacherSyllabus.ClassFive = classes[4]; teacherSyllabus.ClassSix = classes[5];
                teacherSyllabus.ClassSeven = classes[6]; teacherSyllabus.ClassEight = classes[7];

                teacherSyllabus.TeacherID = _teacher.ID;

                DialogResult confirmSyllabus = MessageBox.Show("Ders programı oluşturulacak. Onaylıyor musunuz?","Ders Programı Oluşturma",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (confirmSyllabus == DialogResult.OK)
                {
                    _teacherSyllabusRep.Add(teacherSyllabus);

                    MessageBox.Show($"{_teacher.Firstname} {_teacher.Lastname} İsimli öğretmenin {teacherSyllabus.Day} gününe ders programı oluşturulmuştur.","İşlem Gerçekleştirildi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    foreach (object item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = String.Empty;
                        }
                    }
                    cmbGunler.SelectedIndex = -1; lstOgretmenSiniflari.SelectedIndex = -1;
                }
                else { MessageBox.Show("Ders programı kaydetme işlemi sonlandırıldı. Herhangi bir veri kaydedilmedi."); return; }
            }
        }

        /// <summary>
        /// Form üzerindeki bütün cmb'ların Index'ini -1 yapar.
        /// </summary>
        public void DeselectComboBox()
        {
            cmbAktifBranslar.SelectedIndex = cmbButunBranslar.SelectedIndex = cmbDersler.SelectedIndex = -1;
        }

        /// <summary>
        /// Ders programı kısmındaki TextBox'ların altındaki butonları çalıştırır.
        /// </summary>
        /// <param name="value">TextBox'ı temsil edecek değer. 1 => 1.Dersi gösteren TextBox</param>
        public void ClearSyllabusTextBox(int value)
        {
            //ToDo Burası kontrol edilecek ve buradan devam edilecek. 

            switch (value)
            {
                case 1:
                    txtBir.Text = "";
                    break;
                case 2:
                    txtIki.Text = "";
                    break;
                case 3:
                    txtUc.Text = "";
                    break;
                case 4:
                    txtDort.Text = "";
                    break;
                case 5:
                    txtBes.Text = "";
                    break;
                case 6:
                    txtAlti.Text = "";
                    break;
                case 7:
                    txtYedi.Text = "";
                    break;
                case 8:
                    txtSekiz.Text = "";
                    break;
            }
        }

        #endregion

        private void btnOgretmenListele_Click(object sender, EventArgs e)
        {
            ListTeacher();
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            CreateTeacher(txtOgretmenAdi.Text, txtOgretmenSoyadi.Text, cmbAktifBranslar.SelectedItem as Branch);
        }
        private void btnBransKaydet_Click_1(object sender, EventArgs e)
        {
            CreateBranch(txtBransAdi.Text);
        }

        private void btnOgretmenDuzenle_Click(object sender, EventArgs e)
        {
            UpdateTeacher(txtOgretmenAdi.Text, txtOgretmenSoyadi.Text, cmbAktifBranslar.SelectedItem as Branch);
        }
        private void btnBransDuzenle_Click(object sender, EventArgs e)
        {
            UpdateBranch();
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
        }
        private void btnBransSil_Click(object sender, EventArgs e)
        {
            DeleteBranch();
        }

        private void btnDersAta_Click(object sender, EventArgs e)
        {
            LessonAssignment();
        }
        private void btnDersKaldir_Click(object sender, EventArgs e)
        {
            LessonRemoval();
        }

        private void btnDersPrograminiKaydet_Click(object sender, EventArgs e)
        {
            AddSyllabus();
        }

        private void btnTemizleBir_Click(object sender, EventArgs e)
        {
            Button t = (Button)sender;

            ClearSyllabusTextBox(Convert.ToInt32(t.Tag));
        }

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ 

        Teacher _teacher;
        private void dgvOgretmenListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _teacher = _teacherRep.Find(Convert.ToInt32(dgvOgretmenListe.CurrentRow.Cells[3].Value));

            txtSeciliOgretmenAdi.Text = $"{_teacher.Firstname} {_teacher.Lastname}";
        }
        private void txtSeciliOgretmenAdi_TextChanged(object sender, EventArgs e)
        {
            if (_teacher != null)
            {
                lstOgretmenSiniflari.DataSource = _teacherAndClassroomRep.Where(x => x.TeacherID == _teacher.ID).Select(x => x.Classroom).ToList();
            }
        }
        private void lstOgretmenSiniflari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var item in groupBox1.Controls) //groupBox'ın kontrollerinde dönüyorum.
            {
                if (item is TextBox) //Denk gelen kontrol TextBox ise;
                {
                    if (((TextBox)item).Text == "") //Denk gelen TextBox.Text kısmı boş ise;
                    {
                        Classroom selectedClassroom = lstOgretmenSiniflari.SelectedItem as Classroom;

                        ((TextBox)item).Text = selectedClassroom.Section;
                        return;
                    }
                    else continue;
                }
            }
        }


        //TEST

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAktifBranslar.SelectedIndex != -1)
            {
                txtBransAdi.Text = cmbAktifBranslar.SelectedItem.ToString();
            }
            else return;
        }
        private void btnOgretmendenBransKaldir_Click(object sender, EventArgs e)
        {
            if (_teacher != null)
            {
                if (_teacher.Branch != null)
                {
                    _teacher.Branch = null;

                    _teacherRep.Update(_teacher);
                    MessageBox.Show("Seçili öğretmenin branşı kaldırıldı.");

                    _teacher = null; dgvOgretmenListe.ClearSelection();
                    ListTeacher();
                }
            }
            else MessageBox.Show("İşlem yapılacak öğretmeni seçiniz.");
        }

        
    }
}
