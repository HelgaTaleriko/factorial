using System;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            for (int i = 1; a >= i; i++)
            {
                b = b * i;
            }
            Console.WriteLine(b);
        }
    }
}
