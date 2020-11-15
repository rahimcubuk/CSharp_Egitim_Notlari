using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new JsonLogger(), "Message");
            employeeManager.Add();
            Console.ReadKey();
        }
    }
}
