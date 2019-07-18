namespace Stack
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var stack = new CustomStack<object>();

            while (true)
            {
                var command = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Push")
                {
                    var items = new object[command.Length - 1];
                    Array.Copy(command, 1, items, 0, items.Length);
                    stack.Push(items);
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No elements");
                    }
                }
                else if ((command[0].ToUpper() == "END"))
                {
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                }
            }
        }
    }
}