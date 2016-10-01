using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionC
{
    class c5
    {
     public static void Main()
        {
            string output = "";int r = 0; 
            Console.WriteLine("Input\t\t\tOutput");
            for (int i=0;i<4;i++)
            {
                double sum = 0; int num1 = 0;
                Console.WriteLine("Enter  the number:");
                int num = Convert.ToInt32(Console.ReadLine());
                num1 = num;
                for (int j = 0; j < 3; j++)
                {
                    r = num % 10;
                    num = num / 10;
                    sum = sum + Math.Pow(r, 3);

               }
                if (sum == num1)
                    output = "true";
                else
                    output = "false";
                Console.WriteLine("{0}\t\t\t{1}", num1, output);
            }

               





        }









    }
}
