using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class AbsenteeismRepository: BaseRepository<Absenteeism>
    {
        /// <summary>
        /// Seçili öğrencinin sistemde kayıtlı olan 'Özürlü' devamsızlığın toplam sayısını listeler (Aktif yıl için).
        /// </summary>
        /// <param name="studentID">Seçili öğrenci ID</param>
        /// <returns>ExcusedCount List</returns>
        public List<int> GetExcusedCount(int studentID)
        {
            return Where(x => x.StudentID == studentID && x.AbsencesStatus == ENTITIES.Enums.AbsencesStatus.Excused && x.Status != ENTITIES.Enums.DataStatus.Deleted).Select(x => x.AbsencesCount).ToList();
        }

        /// <summary>
        /// Seçili öğrencinin sistemde kayıtlı olan 'Özürsüz' devamsızlığın toplam sayısını listeler (Aktif yıl için).
        /// </summary>
        /// <param name="studentID">Seçili öğrenci ID</param>
        /// <returns>Unexcused List</returns>
        public List<int> GetUnexcusedCount(int studentID)
        {
            return Where(x => x.StudentID == studentID && x.AbsencesStatus == ENTITIES.Enums.AbsencesStatus.Unexcused && x.Status != ENTITIES.Enums.DataStatus.Deleted).Select(x => x.AbsencesCount).ToList();
        }
    }
}
