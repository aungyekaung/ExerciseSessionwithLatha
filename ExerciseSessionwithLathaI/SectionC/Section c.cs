using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI
{
    class Section_c
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your name;");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your gender; M for male and F for female");
            string gender = Console.ReadLine();
            if (gender == "M")
                Console.WriteLine("Good Morning Mr.{0}", name);
            else
                Console.WriteLine("Good Morning MS.{0}", name);
        }







    }
}
