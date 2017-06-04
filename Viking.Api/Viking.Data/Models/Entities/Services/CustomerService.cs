using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface ICustomerService
    {
        IQueryable<tbl_Customer> getAllCustomers();
        tbl_Customer GetCustomerById(int cusId);
        void add(tbl_Customer item);
        void delete(int id);
        void update(tbl_Customer item);
    }
    public class CustomerService : ICustomerService
    {
        CustomerRepository rep = new CustomerRepository();
        vikingEntities db = new vikingEntities();

        public IQueryable<tbl_Customer> getAllCustomers()
        {
            return db.tbl_Customer.AsQueryable();
        }
        public void add(tbl_Customer item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Customer item)
        {
            rep.update(item);
        }

        public tbl_Customer GetCustomerById(int cusId)
        {
            return db.tbl_Customer.Where(a => a.CusId == cusId).FirstOrDefault();
        }
    }
}
