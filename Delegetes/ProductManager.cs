using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegetes
{
    public class ProductManager
    {
        public void Add(string productName)
        {
            Console.WriteLine("{0} added.", productName);
        }
    }
}
