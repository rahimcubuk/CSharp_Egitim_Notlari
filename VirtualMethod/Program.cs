using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int selector = 2;
            SqlServer sqlServer = new SqlServer();
            OracleServer oracleServer = new OracleServer();

            sqlServer.Add(selector);
            oracleServer.Delete();

            Console.ReadLine();
        }
    }
}
