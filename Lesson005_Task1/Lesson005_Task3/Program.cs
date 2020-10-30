using System;

namespace Lesson005_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("У нашої бабусі, Сидить дід в кожусі, Проти печі гріється,Без води умиється.");
            string answer = "Cat";
            
            int i = 0;
            while (i <5)
            {
                i++;
                string enter = Console.ReadLine();
                if (enter == answer || enter == "cat" || enter == "CAT" || enter == "cAt" || enter == "CaT" || enter == "caT" || enter == "cAT" || enter == "CAt")
                {
                    Console.WriteLine("You are right!");
                    break;
                }
                else
                {
                    Console.WriteLine("You are not right, try again!");
                    continue;

                }
            }
        }
    }
}
