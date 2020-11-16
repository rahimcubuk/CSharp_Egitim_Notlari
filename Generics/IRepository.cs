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

    - Çalışması için
    ICustomerDal ve IProducDal interfacelerini IRepository interface'inden kalıtmalısın.

    Ortak metotlar Burada toplanır
         */
//--> where T:class ile ICustomerDal kalıtılır iken verilen degerin sadece referans tip olması sağlanır.
//--> new() ile verilen referans tipin sadece new() ile nesne alınabilir olması sağlanır.
//--> Bu kontroller ile bu interface'in sadece bir class dan referans tip ile kalıtılması sağlanır.
//--> Bu kısıtlamanın bir adım ötesinde sadece veritabanı nesnesi ile çalışması isteniyor ise
    // veritabanı nesnesini tutan Product.cs, Customer.cs gibi sınıfların ":IEntity" den kalıtılmalı.
    // 
namespace Generics
{
    interface IRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
/*
  interface IRepository<T> where T:struct //--> bu şekilde kısıtlanır ise sadece değer tipi alır. 'int'
 */
