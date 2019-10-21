using System;
using System.Collections.Generic;
using System.Text;

namespace youtubeProject1
{
    class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        // virtual allowss the the method to be override, so it can be changed in another class
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes something up");
        }
    }
}
