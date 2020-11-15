using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleExceptions
{
    class StudentManager
    {
        public void Find(List<string> student, string data)
        {
            if (!student.Contains(data))
            {
                throw new RecordNotFound("Record not Found!!");
            }
            else Console.WriteLine("Record Find!");
        }
    }
}
