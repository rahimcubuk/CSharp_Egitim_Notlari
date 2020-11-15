using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
/* Contxt bellek için pahalıdır. "using" ile oluşturulan nesne sistemin silmesini beklemeden
            * direk işi bitince silinir.
            * */
namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetAll(string key)
        {
            using (BtkAkademiContext context = new BtkAkademiContext())
            {
                return context.Products.Where(x=>x.Name.Contains(key)).ToList();
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
                var entity = context.Entry(product);
                entity.State = EntityState.Modified; // bulunan nesneyi modifiye eder
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
