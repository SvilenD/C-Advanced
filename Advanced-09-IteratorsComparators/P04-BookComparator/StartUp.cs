namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library library = new Library(bookOne, bookTwo, bookThree);

            //List<Book> sortedBooks = new List<Book>(library);
            //sortedBooks.Add(new Book("123 First Book", 2000, "aaaa"));
            //sortedBooks.Add(new Book("123 First Book", 2020, "aaaa"));
            //sortedBooks.Sort(new BookComparator());

            //foreach (var book in sortedBooks)
            //{
            //    Console.WriteLine(book);
            //}

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}