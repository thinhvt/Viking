using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface IProductService
    {
        List<tbl_Product> getAllProducts();
        void add(tbl_Product item);
        void delete(int id);
        void update(tbl_Product item);
    }
    public class ProductService
    {
        ProductRepository rep = new ProductRepository();

        public List<tbl_Product> getAllProducts()
        {
            return rep.getAll();
        }
        public void add(tbl_Product item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Product item)
        {
            rep.update(item);
        }
    }
}
