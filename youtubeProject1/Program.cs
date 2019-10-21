using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {
            // inheritence
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeChicken();

            italianchef.MakeMeatball();

            italianchef.MakeSpecialDish();



            Console.ReadLine();


            // Math is a static class
            Console.WriteLine(Math.Sqrt(144));
            // static method created in the class
            UsefullTools.SayHi("Cassian");


            Console.ReadLine();

        }

    }
}
