using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.DTO.WinUI;
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
    public partial class OgrenciAtama : Form
    {
        StudentRepository _sRep; ClassroomRepository _cRep;

        public OgrenciAtama()
        {
            InitializeComponent();

            ListStudent(); ListClassroom();
        }

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\

        #region METHODS

        public void ListStudent()
        {
            _sRep = new StudentRepository(); 

            dgvOgrenciListele.DataSource = _sRep.GetWithoutClass(x => new WithoutClassStudentDTO
            {
                ID = x.ID,
                SchoolNumber = x.SchoolNumber,
                StudentName = x.Firstname + " " + x.Lastname,
                GradeAverage = x.GradeAverage,

            }).ToList();

            dgvOgrenciListele.ClearSelection();

            #region SutunIsimleri

            dgvOgrenciListele.Columns[0].HeaderText = "Okul Numarası";
            dgvOgrenciListele.Columns[1].HeaderText = "Öğrenci Adı";
            dgvOgrenciListele.Columns[2].HeaderText = "Mezun Not Ortalaması";

            #endregion
        }
        public void ListClassroom()
        {
            _cRep = new ClassroomRepository();

            cmbSiniflar.DataSource = _cRep.GetFirstClassroom();

            cmbSiniflar.SelectedIndex = -1;
        }

        #endregion

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\

        Student _student;
        private void dgvOgrenciListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _student = _sRep.Find(Convert.ToInt32(dgvOgrenciListele.CurrentRow.Cells[3].Value));
        }

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\

        private void btnOgrenciAta_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                if (cmbSiniflar.SelectedIndex > -1)
                {
                    Classroom selectedClassroom = cmbSiniflar.SelectedItem as Classroom;

                    if (selectedClassroom.Students.Count >= 25) 
                    {
                        MessageBox.Show("Seçili sınıfa kayıtlı 25 öğrenci bulunmaktadır. Lütfen başka sınıf seçiniz.");

                        _student = null;
                        ListStudent();

                        return;
                    }
                    else
                    {
                        _student.ClassroomID = (cmbSiniflar.SelectedItem as Classroom).ID;
                        _sRep.Update(_student);
                        _student = null;

                        MessageBox.Show("Atama işlemi başarılı bir şekilde gerçekleştirildi.");

                        ListStudent(); cmbSiniflar.SelectedIndex = -1;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenciyi atamak istediğiniz sınıfı seçiniz.");
                }
            }
            else
            {
                MessageBox.Show($"Lütfen önce öğrenci seçiniz.");
                return;
            }
        }
    }
}
