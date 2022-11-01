using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class ExamGradeRepository:BaseRepository<ExamGrade>
    {
        //public ExamGrade Find (int firstId, int secondId)
        //{
        //    return _db.Set<ExamGrade>().Find (firstId, secondId);
        //}
    }
}
