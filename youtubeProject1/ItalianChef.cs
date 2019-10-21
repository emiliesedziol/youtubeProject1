using System;
using System.Collections.Generic;
using System.Text;

namespace youtubeProject1
{
    class ItalianChef : Chef
    {
        // can do everyting Chef can do

        // but Italianchef can do
        public void MakeMeatball()
        {
            Console.WriteLine("The Italian Chef makes meat balls");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italian Chef makes piza");
        }
    }
}
