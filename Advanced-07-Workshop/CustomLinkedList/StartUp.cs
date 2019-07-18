namespace CustomLinkedList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //var linkedList = new CustomLinkedList<int>();

            //linkedList.AddHead(5);
            //linkedList.AddHead(10);
            //linkedList.AddHead(15);

            ////15 <-> 10 <-> 5

            //Console.WriteLine(linkedList.Count == 3);
            //Console.WriteLine(linkedList.Head == 15);
            //Console.WriteLine(linkedList.Tail == 5);
            //linkedList.AddTail(20);
            //linkedList.AddTail(25);

            ////15 <-> 10 <-> 5 <-> 20 <-> 25
            //linkedList.ForEach(Console.WriteLine);

            //Console.WriteLine(linkedList.Count == 5);
            //Console.WriteLine(linkedList.Head == 15);
            //Console.WriteLine(linkedList.Tail == 25);

            //Console.WriteLine(linkedList.RemoveHead() == 15);
            //Console.WriteLine(linkedList.RemoveHead() == 10);
            //Console.WriteLine(linkedList.Count == 3);

            ////5 <-> 20 <-> 25
            //Console.WriteLine(linkedList.RemoveTail() == 25);
            //Console.WriteLine(linkedList.RemoveTail() == 20);
            //Console.WriteLine(linkedList.RemoveTail() == 5);
            //Console.WriteLine(linkedList.Count == 0);

            //try
            //{
            //    Console.WriteLine(linkedList.Head);
            //    Console.WriteLine(false);
            //}
            //catch (InvalidOperationException)
            //{
            //    Console.WriteLine(true);
            //}

            //var newList = new CustomLinkedList<int>();
            //newList.AddHead(10);
            //newList.AddHead(1);
            //newList.AddTail(10);
            //newList.AddTail(100);
            //newList.AddHead(10);

            //foreach (var num in newList)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine(newList.Contains(22) == false);
            //Console.WriteLine(newList.Contains(1));
            //Console.WriteLine(newList.Count == 5);
            //newList.Remove(10);
            //Console.WriteLine(newList.Count == 2);
            //newList.Clear();
            //Console.WriteLine(newList.Count == 0);
            //Console.WriteLine(newList.Contains(5) == false);
        }
    }
}
