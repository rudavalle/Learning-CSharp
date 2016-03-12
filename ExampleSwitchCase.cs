using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_project.day1
{
    class ExampleSwitchCase
    {
        static void Main()
        {
            string j = "Two";

            switch (j)
            {
                case "Zero":
                    Console.WriteLine("Value is 0");
                    break;
                case "One":
                    Console.WriteLine("value is 1");
                    break;
                case "Two":
                    Console.WriteLine("value is 2");
                    break;
                case "Three":
                    Console.WriteLine("value is 3");
                    break;
                case "Four":
                    Console.WriteLine("value is 4");
                    break;
                default:
                    Console.WriteLine("value not found");
                    break;        

            }
            

        }
    }
}
