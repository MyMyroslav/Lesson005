using System;

namespace Lesson005_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            for (int i = 0; i < 4; i++)
            {
                // Виводимо один рядок з 10 зірочок.
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("*");
                }

                // Перехід на новий рядок.
                Console.WriteLine();

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int k = 2; k <= 7; k++)
            {
                for (int m = 1; m <= 15; m++)
                {
                    if (m >= ((7 - (k - 1))) && m <= (7 + (k - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int k = 2; k <= 7; k++)
            {
                for (int m = 1; m <= 15; m++)
                {
                    if (m >= ((7)) && m <= (7 + (k - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

    }
}
    

