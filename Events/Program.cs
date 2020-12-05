using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardDisks = new Product(20);
            hardDisks.ProductName = "Toshiba";

            //--> Delegelerde yapıldığı gibi bu ürünü abone ediyoruz.
            Product mobilePhones = new Product(20);
            mobilePhones.ProductName = "Samsung";
            mobilePhones.StockControlEvent += MobilePhones_StockControlEvent;// Bkz:delegates

            for (int i = 0; i < 10; i++)
            {
                hardDisks.Sell(1);
                mobilePhones.Sell(1);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        //--> mobilePhone event'e abone edildiğinde otomatik olarak imlemente edilir.
        private static void MobilePhones_StockControlEvent()
        {
            Console.WriteLine("Stock about to finish!!");
        }
    }

    /*
        Programın çalışma esnasında beklenen ya da olağan dışı bir durum gerçekleştiğinde
       aktive olan, birbirinden bağımsız olarak farklı sınıflar için abone olunabilen yapılardır.
       
        -> Bir mağaza envanterinde event'e abone edilmiş ürünün stok durumunu kontrol etme.
        --> Interupt
        
        NOT: EVENTLER aslında bir delege dir. 
    */
    public delegate void StockControl(); //--> delege tanımlandı
    internal class Product
    {
        public event StockControl StockControlEvent; //--> event tanımlandı. 

        private int _stock;
        public Product(int stock) //--> stock miktarını kurucu metot ile aldık
        {
            _stock = stock;
        }

        //Product Sınıfının Property leri
        public string ProductName { get; set; }
        //public int Stock { get; set; } //--> Event olmasaydı bu şekilde kullanılırdı

        //--> Stock durumu evente abone ediliyor
        public int Stock
        {
            get { return _stock; } //--> Set edilmiş değer döndürülüyor
            set
            {
                _stock = value;//--> stock'a gelen DEĞER set ediliyor.
                //--> Üründen 15ten az kaldı ise ve evente abone olunduysa
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        //--> burada normalde sadece proporty ler tutulur. Uygulama basitliği için yazıldı.
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine(ProductName + " stock: {0}", Stock);
        }
    }
}
