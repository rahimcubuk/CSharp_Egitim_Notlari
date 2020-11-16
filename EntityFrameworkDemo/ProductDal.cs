using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

/* * Contxt bellek için pahalıdır. "using" ile oluşturulan nesne sistemin silmesini beklemeden
 * direk işi bitince silinir.
 * */

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetProducts()
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                return context.Products.ToList();
            }
        }
        public Product GetProducts(int id)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                return context.Products.SingleOrDefault(x => x.Id == id);
            }
        }
        public List<Product> GetProducts(string key)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                return context.Products.Where(x => x.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetProducts(decimal minKey, decimal maxKey)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                return context.Products.Where(x => x.UnitPrice >= minKey && x.UnitPrice <= maxKey).ToList();
            }
        }
        public void Add(Product product)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                /*
                 //var entity gönderilen bilgilerdeki product'ı veritabanında bulur
                var entity = context.Entry(product);
                entity.State = EntityState.Added; // gönderilen nesneyi ekler
                 */
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                //var entity gönderilen bilgilerdeki product'ı veritabanında bulur
                context.Entry(product).State = EntityState.Modified; // bulunan nesneyi modifiye eder
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                //var entity gönderilen bilgilerdeki product'ı veritabanında bulur
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted; // bulunan nesneyi siler
                context.SaveChanges();
            }
        }
    }
}
