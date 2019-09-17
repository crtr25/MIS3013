using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncrease
//Clinton Carter
{ 
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a C# console application (do not create a .NET CORE project)
        and name the project TuitionIncrease. The college charges a 
        full-time student $12,000 in tuition per semester.  It has been 
        announced that there will be a tuition increase by 5% each year for 
        the next 7 years.  Your application should display the projected 
        semester tuition amount for the next 7 years in the console window in 
        the following format:
       The tuition after year 1 will be $12,600.
       Note: The number is in the output and the format of the tuition 
       amount is currency with 0 decimal places
       */

            //variables
            double tuition, year, total, projectedTotal;
            const double Increase = .05;
            Console.WriteLine("The tuition after year 1 will be" +" $12,600");


            //equation and loop
           
             

            for (year = 2; year < 8; year++)
             {
                tuition = 12600;
                projectedTotal = (tuition * Increase) + tuition;
                total = (projectedTotal * Increase) + projectedTotal;
                Console.WriteLine("The tuition after year " + year + " will be " + total.ToString("C0"));
             }
            

            Console.ReadKey();
        }
    }
}
