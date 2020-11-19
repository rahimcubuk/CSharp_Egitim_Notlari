using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegetes
{
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Message Sended!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Successful!!");
        }
        public void Add()
        {
            Console.WriteLine("Customer Added!!");
        }
        public void Add(string Name)
        {
            Console.WriteLine("{0} Added!!",Name);
        }
    }
}

