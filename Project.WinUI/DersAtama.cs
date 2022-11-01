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
    public partial class DersAtama : Form
    {
        //ToDo: Hangi sınıfa hangi ders atanmış bunu gösteren bir DGV eklenebilir. (Düşük Öncelik)

        LessonRepository _lessonRep; ClassroomRepository _classroomRep;
        LessonInClassroomRepository _lessonInClassroomRep; TeacherAndClassroomRepository _teacherAndClassroomRep;

        public DersAtama()
        {
            InitializeComponent();

            ListClassroom(); ListLesson();
        }

        #region METHODS

        public void ListClassroom()
        {
            if (_classroomRep == null) _classroomRep = new ClassroomRepository();

            dgvSinifListesi.DataSource = _classroomRep.GetActives().Select(x => new DTO.WinUI.ListClassroomDTO
            {
                Class = x.Class,
                Branch = x.Section

            }).ToList();

            #region SutunIsimleri

            dgvSinifListesi.Columns[0].HeaderText = "Sınıf Numarası";
            dgvSinifListesi.Columns[1].HeaderText = "Şube Kodu";

            #endregion
        }
        public void ListLesson()
        {
            if (_lessonRep == null) _lessonRep = new LessonRepository();

            cmbAnaDersler.DataSource = _lessonRep.GetActives().ToList();
        }

        public void AssignLesson()
        {
            if (_classroom == null) { MessageBox.Show("Lütfen işlem yapmak için bir sınıf seçiniz."); return; }

            Lesson selectedLesson = cmbAnaDersler.SelectedItem as Lesson;

            if (_lessonInClassroomRep == null) _lessonInClassroomRep = new LessonInClassroomRepository();

            if (_lessonInClassroomRep.Any(x => x.ClassroomID == _classroom.ID && x.LessonID == selectedLesson.ID))
            {
                MessageBox.Show($"{_classroom.Section} Sınıfına zaten {selectedLesson.LessonName} dersi atanmış durumda.");
                return;
            }
            else
            {
                LessonInClassroom lessonInClassroom = new LessonInClassroom();

                lessonInClassroom.ClassroomID = _classroom.ID;
                lessonInClassroom.LessonID = selectedLesson.ID;

                if (lstOgretmenler.SelectedIndex <= -1)
                {
                    MessageBox.Show("Lütfen öğretmen seçiniz.");
                    return;
                }

                Teacher selectedTeacher = lstOgretmenler.SelectedItem as Teacher;

                TeacherAndClassroom teacherAndClassroom = new TeacherAndClassroom();

                teacherAndClassroom.ClassroomID = _classroom.ID;
                teacherAndClassroom.TeacherID = selectedTeacher.ID;

                if (_teacherAndClassroomRep == null) _teacherAndClassroomRep = new TeacherAndClassroomRepository();

                _lessonInClassroomRep.Add(lessonInClassroom);
                _teacherAndClassroomRep.Add(teacherAndClassroom);

                MessageBox.Show("İşlem gerçekleştirildi.");
            }
        }

        #endregion

        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            AssignLesson();
        }

        //--\\//--\\//--\\

        Classroom _classroom;
        private void dgvSinifListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string branchName = dgvSinifListesi.CurrentRow.Cells[1].Value.ToString();

            _classroom = _classroomRep.FirstOrDefault(x => x.Section == branchName);

            lblSeciliSinif.Text = $"Seçili Sınıf: {branchName}";
        }
        private void cmbAnaDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lesson lesson = cmbAnaDersler.SelectedItem as Lesson;

            lstOgretmenler.DataSource = lesson.Teachers.ToList();

            lblSeciliAnaDers.Text = $"Seçili sınıf: {lesson.LessonName}";
        }
        private void lstOgretmenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOgretmenler.SelectedIndex > -1)
            {
                lblSeciliOgretmen.Text = $"Seçili Öğretmen: {(lstOgretmenler.SelectedItem as Teacher).Firstname}";
            }
        }
    }
}
