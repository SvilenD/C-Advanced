namespace Threeuple
{
    using System;


    public class StartUp
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split();

            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];
            string town = firstInput[3];
            var firstTuple = new Threeuple<string, string, string>(name, address, town);

            var secondInput = Console.ReadLine().Split();
            name = secondInput[0];
            int liters = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2].ToLower() == "drunk"? true : false;
            var secondTuple = new Threeuple<string, int, bool>(name, liters, isDrunk);

            var thirdInput = Console.ReadLine().Split();
            name = thirdInput[0];
            double accountBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            var thirdTuple = new Threeuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}