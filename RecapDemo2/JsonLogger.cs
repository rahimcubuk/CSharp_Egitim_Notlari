﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class JsonLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Json");
        }
    }
}
