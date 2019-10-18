using System;
using System.Collections.Generic;
using System.Text;

namespace youtubeProject1
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // constructor for the class
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating book");  // every time an instance of book is created this line will print
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
