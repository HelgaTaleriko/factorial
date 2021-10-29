using System;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите порядковый номер числа");
                int input = Convert.ToInt32(Console.ReadLine());
                int result = Fibo(input);
                Console.WriteLine(result);
            }
        }
        static int Fibo(int a)
        {
            if (a <= 1)
            { return 1; }
            int fiboResult = Fibo(a - 1)+ Fibo(a-2);
            return fiboResult;
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
