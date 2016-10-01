using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B9
    {

        public static void Main(String[] args)
        {
         Console.WriteLine("Input \t\t\t\t\t Output");
         for (int i=0; i<3;i++)
            {
                Console.WriteLine("Enter the distance travelled");
                double distance = Convert.ToDouble(Console.ReadLine());
                double fare = 2.4 + distance * 0.4;
                double rufare = Math.Ceiling(fare * 10) / 10;
                Console.WriteLine("{0} \t\t\t\t\t {1}", distance,rufare);
             }
         
        }
    }
}
