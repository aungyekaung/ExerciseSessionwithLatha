using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_D
{
    class D3a
    {
        public static void Main()
        {
            Random r = new Random();
            int secretnumber = r.Next(1, 11);
            int guess=0; int counter = 0;
            while(guess != secretnumber)
            {
                Console.WriteLine("Enter A number between 1 and 10");
                guess = Convert.ToInt32(Console.ReadLine());
                counter = counter + 1;
                Console.WriteLine("Please try again");
            }
            Console.WriteLine("Congratulation!!");
            Console.WriteLine("You took {0} attempts", counter);
        }
    }
}
