using System;

namespace youtubeProject1
{
    class Program
    {
        private const string Value = "A number wasn't entered";

        static void Main(string[] args)
        {

            String retrunDay = GetDay(4);

            Console.WriteLine(retrunDay);

            Console.ReadLine();

        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednsday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day";
                    break;
            }

            return dayName;
        }

    }
}
