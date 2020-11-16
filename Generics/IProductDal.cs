using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    //--> Burada ICustomerDal'da olduğu gibi hata vermiyor. çünkü veritabanı nesnesini tutan Product.cs class'ı "IEntity"'den imlemente edildi.
    interface IProductDal : IRepository<Product>
    {
       
    }
}
