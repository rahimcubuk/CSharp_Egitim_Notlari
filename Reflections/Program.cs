using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Calculator calculator = new Calculator(2,3);
            calculator.Sum(5, 5);
            calculator.Minus();
            //--> Bu kodları tamamen programın çalışma anında yaptırabiliriz. Bu "Reflection" olur.
            */

            // REFLECTION
            var type = typeof(Calculator);

            //Calculator calculator = (Calculator)Activator.CreateInstance(type,2,3); //--> Calculator calculator = new Calculator(2,3);
            //Console.WriteLine(calculator.Sum(5, 5));
            //Console.WriteLine(calculator.Minus());
            var instance = Activator.CreateInstance(type,10,2); // instance oluşturduk
            /*
                oluşturulan instance'a ait metotları get methot ile çağırdık.
                invoke ile çağırılan metodu çalıştırdık.
            */
            MethodInfo methodInfo = instance.GetType().GetMethod("Minus");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("================================================================");
            /*
             Reflection ile bir sınıfa ait metotlarına, özelliklerine, attribute'larına liste halinde 
             ulaşılabilir.
             */

            var methods = type.GetMethods();
            foreach (var methodName in methods)
            {
                Console.WriteLine();
                Console.WriteLine("Name of Method : {0}", methodName.Name); //--> Metot isimleri
                foreach (var parameters in methodName.GetParameters())
                {
                    Console.WriteLine("Parameter Names: {0}", parameters.Name); //--> Metot isimleri
                }
                Console.WriteLine();
                foreach (var attribute in methodName.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Names: {0}", attribute.GetType().Name);
                }
                Console.WriteLine();
                Console.WriteLine("================================================================");
            }

            Console.WriteLine("================================================================");
            Console.ReadKey();
        }
    }

    internal class Calculator
    {
        private int _N1, _N2;
        public Calculator(int N1, int N2)
        {
            _N1 = N1;
            _N2 = N2;
        }
        [MetodName("Topla")]
        public int Sum(int N1, int N2)
        {
            return N1 + N2;
        }
        [MetodName("Çarp")]
        public int Multiply()
        {
            return _N1 * _N2;
        }
        [MetodName("Böl")]
        public int Divide(int N1, int N2)
        {
            return (N2 != 0 ? N1 / N2 : 0);
        }
        [MetodName("Çıkar")]
        public int Minus()
        {
            return _N1 - _N2;
        }
    }

    internal class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
