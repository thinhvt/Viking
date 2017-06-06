using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.Entities.Repositories
{
    interface IAccountRepository
    {
        //
    }
    class AccountRepository : BaseRepository<tbl_Account>, IAccountRepository
    {

    }
}
