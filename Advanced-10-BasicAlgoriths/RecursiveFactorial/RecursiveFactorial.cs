using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main()
        {
            int endNum = int.Parse(Console.ReadLine());

            long result = CalculateFactorial(endNum);

            Console.WriteLine(result);
        }

        private static long CalculateFactorial(int endNum)
        {
            if (endNum == 1)
            {
                return 1;
            }

            return endNum * CalculateFactorial(--endNum);
        }
    }
}