using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoV2
{
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged!!");
        }
    }
}
