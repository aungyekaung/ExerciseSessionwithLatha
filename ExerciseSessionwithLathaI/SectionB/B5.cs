using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B5
    {
        public static void Main()
        {
            

            for (int i = 0; i < 3;i++ )
            {
                Console.WriteLine("Enter the temperature ");
                double tempc = Convert.ToDouble(Console.ReadLine());
                double tempf = 1.8 * tempc + 32;
                Console.WriteLine("input\t\t\t\t\tOutput");
                Console.WriteLine("{0} \t\t\t\t\t {1}", tempc, tempf);

            }

          

        }





    }
}
