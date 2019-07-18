namespace ListyIterator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            ListyIterator<string> listy = new ListyIterator<string>();

            while (true)
            {
                var command = Console.ReadLine().Split(' ');
                if (command[0].ToUpper() == "END")
                {
                    break;
                }
                else if (command[0] == "Create")
                {
                    string[] parameters = new string[command.Length - 1];
                    Array.Copy(command, 1, parameters, 0, command.Length - 1);
                    listy.Create(parameters);
                }
                else if (command[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (command[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (command[0] == "Print")
                {
                    listy.Print();
                }
            }
        }
    }
}