using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {

            int baseNum = 4;
            int powNum = 3;

            Console.WriteLine( GetPow(baseNum, powNum));

            Console.ReadLine();

        }

        static int GetPow( int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;

        }
    }
}
