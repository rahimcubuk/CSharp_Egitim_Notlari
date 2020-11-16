using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * IRepository den farklı olarak ortak olmayan sadece müşteriye ya da ürüne özel olan metotlar buraya
 * eklenir. CustomerDal'a imlemente edilir.
 * // :IRepository<Customer> içeriye sadece customer yazılmalı
 *      Bunu sağlamak için IRepository e where konulur.
 */
namespace Generics
{
    //--> Burada hata veriyor çünkü veritabanı nesnesini tutan Customer.cs class'ı "IEntity"'den imlemente edilmedi
    interface ICustomerDal : IRepository<Customer> 
    {
        void BestCustomer();
    }
}
