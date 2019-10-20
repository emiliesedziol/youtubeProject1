using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {

            Song holiday = new Song("Holiday", "Green Day", 200);
            
            Song Kashmirr = new Song("Kashmirr", "Led Zep", 150);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.getSongCount());

            Console.ReadLine();

        }

    }
}
