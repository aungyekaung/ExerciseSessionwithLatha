using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int j = 4;
            int sum;
            if (i < 3)
            {
                sum = j - i;
            }
            else
            {
                sum = j + 8;
            }
            showonCommand(sum);

            Console.Write(sum);
        }

        static void showonCommand(int sum)
        {
            Console.WriteLine(sum + "ShowonCommand Method");

        }
    }
}
