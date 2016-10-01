using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B10
    {public static void Main()
        {
           
            Console.WriteLine("A \t\t\t B \t\t\t C \t\t\t Output");
            for (int i = 0; i < 3; i++)
            {
                double area;
                Console.WriteLine("Enter the sides of a triangle:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                double s = (a + b + c) / 2;
                double z = s*(s - a)*(s - b)*(s - c);
                if (z < 0)
                {
                    string output = "N.A";
                    Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}", a, b, c, output);
                }
                else
                {
                    area = Math.Sqrt(z);
                    Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}", a, b, c, area);
                }
            }

        }
    }
}
