﻿using System;

namespace youtubeProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dog1 = "Cassian";
            int DogAge1 = 1;
            string HowFarWalks = "5 mile";
            Console.WriteLine("");
            Console.WriteLine("    /|\\");
            Console.WriteLine("   /_|_\\");
            Console.WriteLine("  /__|__\\");
            Console.WriteLine(" /___|___\\");
            Console.WriteLine("/____|____\\");
            Console.WriteLine("");
            Console.WriteLine("Dogs in the Neighborhood");
            Console.WriteLine(Dog1 + "  " + DogAge1);
            Console.WriteLine(Dog1 + " walks " + HowFarWalks + " a day");
            Console.WriteLine("Brewen");
            Console.WriteLine("Embry");
            Dog1 = "Nala";
            DogAge1 = 0;
            HowFarWalks = ".1 mile";
            Console.WriteLine(Dog1 + "  " + DogAge1);
            Console.WriteLine(Dog1 + " walks " + HowFarWalks + " a day");
            Console.WriteLine("Jeffery");
            // data type
            string  Dog2 = "Cassian";
            // char age = '';  // only 1 characters
           //  int DogAge = 1; //  no decimals can be used
            double DogAgeMonths = .7;  // float, double, decimal
            Console.WriteLine("Who live at my house "+ Dog2 + " and is " + DogAgeMonths + " old");
            Console.ReadLine();
        }
    }
}
