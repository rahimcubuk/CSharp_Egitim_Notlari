using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoV2
{
    class JsonLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Json Logged!!");
        }
    }
}
