using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Repository
{
    interface ILecturerSubjectsRepository
    {

    }
    class LecturerSubjectsRepository : BaseRepository<Lecturer_Subjects>, ILecturerSubjectsRepository
    {
    }
}
