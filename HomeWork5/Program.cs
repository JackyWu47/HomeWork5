using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 6; i <= 15; i++)
            {
                k = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        k = 0;
                        break;
                    }
                }
                if (k == 1)
                {
                    Console.Write(i);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
