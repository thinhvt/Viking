using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Repository
{
    interface IStudentRepository
    {

    }
    class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
    }
}
