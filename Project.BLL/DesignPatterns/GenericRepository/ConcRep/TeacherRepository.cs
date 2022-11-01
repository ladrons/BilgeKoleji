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
    public class TeacherRepository : BaseRepository<Teacher>
    {
        public IQueryable<TeacherDTO> GetTeacher(Expression<Func<Teacher, TeacherDTO>> exp)
        {
            return _db.Teachers.Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted && x.Branch != null).Select(exp);
        }
    }
}
