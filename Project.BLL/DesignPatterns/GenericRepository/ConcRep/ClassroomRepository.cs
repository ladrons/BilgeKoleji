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
    public class ClassroomRepository : BaseRepository<Classroom>
    {
        /// <summary>
        /// DB'de kayıtlı ilk sınıfları getirir.
        /// </summary>
        /// <returns></returns>
        public List<Classroom> GetFirstClassroom()
        {
            return Where(x => x.Class == "1.Sınıf").Where(x => x.Students.Count < 25).ToList();
        }

        /// <summary>
        /// DB'de kayıtlı son sınıfları getirir.
        /// </summary>
        /// <returns></returns>
        public List<Classroom> GetLastClassroom()
        {
            return Where(x => x.Class == "4.Sınıf").ToList();
        }

        public IQueryable<ListClassroomDTO> GetAllClassroomDTO(Expression<Func<Classroom,ListClassroomDTO>> exp)
        {
            return _db.Classrooms.Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).Select(exp);
        }
    }
}
