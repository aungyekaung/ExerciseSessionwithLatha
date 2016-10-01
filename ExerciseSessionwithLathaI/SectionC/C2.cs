using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionC
{
    class C2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            string s = Console.ReadLine();
            int age = Convert.ToInt32(s);
            Console.WriteLine("Enter your gender.M for males and F for females");
            string gender = Console.ReadLine();
            if (age >= 40)
            {
                if (gender=="M")
                { Console.WriteLine("Good morning Uncle {0}", name); }
                else { Console.WriteLine("Good morning Aunty{0}", name); }
            }
            else
            {
                if (gender.Equals("M"))
                {
                    Console.WriteLine("Good morning Mr."+  name);
                }

                else
                {
                    Console.WriteLine("Good morning Ms." + name);
                }
            }



        }
    }
}
