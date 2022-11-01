using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class DocumentRepository:BaseRepository<Document>
    {
        public Document FindDocument(int firstId, int secondId)
        {
            return _db.Documents.Find(firstId, secondId);
        }
    }
}
