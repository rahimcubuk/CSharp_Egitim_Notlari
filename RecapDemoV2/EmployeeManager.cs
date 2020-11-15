using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoV2
{
    class EmployeeManager:BaseClass
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger, string entity) : base(entity)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!!");
            Message();
        }
    }
}
