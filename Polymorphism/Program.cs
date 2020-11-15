using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDAL[] customerDals = new ICustomerDAL[2]
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
}
