using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI
{
    class SectionGExercis1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            Console.WriteLine();

            string s = Console.ReadLine();

            string[] vowels = new string[] { "A", "E", "I", "O", "U" };
            int[] counter = new int[5];
            int Total = 0;
            for (int i = 0; i<s.Length; i++)
            {
                string r = s.Substring(i, 1);
                string u = r.ToUpper();


                for (int j=0; j<5; j++)
                {
                    if (u.Equals(vowels[j]))
                    {
                        counter[j] = counter[j] + 1;
                        int test = counter[j];
                        break;
                    }
                }
               
            }
            for (int p = 0; p < 5; p++)
            {
                Total = Total + counter[p];
            }

            Console.WriteLine("Input\t\t\tOutput");
            Console.WriteLine("{0},{1}", s, Total);
            for (int count = 0; count < 5; count++)
            { 
                Console.WriteLine("\t\t\t\t\t" + vowels[count] + " : " + counter[count]); 
            }
                
        }
    }
}
