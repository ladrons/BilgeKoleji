using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.API.Controllers
{
    public class TeacherSyllabusController : ApiController
    {
        TeacherSyllabusRepository _teacherSyllabusRep;

        public TeacherSyllabusController()
        {
            _teacherSyllabusRep = new TeacherSyllabusRepository();
        }

        [HttpGet]
        public List<DTO.API.TeacherSyllabusDTO> TeacherSyllabi() //ToDo: Öğretmenin isim ve soyisim bilgisin getirtmek için bir şeyler düşünülebilir.
        {
            return _teacherSyllabusRep.Select<DTO.API.TeacherSyllabusDTO>(x => new DTO.API.TeacherSyllabusDTO
            {
                TeacherName = x.Teacher.Firstname,
                LessonName = x.LessonName,
                Day = x.Day,

                ClassOne = x.ClassOne,
                ClassTwo = x.ClassTwo,
                ClassThree = x.ClassThree,
                ClassFour = x.ClassFour,
                ClassFive = x.ClassFive,
                ClassSix = x.ClassSix,
                ClassSeven = x.ClassSeven,
                ClassEight = x.ClassEight,

            }).ToList();
        }
    }
}
