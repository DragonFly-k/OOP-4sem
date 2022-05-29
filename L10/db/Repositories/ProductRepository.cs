using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L10.db.model;
using L10.db;

namespace L10.db.Repositories
{
    class ProductRepository : IDataService<Product>
    {
        private ApplicationContext _db;

        public ProductRepository(ApplicationContext db)
        {
            _db = db;
        }

        public Product Insert(Product entity)
        {
            return _db.Products.Add(entity);
        }

        public bool Delete(int id)
        {
            bool flag = false;

            var entity = _db.Products.Find(id);
            if (entity != null)
            {
                _db.Products.Remove(entity);
                flag = true;
            }

            return flag;
        }

        public Product GetById(int id)
        {
            return _db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products;
        }
        public Product Update(Product oldEntity, Product entity)
        {
            var dest = _db.Products.Find(oldEntity);
            dest.Name = entity.Name;
            dest.Weight = entity.Weight;
            dest.Qty = entity.Qty;

            return dest;
        }
    }
}