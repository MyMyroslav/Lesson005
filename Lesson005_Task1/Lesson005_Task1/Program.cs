using System;

namespace Lesson005_Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("Enter first number:");
                string A = Console.ReadLine();
                int first = int.Parse(A);
                Console.WriteLine("Enter second number:");
                string B = Console.ReadLine();
                int second = int.Parse(B);
                if (second < first)
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                else
                {

                    for (int i = first + 1; i < second; i++)
                    {
                        Console.WriteLine("---------");
                        Console.WriteLine($"{i}");


                    }
                    break;
                }
            }
        }
    }
}

            
        

