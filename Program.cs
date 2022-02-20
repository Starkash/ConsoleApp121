using System;
namespace Sec
{
    class NewApp
    {
        static void Main()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 6 - i; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= i + 1; k++)
                    Console.Write("*");


            }
            Console.ReadLine();

        }
        
    }
}