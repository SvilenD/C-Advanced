namespace Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split();
            string firstName = firstInput[0] + " " + firstInput[1];
            string firstAddress = firstInput[2];
            var firstTuple = new Tuple<string, string>(firstName, firstAddress);

            var secondInput = Console.ReadLine().Split();
            string secondName = secondInput[0] ;
            int liters = int.Parse(secondInput[1]);
            var secondTuple = new Tuple<string, int>(secondName, liters);

            var thirdInput = Console.ReadLine().Split();
            int num = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);
            var thirdTuple = new Tuple<int, double>(num, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}