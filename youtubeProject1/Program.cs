using System;

namespace youtubeProject1
{
    class Program
    {
 

        static void Main(string[] args)
        {

            Student student1 = new Student("Bill", "Business", 2.8);
            Student student2 = new Student("George", "Economics", 3.8);

            Console.WriteLine(student1.name + " has honors " + student1.HasHonors());
            Console.WriteLine(student2.name + " has honors " +  student2.HasHonors());

            Console.ReadLine();

        }

    }
}
