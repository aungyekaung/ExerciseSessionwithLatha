using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionC
{
    class C3
    {
        public static void Main()
        {
            string grade=" ";
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Please enter the marks:");
                int marks = Convert.ToInt32(Console.ReadLine());
                if (marks >= 80 && marks <= 100)
                    grade = "A";
                else if (marks >= 60 && marks < 80)
                    grade = "B";
                else if (marks >= 40 && marks < 60)
                    grade = "C";
                else if (marks > 0 && marks < 40)
                    grade = "F";
                else if (marks < 0 || marks > 100)
                    grade = "error";
                Console.WriteLine("Marks\t\t\tGrade");
                Console.WriteLine("{0}\t\t\t{1}", marks, grade);

            }
        }
    }
}
