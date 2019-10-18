using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {
            // data type - Class model represents world entities - specification

            // book object includes title, author and pages - instance of a book
            Book book1 = new Book();
            book1.title = "Thrawn";
            book1.author = "unknown";
            book1.pages = 1000;

            Console.WriteLine(book1.title);


            Console.ReadLine();

        }

    }
}
