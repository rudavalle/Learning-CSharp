using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_project.day.exercises
{
    class ExerciseA
    {
        static void Main()
        {
            double salary = 45000;
            double tax;

            if (salary <= 8350)
            {
                tax = 8350 * 0.10;

            }
            else if (salary <= 33950)
            {
                tax = (8350 * .10) + ((salary - 8350)*.15);

            }
            else
            {
                tax = (8350 * .10) + ((33950 - 8350) * .15) + ((salary - 33950) * .25);

            }

            Console.WriteLine("Tax = {0}", tax);



        }



    }
}
