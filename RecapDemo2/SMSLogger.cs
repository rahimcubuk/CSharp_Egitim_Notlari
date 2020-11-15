using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class SmsLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS");
        }
    }
}
