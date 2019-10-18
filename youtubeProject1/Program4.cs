using System;

namespace youtubeProject4
{
    class Program
    {
 

        static void Main4(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error " + e.Message);
            }

            finally
            {
                Console.WriteLine("Use this if something needs to be done even if there is an error");
            }


            Console.ReadLine();

        }

    }
}
