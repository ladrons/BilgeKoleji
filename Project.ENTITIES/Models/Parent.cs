using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Parent : BaseEntity
    {
        public Parent()
        {
            Role = UserRole.Parent;
        }

        public string Firstname { get; set; } // İsim
        public string Lastname { get; set; } // Soyisim
        public string HomePhonee { get; set; } // Ev telefonu
        public string WorkPhonee { get; set; } // İş telefonu
        public string Address { get; set; } // Ev adresi
        public string Province { get; set; } // Province : İl
        public string District { get; set; } // District : İlçe

        public string UserName { get; set; } // WebUI için kullanıcı adı
        public string Password { get; set; } // WebUI için giriş şifresi

        public UserRole Role { get; set; }


        //Relational Properties

        public virtual List<Student> Students { get; set; }
    }
}
