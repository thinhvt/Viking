using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Repository
{
    interface IStudentSubjectsRepository
    {

    }
    class StudentSubjectsRepository : BaseRepository<Student_Subjects>, IStudentSubjectsRepository
    {
    }
}
