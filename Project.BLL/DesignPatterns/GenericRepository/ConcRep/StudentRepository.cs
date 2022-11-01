using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.DTO.WinUI;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class StudentRepository:BaseRepository<Student>
    {
        public IQueryable<WithoutClassStudentDTO> GetWithoutClass(Expression<Func<Student, WithoutClassStudentDTO>> exp)
        {
            return _db.Students.Where(x => x.ClassroomID == null).Select(exp);
        }
    }
}