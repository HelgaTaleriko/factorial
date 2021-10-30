using System;
using System.Collections.Generic;
using System.Text;

namespace fact
{
    class Calculator
    {
        public int Fibo(int a)
        {
            if (a <= 1)
            { return 1; }
            int fiboResult = Fibo(a - 1) + Fibo(a - 2);
            return fiboResult;
        }

        public  int Factorial(int a)
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
        public int FactorialRecursive(int a)
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

