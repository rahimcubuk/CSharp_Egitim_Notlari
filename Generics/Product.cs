using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
         Müşteri - Ürün - Çalışan gibi sınıfların kontrolünde benzer işleri yapan farklı metotları
         sürekli yazmak yerine(ICustomerDal, IProducDal...) tek bir Interface(IRepository) içerisinde 
         aynı görevi farklı nesnelere göre yapabilen metotlar tasarlayabiliriz. Bu interface'deki 
         metotlara ulaşmak istediğimizde göndereceğimiz nesteyi sadece müşteri ya da ürünle
         sınırlamayıp genel bir yapıya kavuşturmuş olduk.
         */

namespace Generics
{
    class Product : IEntity
    {
        
    }
}
