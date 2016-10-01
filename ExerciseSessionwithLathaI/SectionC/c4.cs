using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionC
{
    class c4
    {
        public static void Main()
        {
            Console.WriteLine(" Input \t\t\t  Output"); double fare = 0.0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the Distance Travelled:");
                string s = Console.ReadLine();
                double d = Convert.ToDouble(s);
                double k = Math.Ceiling(d * 10) / 10;
                if (k <= 0.5)
                    fare = 2.4;
                else if (k > 0.5 && k <= 9)
                    fare = 2.4 + (85 * 0.04);
                else if (k > 9)
                    fare = 2.4 + (85 * 0.04) + ((k * 10) - 90) * 0.05;

                Console.WriteLine("{0} \t\t\t {1}", d, fare);
            }
        }
    }
}