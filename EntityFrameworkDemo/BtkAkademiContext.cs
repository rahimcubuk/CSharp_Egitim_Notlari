using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class BtkAkademiContext : DbContext
    {
        /*Class ı oluşturduktan sonra "public DbSet<Product> Products { get; set; }"
         * generic'i oluşturulur. Bu generic eklenen DB de Products tablosunu arar.
         * 
         */
        public DbSet<Product> Products { get; set; } 
    }
}
