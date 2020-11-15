using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            List<string> student = new List<string> { "Rahim", "Elif", "Rıdvan", "Hacer" };

            try
            {
                Find(student);
            }
            catch (RecordNotFoundException exceptions)
            {
                Console.WriteLine(exceptions.Message);
            }

            // Bir metodu parametre olarak göndermeye yarar
            // try-catch bloğunu tekrardan kurtarmak için merkezi bir metot oluşturup
            // tüm metotları oluşturulan bu merkezi try-catch bloğunda çalıştırabiliriz.
            HandleException(() => 
            {
                Find(student);
            });

            Console.ReadKey();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find(List<string> student)
        {
            if (!student.Contains("Ahmet")) // list içerisinde ahmet kaydı var mı?
            {
                throw new RecordNotFoundException("Record not Found!!");
            }
            else Console.WriteLine("record found!");
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] student = new string[4]
                {
                    "Rahim", "Elif","Rıdvan","Hacer"
                };
                student[4] = "";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Hata! " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Hata! ");
            }
        }
    }
}
