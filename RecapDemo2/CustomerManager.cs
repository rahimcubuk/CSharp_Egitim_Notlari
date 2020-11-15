using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
        Console.WriteLine("Customer added!");
            Logger.Log();
        }
    }
}
