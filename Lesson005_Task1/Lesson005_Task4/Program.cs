using System;

namespace Lesson005_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            int counter = 4;
            int factorial = 1;
        
           
            Console.Write("Факторіал числа: {0}! ", counter);
            do
            {
                factorial *= counter--;
            
            }
            while (counter > 0);
            Console.WriteLine("{0}", factorial);
            int counter2 = 9;
            int factorial2 = 1;
            Console.Write("Факторіал числа: {0}! ",counter2);
            do
            {
              
                factorial2 *= counter2--;
            }
            while (counter2 > 0);

            Console.WriteLine("{0}",  factorial2);
            int res = factorial2 / factorial;
            Console.WriteLine("A = 9!/4! = {0}", res);
            Console.ReadKey();
        }
    }
}
