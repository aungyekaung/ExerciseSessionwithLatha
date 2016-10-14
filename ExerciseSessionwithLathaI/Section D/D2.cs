using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_D
{
    class D2
    {
        public static void Main()
        {
            int A ; int B ;
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("enter the Numbers:");
                A = Convert.ToInt32(Console.ReadLine());int A1 = A;
                B = Convert.ToInt32(Console.ReadLine());int B1 = B;
                while(A!=B)
                {
                    if (B > A)
                        B = B - A;
                    else
                        A = A - B;

                }

                int X = A;  int Y = (A1 * B1) / X;
                Console.WriteLine("A \t\t B \t\t HCF \t\t LCM");
                Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}",A1,B1,X,Y);


            }



        }


    }
}
