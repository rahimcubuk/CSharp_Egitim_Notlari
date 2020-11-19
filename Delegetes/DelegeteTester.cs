using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegetes
{
    public delegate void MyDelegete(); //--> parametre almayan ve void döndüren metotlara delege'lik yapar
    public delegate void MyDelegeteParams(string text);//--> parametre olarak 1 string alan void döndüren metotlara delegellik eder
    public class DelegeteTester 
    {
        CustomerManager _customerManager = new CustomerManager();
        ProductManager _productManager = new ProductManager();
        public void CustomerDelegete()
        {
            MyDelegeteParams customerDelegeteParams = _customerManager.Add;
            customerDelegeteParams("Rahim");

            MyDelegeteParams productDelegeteParams = _productManager.Add;
            productDelegeteParams("Monster PC");

            MyDelegete customerDelegete = _customerManager.Add;
            customerDelegete += _customerManager.SendMessage;
            customerDelegete += _customerManager.ShowAlert;
            customerDelegete();
        }
    }
}
