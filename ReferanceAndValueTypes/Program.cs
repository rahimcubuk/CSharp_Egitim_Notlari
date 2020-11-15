using System;

namespace ReferanceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            int n1 = 10;
            int n2 = 20;
            n2 = n1;
            n1 = 50;

            //n1'in son ataması ile n2'nin değeri değişmez. n2 = 10, n1 = 50dir.
            Console.WriteLine("n1 = {0}, n2 = {1}",n1,n2);

            //referance type
            string[] cities1 = new string[] { "Ankara", "Adana", "Antalya" }; // ref. no: 100 (ex)
            string[] cities2 = new string[] { "Bursa", "Bolu", "Bartın" };// ref. no: 101 (ex)

            cities2 = cities1; //değerler değil referans atanır. cities2'nin referansı artık 100'dür.
            for (int i = 0; i <= cities2.GetUpperBound(0); i++)
            {
                Console.Write(cities2[i] + " ");
            }
            Console.WriteLine();
            cities1[0] = "Bolu";
            for (int i = 0; i <= cities2.GetUpperBound(0); i++)
            {
                Console.Write(cities2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
