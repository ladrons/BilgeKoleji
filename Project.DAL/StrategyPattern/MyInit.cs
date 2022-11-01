using Project.COMMON.Tools;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        // Program ilk defa çalıştırıldığında DB'de olması gereken verileri yaratması için 'Seed' Metodunu kullanacağız.

        protected override void Seed(MyContext context)
        {
            #region Sınıflar

            // Her dersliğin hem şube adı olacak hemde sınıf numarası. (ÖRNEK => 1.Sınıf 9-A)

            // Şube kodu ve sayısı için array oluşturacağım.

            string[] subeSayilari = { "9", "10", "11", "12" }; // 9.Sınıftan 12.Sınıfa kadar olacak.
            string[] subeKodlari = { "A", "B", "C", "D", "E", "F", "G" }; // Her sınıftan toplam da 7 tane olacak.

            int _veri = 0; // Bu değişken ile şube kodunun hangisi olacağını belirleyeceğiz. (0 => A oluyor)

            for (int i = 1; i < 29; i++)
            {
                Classroom classroom = new Classroom();

                if (i >= 1 && i <= 7)
                {
                    classroom.Class = "1.Sınıf";
                    classroom.Section = $"{subeSayilari[0]}-{subeKodlari[_veri]}";

                    _veri++;

                    context.Classrooms.Add(classroom);
                    context.SaveChanges();

                    if (i == 7)
                    {
                        _veri = 0;
                    }
                }
                else if (i >= 8 && i <= 14)
                {
                    classroom.Class = "2.Sınıf";
                    classroom.Section = $"{subeSayilari[1]}-{subeKodlari[_veri]}";

                    _veri++;

                    context.Classrooms.Add(classroom);
                    context.SaveChanges();

                    if (i == 14)
                    {
                        _veri = 0;
                    }
                }
                else if (i >= 15 && i <= 21)
                {
                    classroom.Class = "3.Sınıf";
                    classroom.Section = $"{subeSayilari[2]}-{subeKodlari[_veri]}";

                    _veri++;

                    context.Classrooms.Add(classroom);
                    context.SaveChanges();

                    if (i == 21)
                    {
                        _veri = 0;
                    }
                }
                else if (i >= 22 && i <= 28)
                {
                    classroom.Class = "4.Sınıf";
                    classroom.Section = $"{subeSayilari[3]}-{subeKodlari[_veri]}";

                    _veri++;

                    context.Classrooms.Add(classroom);
                    context.SaveChanges();

                    if (i == 28)
                    {
                        _veri = 0;
                    }
                }
            }
            #endregion

            #region Dersler

            string[] dersIsimleri = { "Analitik Geometri", "Beden Eğitimi", "Bilim Tarihi", "Bilgisayar", "Biyoloji", "Uygulamalı Biyoloji", "Çevre ve İnsan İlişkisi", "Çoğrafya", "Demokrasi ve İnsan Hakları", "Din Kültürü ve Ahlak Bilgisi" };

            string[] dersKodlari = { "ANGE.1", "BİLG.1", "BİLTA.1", "BİY.1", "BİY.2", "BİY.3", "BİYU.1", "ÇEVİN.1", "ÇOĞ.1", "DEM.1", "DKAB.1", "DKAB.2" };

            for (int i = 0; i < 10; i++)
            {
                Lesson lesson = new Lesson();

                lesson.LessonName = dersIsimleri[i];

                context.Lessons.Add(lesson);
                context.SaveChanges();

                switch (lesson.LessonName)
                {
                    case "Beden Eğitimi":
                        for (int j = 0; j < 3; j++)
                        {
                            SubLesson bedenEgitimi = new SubLesson();
                            bedenEgitimi.SubLessonName = dersIsimleri[1];
                            bedenEgitimi.LessonID = lesson.ID;

                            context.SubLessons.Add(bedenEgitimi);
                            context.SaveChanges();
                        }
                        break;

                    case "Biyoloji":
                        for (int j = 3; j < 6; j++)
                        {
                            SubLesson biyoloji = new SubLesson();
                            biyoloji.SubLessonName = dersIsimleri[4];
                            biyoloji.SubLessonCode = dersKodlari[j];
                            biyoloji.LessonID = lesson.ID;

                            context.SubLessons.Add(biyoloji);
                            context.SaveChanges();
                        }
                        break;

                    case "Din Kültürü ve Ahlak Bilgisi":

                        for (int j = 10; j < 12; j++)
                        {
                            SubLesson dinKulturu = new SubLesson();
                            dinKulturu.SubLessonName = dersIsimleri[9];
                            dinKulturu.SubLessonCode = dersKodlari[j];
                            dinKulturu.LessonID = lesson.ID;

                            context.SubLessons.Add(dinKulturu);
                            context.SaveChanges();
                        }
                        break;
                }
            }
            #endregion

            #region Branşlar ve Öğretmenler

            string[] ogretmenler = { "Halil KAHYA", "Kerim ÖZDER", "Mine KAHYA", "Mustafa ÇETİNKAYA", "Sevim KOZAL", "Nusret BEYDOĞAN", "Sevcan ÖZEN" };

            string[] bransIsimleri = { "Türk Dili ve Edebiyatı", "Beden Eğitimi", "Tarih", "Din Bilgisi", "Çoğrafya", "Matematik", "Biyoloji" };

            for (int i = 0; i < 7; i++)
            {
                Branch branch = new Branch();

                branch.StudyName = bransIsimleri[i];
                context.Branches.Add(branch);

                //--//

                string[] parcalar = ogretmenler[i].Split(' ');

                Teacher teacher = new Teacher();

                teacher.Firstname = parcalar[0];
                teacher.Lastname = parcalar[1];
                teacher.Branch = branch;

                teacher.UserName = $"{parcalar[0]}0{parcalar[0].Length}".ToLower();

                //ToDo: Alt kısım kontrol edilecek (Şifreleme ve username işlemleri)

                string cryptPass = MyCrypt.Crypt($"{DateTime.Now.Year}bilge{parcalar[0]}");
                teacher.Password = cryptPass.ToLower();

                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
            #endregion

            #region TestIcin

            //Semester semester = new Semester();

            //semester.SemesterName = "22 - 23 Güz Dönemi";
            //semester.StartingDate = DateTime.Now;
            //semester.EndingDate = Convert.ToDateTime("08.07.2022");

            //context.Semesters.Add(semester);

            ////--//

            //Parent parent = new Parent();

            //parent.Firstname = "Fatma";
            //parent.Lastname = "Durusu";

            //context.Parents.Add(parent);

            ////--//

            //Student student = new Student();

            //student.ParentID = parent.ID;

            //student.SchoolNumber = "100-22";

            //student.Firstname = "Kadir";
            //student.Lastname = "Durusu";
            //student.Gender = "Erkek";

            //student.GraduateSchoolName = "Test Verisidir.";
            //student.GradeAverage = 1.1M;
            //student.ClassroomID = 1;

            //context.Students.Add(student);

            ////--//

            //Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    ExamGrade examGrade = new ExamGrade();

            //    examGrade.StudentID = student.ID;
            //    examGrade.SemesterID = semester.ID;

            //    examGrade.LessonName = dersIsimleri[i];

            //    examGrade.FirstResult = rnd.Next(0, 101);
            //    examGrade.SecondResult = rnd.Next(0, 101);
            //    examGrade.ThirdResult = rnd.Next(0, 101);

            //    examGrade.LessonAverage = rnd.Next(55, 101);

            //    context.ExamGrades.Add(examGrade);
            //}
            #endregion
        }
    }
}


