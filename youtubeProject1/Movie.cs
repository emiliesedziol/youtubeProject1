using System;
using System.Collections.Generic;
using System.Text;

namespace youtubeProject1
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie( string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;

        }

        // method - properties
        public string Rating
        {
            get { return rating; }
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R") 
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
