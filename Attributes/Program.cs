using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            //--> Hata verir çünkü eski olduğunu [Obsolute] ile belirttik
            customerDal.Add(new Customer
            {
                Id = 1,
                FirstName = "Rahim",
                City = "Manisa",
                Age = 26
            });

            Console.ReadKey();
        }
    }
    [ToTable("Customers")] //--> Bu class Veritabanında Customers tablosuyla çalışır
    internal class Customer
    {
        [RequiredProperty] //--> Boş bırakamazsın "Not Null"
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
    internal class CustomerDal
    {
        [Obsolete("Dont use Add, instead use Add2 Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!",
                customer.Id, customer.FirstName, customer.City, customer.Age);
        }
        public void Add2(Customer customer)
        {
            //--> Var olan Add metodunun haricinde yeni bir Add metodu oluşturuldu.
            //--> Projenin devamında bu kullanılacak fakat ilk oluşturulan metot kalmak zorunda.
            //--> Bu durumda Add() metoduna [Obsolete] attribut'u eklenir.
        }
    }

    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)] //interface ve class için geçerli demek
    [AttributeUsage(AttributeTargets.Class)]
    internal class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }
    //--> Bu ettribute'un kullanımını sınırlar. Property nesne için demek
    //--> allowMultiple ile çoklu kullanıma izin verilir ya da verilmez
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] 
    internal class RequiredPropertyAttribute : Attribute
    {
    }

   
    
}
