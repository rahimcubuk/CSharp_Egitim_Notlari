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
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities(); // projelerde genel bir isim. string sırala vs vs gibi basit işlemlerin tolandığı class.
            List<string> result = utilities.BuildList("A", "B", "C"); // verdiğim stringleri bir list e çeviriyor.

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(
                new Customer
                {
                    FirstName = "Rahim"
                },
                new Customer
                {
                    FirstName = "Rıdvan"
                },
                new Customer
                {
                    FirstName = "Hacer"
                } ); // verilen 2 customer nesnesini liste yapar.

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadKey();
        }
    }
}
