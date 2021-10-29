using System;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();
        }

        static void Factorial()
        {
            Console.WriteLine("введите неотрицательное число");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            if (a < 0)
            {
                Console.WriteLine("введено отрицательное число");
            }
            else if (a % 1 != 0)
            {
                Console.WriteLine("введено дробное число");
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    b *= i;
                }
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
