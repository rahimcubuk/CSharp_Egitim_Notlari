using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Database
    {
        public virtual void Add(int data)
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
        public virtual void Update()
        {
            Console.WriteLine("Updated by Default");
        }
    }
}
