using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer {ID=1 ,Name="Rahim", City="Manisa" },
                new Student {ID=1, Name="Rıdvan", Depertmant="Tarih" },
                new Person {ID=1, Name="Hacer" }
            };
            foreach (var item in persons)
            {
                Console.WriteLine(item.ID + " " + item.Name + " ");
            }
            Console.ReadKey();
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Depertmant { get; set; }
    }
}
