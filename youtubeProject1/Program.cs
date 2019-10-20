using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.title + " rating is " + avengers.Rating);

            shrek.Rating = "b";

            Console.WriteLine(shrek.title + " rating is " + shrek.Rating);

            Console.ReadLine();

        }

    }
}
