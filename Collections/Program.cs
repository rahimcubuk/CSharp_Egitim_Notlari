using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Dizilerde eleman sayısı ve referans değeri sabit olduğundan dolayı index'i aşmak istediğimizde
 * problem yaşarız. Bunun önüne geçmek için collections kullanılır.
 */
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ID = new int[3] { 1, 2, 3 }; // an array

            //collections
            ArrayListCollections();
            Console.WriteLine("==================================================");

            ListCollections();
            Console.WriteLine("==================================================");

            ListCollectionsExample();
            Console.WriteLine("==================================================");

            // Dictionary<anahtarTürü,DeğerTürü>
            DictionaryExample();
            Console.WriteLine("==================================================");

            Console.ReadKey();
        }

        private static void DictionaryExample()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("dictionary", "sözlük");

            Console.WriteLine(dictionary["table"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            string data = Console.ReadLine();
            Console.WriteLine((dictionary.ContainsKey(data) ? dictionary[data] : "Bulunamadı!"));
        }

        private static void ListCollectionsExample()
        {
            //List<Customers> customers = new List<Customers>();

            //customers.Add(new Customers { ID = 1, FirstName = "Rahim" });
            //customers.Add(new Customers { ID = 2, FirstName = "Elif" });
            //customers.Add(new Customers { ID = 0, FirstName = "ListCollectionExample" });

            List<Customers> customers = new List<Customers>
            {
                new Customers { ID = 1, FirstName = "Rahim" },
                new Customers { ID = 2, FirstName = "Elif" },
                new Customers { ID = 0, FirstName = "ListCollectionExample" }
            };

            /*
            // list collection'a bir dizi eklemek istersek
            customers.AddRange(new Customers[2] 
            {
                new Customers { ID = 3, FirstName = "Rıdvan" },
                new Customers { ID = 4, FirstName = "Hacer" }
            });
            */

            //customers.Clear(); // list i temizler

            foreach (var item in customers)
            {
                Console.WriteLine(item.ID+" "+item.FirstName);
            }
        }

        private static void ListCollections()
        {
            List<string> cities = new List<string>(); //tip güvenli collections
            cities.Add("Ankara");
            cities.Add("Manisa");
            cities.Add("ListArray");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }

        private static void ArrayListCollections()
        {
            ArrayList col_array = new ArrayList();
            col_array.Add(1);
            col_array.Add("Rahim");
            col_array.Add("ArrayList");

            foreach (var item in col_array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
