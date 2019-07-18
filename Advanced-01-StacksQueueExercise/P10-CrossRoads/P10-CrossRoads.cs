namespace P10_CrossRoads
{
    using System;
    using System.Collections.Generic;

    class CrossRoads
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var waiting = new Queue<string>();
            int carsPassed = 0;
            bool noAccident = true;
            while (noAccident)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else if (input == "green")
                {
                    int timeLeft = greenDuration;
                    while (timeLeft > 0 && waiting.Count > 0)
                    {
                        string passingCar = waiting.Dequeue();
                        int length = passingCar.Length;
                        timeLeft -= length;
                        if (timeLeft + freeWindow >= 0)
                        {
                            carsPassed++;
                        }
                        else
                        {
                            var characterHit = passingCar.Substring(length - Math.Abs(timeLeft + freeWindow), 1);
                            noAccident = false;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{passingCar} was hit at {characterHit}.");
                            break;
                        }
                    }
                }
                else
                {
                    waiting.Enqueue(input);
                }
            }
            if (noAccident)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}