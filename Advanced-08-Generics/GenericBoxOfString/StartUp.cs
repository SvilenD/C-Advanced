namespace GenericBoxOfString
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box);
            }
        }
    }
}