using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B8
    {
     public static void Main()
        {
            Console.WriteLine("Input \t\t\t\t\t Output");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the distance travelled");
                double distance = Convert.ToDouble(Console.ReadLine());
                double fare = 2.4 + distance * 0.4;
                Console.WriteLine("{0} \t\t\t\t\t {1:##.#}", distance, fare);
            }




        }
        




    }
}
