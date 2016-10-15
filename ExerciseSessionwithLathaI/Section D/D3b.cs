using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_D
{
    class D3b
    {
        public static void Main()
        {

            Random r = new Random();
            int secretnumber = r.Next(1, 11);
            int guess = 0; int counter = 0;
            while (guess != secretnumber)
            {
                Console.WriteLine("Please try again");
                Console.WriteLine("Enter A number between 1 and 10");
                guess = Convert.ToInt32(Console.ReadLine());
                counter = counter + 1;
               
            }
            
            if (counter <= 2)
                Console.WriteLine("You are a wizard");
            else if (counter <= 5 && counter>2)
                Console.WriteLine("you are a good guess ");
            else  if (counter > 5)
                Console.WriteLine("You are lousy");
        }
    }
}