using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Student : BaseEntity
    {
        public Student()
        {
            ClassRepetitionCount = 0;

            Role = UserRole.Student;
            AttendanceStatus = GraduateStatus.Continues;
        }

        public string SchoolNumber { get; set; } // Öğrencinin okul numarası
        public string Firstname { get; set; } // Öğrenci adı
        public string Lastname { get; set; } // Öğrenci soyadı
        public string Gender { get; set; } // Cinsiyet
        public string GraduateSchoolName { get; set; } // Bir önceki mezun olduğu okulun adı
        public decimal GradeAverage { get; set; } // Mezun olduğu okulun not ortalaması
        public int ClassRepetitionCount { get; set; } // Öğrencinin kaç defa sınıf tekrarı yaptığını gösterir (Max 2)

        public string Password { get; set; }

        public GraduateStatus AttendanceStatus { get; set; } // Öğrencinin devam/mezun durumunu gösterir.
        public UserRole Role { get; set; }


        public int ParentID { get; set; }
        public int? ClassroomID { get; set; }


        //Relational Properties

        public virtual Parent Parent { get; set; }
        public virtual Classroom Classroom { get; set; }

        public virtual List<Absenteeism> Absenteeisms { get; set; }
        public virtual List<ExamGrade> ExamGrades { get; set; }
        public virtual List<Homework> Homeworks { get; set; }
        public virtual List<StudentAverage> StudentAverages { get; set; }
        public virtual List<Document> Documents { get; set; }
    }
}
