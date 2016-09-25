using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B4
    {
        public static void Main()
        {
            Console.WriteLine("Input\t\t\t\t\t Output");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the value of x");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = 5 * Math.Pow(x, 2) - 4 * x + 3;
                Console.WriteLine("{0}\t\t\t\t\t{1}",x,y);
            }
        }        
    }
}

