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
                Calculator calc1 = new Calculator();
                int input = calc1.Input;
                // Добавить указание инпута в экземл
                int resultFact = calc1.Factorial(input);
                int resultFibo = calc1.Fibo(input);
                int resultFactRec = calc1.FactorialRecursive(input);
                int[] result = new int[] { resultFact, resultFibo, resultFactRec };
                Console.WriteLine("Результат Фаакториала: " + result[0]);
                Console.WriteLine("Результат Фибоначи: " + result[1]);
                Console.WriteLine("Результат рекурсивного Фаакториала: " + result[2]);
            }
        }
    }
}
