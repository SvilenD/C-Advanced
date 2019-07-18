namespace Workshop
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var myStack = new CustomStack<int>();
            myStack.Push(5);
            myStack.Push(25);
            myStack.Push(125);

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}