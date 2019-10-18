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

            int[,] numberGrid =
            {
                {1,2 },
                {3,4 },
                {5,6 }

            };
            Console.WriteLine(numberGrid[1, 1]);

            int[,] myArray = new int[2, 3];  // have to define the size of the array

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
