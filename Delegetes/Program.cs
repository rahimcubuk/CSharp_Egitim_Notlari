using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegetes
{
    //public delegate void MyDelegete(); //--> parametre almayan ve void döndüren metotlara delege'lik yapar
    class Program
    {
        static void Main(string[] args)
        {
            DelegeteTester delegete = new DelegeteTester();
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();
            Console.WriteLine("=============================================================");
            //Delege Kullanmak
            /*
             Birbirini takip eden işlemler için kolaylık sağlar. Bir delegeye atanan metotlar delege her çağrıldığında atama sırasıyla çalışır. 
             Bu sayede birbirini takip eden işlemlerde her seferinde elle metotları çağırmak yerine sadece 1 delege çağrılarak kod kalabalığı
             da engellenmiş olur.
             */
            //MyDelegete myDelegete = customerManager.Add;
            //myDelegete += customerManager.SendMessage;
            //myDelegete += customerManager.ShowAlert;
            //myDelegete();
            delegete.CustomerDelegete();
            Console.ReadKey();
        }
    }
}
