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
    public class LessonRepository : BaseRepository<Lesson>
    {
        public IQueryable<ListLessonDTO> GetLessonDTO(Expression<Func<Lesson, ListLessonDTO>> exp)
        {
            return _db.Lessons.Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).Select(exp);
        }
    }
}
