using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B6
    {
        public static void Main()
        {

            Console.WriteLine("x1 \t\t\t y1 \t\t\t x2 \t\t\t y2 \t\t\t distance");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the co-ordinates of point A");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the co-ordinates of point B");
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                double x = Math.Pow((x2 - x1), 2);
                double y = Math.Pow((y2 - y1), 2);
                double distance = Math.Sqrt(x + y);
                Console.WriteLine("{0} \t\t\t {1}\t\t\t {2}\t\t\t{3}\t\t\t{4}", x1, y1, x2, y2, distance);

            }

        }
    }
}
