using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {
            // data type - Class model represents world entities - specification

            Book book1 = new Book("Thrawn", "unknown", 500);
            Book book2 = new Book("other", "unknown", 400);
            /*
            // book object includes title, author and pages - instance of a book
            Book book1 = new Book();  // this calls the constructor method in Book class
            book1.title = "Thrawn";
            book1.author = "unknown";
            book1.pages = 1000;

            Console.WriteLine(book1.title);

            Book book2 = new Book();  // this calls the constructor method in Book class
            book2.title = "big boy";
            book2.author = "unknown";
            book2.pages = 100;
            */
            Console.WriteLine(book2.title);
            

            Console.ReadLine();

        }

    }
}
