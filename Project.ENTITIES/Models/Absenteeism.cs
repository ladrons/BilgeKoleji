using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Absenteeism:BaseEntity
    {
        //ToDo: Toplam devamsızlık sayısını tutmak için bir değişken eklenebilir. Yıl sonunda değişken güncellenerek 0 a geri çekilir.

        public DateTime StartingDate { get; set; } //Devamsızlığın başlangıç tarihi
        public DateTime EndingDate { get; set; } //Devamsızlığın bitiş tarihi
        public string Description { get; set; } //Devamsızlık hakkında bilgi.
        public int AbsencesCount { get; set; } //Devamsızlığın gün sayısı

        public string DataEntryPerson { get; set; } //Bu properties veriyi kimin kaydettiğini anlamamız için tanımlanmıştır. (Windows tarafından kayıtlarda 'Sistem' yazacak Web tarafındaki işlemlerde işlemi yapan öğretmenin UserName'i yazacak.)

        public AbsencesStatus AbsencesStatus { get; set; }


        public int StudentID { get; set; }

        //Relational Properties

        public virtual Student Student { get; set; }
    }
}
