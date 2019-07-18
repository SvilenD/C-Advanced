namespace DefiningClasses
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            var data = new DateModifier();

            Console.WriteLine(data.Difference(firstDate, secondDate));
        }
    }
}
