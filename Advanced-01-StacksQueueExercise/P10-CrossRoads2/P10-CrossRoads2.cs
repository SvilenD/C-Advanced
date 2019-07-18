namespace P10_CrossRoads2
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        public static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> waitingCars = new Queue<string>();
            int carsPassed = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToUpper() == "END")
                {
                    break;
                }
                else if (input.ToLower() == "green")
                {
                    int passingTime = greenLightDuration;
                    while (waitingCars.Count > 0 && passingTime > 0)
                    {
                        string passingCar = waitingCars.Dequeue();
                        if (passingTime >= passingCar.Length)
                        {
                            carsPassed++;
                            passingTime -= passingCar.Length;
                        }
                        else if (passingTime + freeWindowDuration >= passingCar.Length)
                        {
                            carsPassed++;
                            passingTime = 0;
                        }
                        else
                        {
                            char characterHit = passingCar[passingTime + freeWindowDuration];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{ passingCar} was hit at { characterHit}.");
                            return;
                        }
                    }
                }
                else
                {
                    waitingCars.Enqueue(input);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}