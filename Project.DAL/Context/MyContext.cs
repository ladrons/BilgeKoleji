using Project.DAL.StrategyPattern;
using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbsenteeismMap());
            modelBuilder.Configurations.Add(new AnnouncementMap());
            modelBuilder.Configurations.Add(new ClassroomMap());
            modelBuilder.Configurations.Add(new DocumentMap());
            modelBuilder.Configurations.Add(new ExamGradeMap());
            modelBuilder.Configurations.Add(new HomeworkMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new LessonMap());
            modelBuilder.Configurations.Add(new LessonInClassroomMap());
            modelBuilder.Configurations.Add(new ParentMap());
            modelBuilder.Configurations.Add(new SemesterMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new SubLessonMap());
            modelBuilder.Configurations.Add(new TeacherMap());
            modelBuilder.Configurations.Add(new TeacherAndClassroomMap());
            modelBuilder.Configurations.Add(new StudentAverageMap());
            modelBuilder.Configurations.Add(new YearMap());
        }
        public DbSet<Absenteeism> Absenteeisms { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ExamGrade> ExamGrades { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonInClassroom> LessonInClassrooms { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubLesson> SubLessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherAndClassroom> TeachersAndClassrooms { get; set; }
        public DbSet<StudentAverage> StudentAverages { get; set; }
        public DbSet<Year> Years { get; set; }
    }
}
