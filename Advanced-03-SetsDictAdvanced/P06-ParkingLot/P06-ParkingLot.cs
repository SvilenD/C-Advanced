namespace P06_ParkingLot
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ");
                if (input[0]?.ToUpper() == "END")
                {
                    break;
                }
                else if (input[0]?.ToUpper() == "IN")
                {
                    parking.Add(input[1]);
                }
                else if (input[0]?.ToUpper() == "OUT")
                {
                    parking.Remove(input[1]);
                }
            }
            if (parking.Count > 0)
            {
                foreach (var carPlate in parking)
                {
                    Console.WriteLine(carPlate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}