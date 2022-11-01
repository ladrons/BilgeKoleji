using Bogus.DataSets;
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
    public partial class OgrenciKayit : Form
    {
        StudentRepository _studentRep; ParentRepository _parentRep;

        public OgrenciKayit()
        {
            InitializeComponent();

            ListActiveParent();
        }

        #region METHODS

        /// <summary>
        /// DB'de aktif olan bütün veliler listeler.
        /// </summary>
        public void ListActiveParent()
        {
            _parentRep = new ParentRepository();

            dgvKayitliVeliler.DataSource = _parentRep.Select(x => new DTO.WinUI.ListActiveParentDTO
            {
                ID = x.ID,
                FirstName = x.Firstname,
                LastName = x.Lastname
            }).ToList();

            dgvKayitliVeliler.ClearSelection();

            #region SutunIsimleri
            
            //dgvKayitliVeliler.Columns[0].Name = "Veli Adı";
            //dgvKayitliVeliler.Columns[1].Name = "Veli Soyadı";
            //dgvKayitliVeliler.Columns[2].Name = "ID";

            #endregion
        }

        //--\\

        /// <summary>
        /// Veli bilgilerini DB'ye kaydeder.
        /// </summary>
        public Parent AddParent()
        {
            if (_parentRep == null) _parentRep = new ParentRepository();

            Parent newParent = new Parent();

            newParent.Firstname = txtVeliAdi.Text; newParent.Lastname = txtVeliSoyadi.Text;

            string cryptPass = MyCrypt.Crypt($"{newParent.Firstname.ToLower()}{newParent.Firstname.Length}"); //Test için bu şekilde kaydedilmiştir. Proje sahibinin isteğine göre değiştirilebilir.

            newParent.UserName = $"{newParent.Firstname.ToLower()}{newParent.Firstname.Length}"; //Test için bu şekilde kaydedilmiştir. Proje sahibinin isteğine göre değiştirilebilir.
            newParent.Password = cryptPass;

            newParent.Address = txtAdres.Text; newParent.Province = txtIl.Text; newParent.District = txtIlce.Text;

            newParent.HomePhonee = txtEvTelefonu.Text; newParent.WorkPhonee = txtIsTelefonu.Text;

            _parentRep.Add(newParent);

            return newParent;
        }

        /// <summary>
        /// Öğrenci bilgilerini DB'ye kaydeder.
        /// </summary>
        public void AddStudent()
        {
            if (_studentRep == null) _studentRep = new StudentRepository();

            if (CheckTextBox() != true) return;

            Student newStudent = new Student();

            string year = DateTime.Now.Year.ToString().Substring(2);
            Student lastStudent = _studentRep.GetLastData();

            if (lastStudent == null)
            {
                newStudent.SchoolNumber = $"{100}-{year}";
            }
            else
            {
                string lastNumber = lastStudent.SchoolNumber;
                string[] spliting = lastNumber.Split('-');

                int veri = int.Parse(spliting[0]);

                veri++;

                newStudent.SchoolNumber = $"{veri}-{year}";

                //ToDo: Burada numarayı 2 parça halinde kaydediyorum. aradaki - işaretini kaldırmanın bir yolunu düşüneceğim. (Düşük Öncelik)
            }

            newStudent.Firstname = txtOgrenciAdi.Text; newStudent.Lastname = txtOgrenciSoyadi.Text;

            newStudent.GraduateSchoolName = txtMezunOkul.Text; newStudent.GradeAverage = Convert.ToDecimal(txtNotOrtalamasi.Text);

            string cryptPass = MyCrypt.Crypt($"{newStudent.Firstname.ToLower()}{newStudent.Firstname.Length}");

            newStudent.Password = cryptPass;

            if (rdbErkek.Checked) newStudent.Gender = "Erkek";
            else if (rdbKiz.Checked) newStudent.Gender = "Kız";

            if (_parent == null)
            {
                Parent newParent = AddParent();

                newStudent.ParentID = newParent.ID;
            }
            else
            {
                newStudent.ParentID = _parent.ID;
                _parent = null;
            }
            _studentRep.Add(newStudent);

            MessageBox.Show($"Kayıt işlemi başarılı. Kaydedilen öğrencinin numarası; {newStudent.SchoolNumber}");

            TextBoxClear(this); ListActiveParent();
            return;
        }

        //--\\

        /// <summary>
        /// Form üzerindeki bütün TextBox'ların içeriğini temizler.
        /// </summary>
        /// <param name="c"></param>
        public void TextBoxClear(Control c) // Metodu kullanmak için => TextBoxClear(this);
        {
            foreach (Control item in c.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();

                    rdbErkek.Checked = false; rdbKiz.Checked = false;
                }
            }
        }

        /// <summary>
        /// Form üzerindeki bütün TextBox'lar doldurulduğumu diye kontrol eder.
        /// </summary>
        /// <returns></returns>
        public bool CheckTextBox()
        {
            if (txtOgrenciAdi.Text == "" || txtOgrenciSoyadi.Text == "" || txtMezunOkul.Text == "" || txtNotOrtalamasi.Text == "" || txtVeliAdi.Text == "" || txtVeliSoyadi.Text == "" || txtAdres.Text == "" || txtIl.Text == "" || txtIlce.Text == "")
            {
                MessageBox.Show("Lütfen bütün bilgileri eksiksiz giriniz.");
                return false;
            }
            return true;
        }

        #endregion

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AddStudent();
        }
        private void txtOgrenciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        //--\\

        Parent _parent;
        private void dgvKayitliVeliler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _parent = _parentRep.Find(Convert.ToInt32(dgvKayitliVeliler.CurrentRow.Cells[2].Value));

            txtVeliAdi.Text = _parent.Firstname; txtVeliSoyadi.Text = _parent.Lastname;
            txtAdres.Text = _parent.Address; txtIl.Text = _parent.Province; txtIlce.Text = _parent.District;
            txtEvTelefonu.Text = _parent.HomePhonee; txtIsTelefonu.Text = _parent.WorkPhonee;
            //Diğer veli bilgilerini atamaya gerek duymadım.
        }



        //Alt kısım test içindir. Proje Live'a çıkacağı zaman alt kısımlar kaldırılmalıdır.

        /// <summary>
        /// Bu method test işlemlerini kısaltmak amacıyla yaratılmıştır.
        /// </summary>
        public void AddStudentsTest()
        {
            _studentRep = new StudentRepository(); _parentRep = new ParentRepository();

            #region Crated Parent

            Parent parent = new Parent();

            parent.Firstname = "Test";
            parent.Lastname = "Verisi";

            string cryptTeacherPass = MyCrypt.Crypt($"{parent.Firstname.ToLower()}{parent.Firstname.Length}");

            parent.UserName = $"{parent.Firstname.ToLower()}{parent.Firstname.Length}";
            parent.Password = cryptTeacherPass;

            _parentRep.Add(parent);

            #endregion

            for (int i = 1; i < 11; i++) //DB'e 100 adet veri kaydedeceğim.
            {
                #region Crated Student

                System.Threading.Thread.Sleep(30);

                Student student = new Student();

                string year = DateTime.Now.Year.ToString().Substring(2);
                Student lastStudent = _studentRep.GetLastData();

                if (lastStudent == null)
                {
                    student.SchoolNumber = $"{100}-{year}";
                }
                else
                {
                    string lastNumber = lastStudent.SchoolNumber;
                    string[] spliting = lastNumber.Split('-');

                    int veri = int.Parse(spliting[0]);

                    veri++;

                    student.SchoolNumber = $"{veri}-{year}";
                }

                student.Firstname = new Name("tr").FirstName(); student.Lastname = new Name("tr").LastName();
                student.GraduateSchoolName = "YOK"; student.GradeAverage = 1.15M;

                string cryptStudentPass = MyCrypt.Crypt($"{student.Firstname.ToLower()}{student.Firstname.Length}");

                student.Password = cryptStudentPass;

                if (rdbErkek.Checked) student.Gender = "Erkek";
                else if (rdbKiz.Checked) student.Gender = "Kız";

                student.Parent = parent;

                _studentRep.Add(student);

                #endregion
            }
            MessageBox.Show("İŞLEM BAŞARILI"); return;
        }

        /// <summary>
        /// 'AddStudentsTest' methodunu tetiklemek için oluşturulmuştur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            AddStudentsTest();
        }
    }
}
