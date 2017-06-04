using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface IContactService
    {
        IQueryable<tbl_Contact> getAllContact();
        void add(tbl_Contact item);
        void delete(int id);
        void update(tbl_Contact item);
    }
    public class ContactService : IContactService
    {
        ContactRepository rep = new ContactRepository();
        vikingEntities db = new vikingEntities();

        public IQueryable<tbl_Contact> getAllContact()
        {
            return db.tbl_Contact.AsQueryable();
        }
        public void add(tbl_Contact item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Contact item)
        {
            rep.update(item);
        }
    }
}
