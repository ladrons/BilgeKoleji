using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Teacher : BaseEntity
    {
        public Teacher()
        {
            Role = UserRole.Teacher;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string UserName { get; set; } //Web portal için yaratıldı. Bu kısım öğretmen kaydedildiğinde otomatik oluşturulacak.
        public string Password { get; set; } //Web portal kısmı için kullanılacaktır. //ToDo: Öğretmen yaratılırken şifre belirlenmeli (Yüksek öncelik)
        public UserRole Role { get; set; }

        public int? BranchID { get; set; }
        public int? LessonID { get; set; }

        //Relational Properties

        public virtual Announcement Announcement { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual List<TeacherAndClassroom> TeachersAndClassrooms { get; set; }
        public virtual List<TeacherSyllabus> TeacherSyllabi { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
