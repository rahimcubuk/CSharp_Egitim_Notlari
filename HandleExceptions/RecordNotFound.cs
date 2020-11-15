using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleExceptions
{
    class RecordNotFound : Exception
    {
        public RecordNotFound(string message) : base(message)
        {

        }
    }
}
