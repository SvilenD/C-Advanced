namespace DefiningClasses
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            var oldest = family.GetOldestMember();
            Console.WriteLine(oldest);
        }
    }
}
