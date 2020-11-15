using System;
using System.Collections.Generic;

// Bir metodu parametre olarak göndermeye yarar
// try-catch bloğunu tekrardan kurtarmak için merkezi bir metot oluşturup
// tüm metotları oluşturulan bu merkezi try-catch bloğunda çalıştırabiliriz.

namespace HandleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects
            StudentManager studentManager = new StudentManager();

            //Values
            string data;
            List<string> student = new List<string> { "Rahim", "Elif" };

            //programs
            data = Console.ReadLine();
            HandleException.ThrowException(() => { studentManager.Find(student, data); });

            Console.ReadKey();
        }
    }
}
