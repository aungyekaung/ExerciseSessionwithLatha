using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionB
{
    class B1
    {
        public static void Main(){ 
        int n = 3;
            for (n=0;n<3;n++)
            {
                 Console.WriteLine("enter the Number:");
                 double d= Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine  ("Input \t\t\t\t  Output");
                 Console.WriteLine ("{0}\t\t\t\t {1}",d,Math.Sqrt(d));

            }

         }
        
      }         
    }
