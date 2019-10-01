using System;

namespace youtubeProject1
{
    class Program
    {
        private const string Value = "A number wasn't entered";

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
            double DogAgeMonths = .7;  // float, double, decimal -- note decimal and float must have decimal with zero or the number after it
            bool isBig = true;
            Console.WriteLine("Who live at my house "+ Dog2 + " and is " + DogAgeMonths + " old, is big " + isBig);
            /*
             * 
                /|\
               /_|_\
              /__|__\
             /___|___\
            /____|____\

            Dogs in the Neighborhood
            Cassian  1
            Cassian walks 5 mile a day
            Brewen
            Embry
            Nala  0
            Nala walks .1 mile a day
            Jeffery
            Who live at my house Cassian and is 0.7 old, is big True

             */
             //             string starts at position zero, phrase[0] is W
            string phrase = "Who live at my house " + Dog2 + " and is " + DogAgeMonths + " old, is big " + isBig;
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length + " number of characters ");
            Console.WriteLine(phrase.Contains("z") + " does not contain a 'z'");
            Console.WriteLine(phrase.IndexOf("z"));
            Console.WriteLine(phrase.IndexOf("o"));

            // numbers

            Console.WriteLine( 0909 ); // leading zero is dropped

            Console.WriteLine(5 % 3);  // 5 modular (mod) 3 will give the remander which is 2

            Console.ReadLine();


            Console.WriteLine("");

            Console.Write("Name of your dog ");  // waits for a line of text 
            String newName = Console.ReadLine();
            Console.WriteLine("Dogs name " + newName);


            int num = Convert.ToInt32("45");

            /*
            Console.Write("Enter a number ");
            string tmp1 = Console.ReadLine();
            int num2 = 0;
            if (int.TryParse(tmp1, out num2))
            {
                Console.WriteLine("number " + num2 + " was entered");
            }
            else
            {
                Console.WriteLine("A number wasn't entered " + num2 + " will be used");
            }

            
            Console.ReadLine();
            */

            // calculator
            Console.Write("Enter a Number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            /* interesting output
             *  Enter a Number:3.4
                Enter a Number:2.3
                5.699999999999999
            */

            Console.ReadLine();

            // mad lib

            Console.WriteLine("Roses are Red");
            Console.WriteLine("Violets are Blue");
            Console.WriteLine("Who loves you");

            string color, pluralNoun, celebrity;
            Console.Write("Enter a color ");
            color = Console.ReadLine();
            Console.Write("Enter something ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a name");
            celebrity = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are Blue");
            Console.WriteLine("Who loves " + celebrity);

            Console.ReadLine();
        }
    }
}
