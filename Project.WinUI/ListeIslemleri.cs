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
    public partial class ListeIslemleri : Form
    {
        DocumentRepository _documentRep; StudentRepository _studentRep;

        public ListeIslemleri()
        {
            InitializeComponent();
        }

        #region METHODS

        /// <summary>
        /// Takdir belgesi kazanan öğrencileri listeler.
        /// </summary>
        public void TakdirAlanOgrenciler()
        {
            _documentRep = new DocumentRepository();

            List<Document> documents = _documentRep.Where(x => x.CertificateOfAppreciation == true);
            List<DTO.WinUI.DocumentDTO> documentDTOs = new List<DTO.WinUI.DocumentDTO>();

            foreach (Document item in documents)
            {
                DTO.WinUI.DocumentDTO documentDTO = new DTO.WinUI.DocumentDTO();

                documentDTO.StudentName = $"{item.Student.Firstname} {item.Student.Lastname}";
                documentDTO.DocumentName = "Takdir Belgesi";
                documentDTO.EarningDate = item.CreatedDate.ToShortDateString();

                documentDTOs.Add(documentDTO);
            }
            dgvListe.DataSource = documentDTOs;

            #region SutunIsimleri

            dgvListe.Columns[0].HeaderText = "Öğrenci İsim Soyisim";
            dgvListe.Columns[1].HeaderText = "Verilen Evrak Adı";
            dgvListe.Columns[2].HeaderText = "Evrak Verilme Tarihi";

            #endregion
        }
        /// <summary>
        /// Teşekkür belgeis kazanan öğrencileri listeler.
        /// </summary>
        public void TesekkurAlanOgrenciler()
        {
            _documentRep = new DocumentRepository();

            List<Document> documents = _documentRep.Where(x => x.CertificateOfParticipation == true);
            List<DTO.WinUI.DocumentDTO> documentDTOs = new List<DTO.WinUI.DocumentDTO>();

            foreach (Document item in documents)
            {
                DTO.WinUI.DocumentDTO dDTO = new DTO.WinUI.DocumentDTO();

                dDTO.StudentName = $"{item.Student.Firstname} {item.Student.Lastname}";
                dDTO.DocumentName = "Teşekkür Belgesi";
                dDTO.EarningDate = item.CreatedDate.ToShortDateString();

                documentDTOs.Add(dDTO);
            }
            dgvListe.DataSource = documentDTOs;

            #region SutunIsimleri

            dgvListe.Columns[0].HeaderText = "Öğrenci İsim Soyisim";
            dgvListe.Columns[1].HeaderText = "Verilen Evrak Adı";
            dgvListe.Columns[2].HeaderText = "Evrak Verilme Tarihi";

            #endregion
        }
        /// <summary>
        /// Okul ile ilişiği kesilen öğrencileri listeler.
        /// </summary>
        public void IlisigiKesilenOgrenci()
        {
            _studentRep = new StudentRepository();

            List<Student> students = _studentRep.Where(x => x.AttendanceStatus != ENTITIES.Enums.GraduateStatus.Continues);
            List<DTO.WinUI.DismissedStudentDTO> graduateStudentDTOs = new List<DTO.WinUI.DismissedStudentDTO>();

            foreach (Student item in students)
            {
                DTO.WinUI.DismissedStudentDTO gsDTO = new DTO.WinUI.DismissedStudentDTO();

                gsDTO.StudentName = $"{item.Firstname} {item.Lastname}";
                gsDTO.SchoolNumber = item.SchoolNumber;
                
                if(item.AttendanceStatus == ENTITIES.Enums.GraduateStatus.Graduated)
                {
                    gsDTO.Description = $"{item.Firstname} {item.Lastname} İsimli öğrenci mezun olduğu için okul ile ilişiği kesilmiştir.";
                }
                else if (item.AttendanceStatus == ENTITIES.Enums.GraduateStatus.Separated)
                {
                    gsDTO.Description = $"{item.Firstname} {item.Lastname} İsimli öğrencinin okul ile ilişi kesilmiştir."; //ToDo: Buraya bir neden için 'notes' propertysi eklenebilir.
                }

                graduateStudentDTOs.Add(gsDTO);
            }
            dgvListe.DataSource = graduateStudentDTOs;

            #region SutunIsimleri

            dgvListe.Columns[0].HeaderText = "Öğrenci İsim Soyisim";
            dgvListe.Columns[1].HeaderText = "Öğrenci Okul Numarası";
            dgvListe.Columns[2].HeaderText = "Açıklama";

            #endregion
        }

        #endregion

        private void btnListeleTakdir_Click(object sender, EventArgs e)
        {
            TakdirAlanOgrenciler();
        }
        private void btnListeleTesekkur_Click(object sender, EventArgs e)
        {
            TesekkurAlanOgrenciler();
        }
        private void btnListIlisikKesilen_Click(object sender, EventArgs e)
        {
            IlisigiKesilenOgrenci();
        }
    }
}