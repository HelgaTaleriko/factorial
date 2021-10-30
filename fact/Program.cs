using System;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("введите неотрицательное число");
                int input = Convert.ToInt32(Console.ReadLine());
                int resultFact = Factorial(input);
                int resultFibo = Fibo(input);
                int resultFactRec = FactorialRecursive(input);
                int[] result = new int[3];
                result[0] = resultFact;
                result[1] = resultFibo;
                result[2] = resultFactRec;
                //int[] result = new int { resultFact, resultFibo, resultFactRec }
                Console.WriteLine("Результат Фаакториала: "+ result[0]);
                Console.WriteLine("Результат Фибоначи: " + result[1]);
                Console.WriteLine("Результат рекурсивного Фаакториала: " + result[2]);
            }
        }
        static int Fibo(int a)
        {
            if (a <= 1)
            { return 1; }
            int fiboResult = Fibo(a - 1) + Fibo(a - 2);
            return fiboResult;
        }

        static int Factorial(int a)
        {
            int b = 1;
            if (a < 0)
            {
                throw new Exception("введено отрицательное число");
            }
            else if (a % 1 != 0)
            {
                throw new Exception("введено дробное число");
            }
            for (int i = 1; i <= a; i++)
            {
                b *= i;
            }
            return b;
        }
        static int FactorialRecursive(int a)
        {
            if (a < 0)
            {
                throw new Exception("введено отрицательное число");
            }
            else if (a % 1 != 0)
            {
                throw new Exception("введено дробное число");
            }
            if (a <= 1)
            { return 1; }
            int result = a * FactorialRecursive(a - 1);
            return result;
        }
    }
}
