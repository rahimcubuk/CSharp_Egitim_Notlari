using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class SqlServer:Database
    {
        public override void Add(int data)
        {
            if (data == 1) base.Add(data);
            else Console.WriteLine("Added by SQL");
            
        }
    }
}
