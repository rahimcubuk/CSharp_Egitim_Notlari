using System;

/*
    Neden Kullanırız: 
 */

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
             {
                new SQLServer(),
                new OracleServer()
             };

            foreach (var item in customerDals)
            {
                item.Add();
            }
            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
