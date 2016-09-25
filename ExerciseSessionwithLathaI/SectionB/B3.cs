using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciseSessionwithLathaI.SectionB
{
    class B3
    {
    public static void Main()
        {
            double sal;
            Console.WriteLine("Enter the Employees' No");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input\t\t\t\t\t Output");
            for (int i =0 ;i<empno;i++)
            {

                //Console.WriteLine("Enter the salary");

                Double.TryParse(Console.ReadLine(), out sal);
                double  Houall= 0.1 * sal;
                double traall= 0.03 * sal;
                double totalsal= sal+Houall+ traall;
                Console.WriteLine("{0}\t\t\t\t\t{1}",sal,totalsal);

            }




        }



    }
}
