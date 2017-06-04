using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface IAccountService
    {
        List<tbl_Account> getAllAccount();
        void add(tbl_Account item);
        void delete(int id);
        void update(tbl_Account item);
        IQueryable<tbl_Account> FindUserByIdAndPassword(string id, string password);
    }
    public class AccountService : IAccountService
    {
        AccountRepository rep = new AccountRepository();
        vikingEntities db = new vikingEntities();

        public List<tbl_Account> getAllAccount()
        {
            return rep.getAll();
        }
        public void add(tbl_Account item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        } 

        public void update(tbl_Account item)
        {
            rep.update(item);
        }

        IQueryable<tbl_Account> IAccountService.FindUserByIdAndPassword(string id, string password)
        {
            return db.tbl_Account.Where(a => a.accountId == id && a.accountPass == password);
        }
    }
}
