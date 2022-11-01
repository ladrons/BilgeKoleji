using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class StudentAverageRepository : BaseRepository<StudentAverage>
    {
        public StudentAverage FindStudentAverage(int firstId, int secondId)
        {
            return _db.StudentAverages.Find(firstId, secondId);
        }

        //ToDo: Test aşamasında 001
        public StudentAverage FindNotDeletedStudentAverage(int firstId, int secondId)
        {
            StudentAverage dbAverage = _db.StudentAverages.Find(firstId, secondId);

            if (dbAverage != null)
            {
                if (dbAverage.Status != ENTITIES.Enums.DataStatus.Deleted) return dbAverage;
                return null;
            }
            return null;
        }

        public void UpdateStudentAverage(StudentAverage item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            StudentAverage toBeUpdated = FindStudentAverage(item.YearID, item.StudentID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
    }
}
