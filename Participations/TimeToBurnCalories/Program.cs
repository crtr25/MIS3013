using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToBurnCalories
    //Clinton Carter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a C# console application (do not create a .NET CORE projec)
             and name the project TimeToBurn.  Running on a particular treadmill,
             you burn 3.9 calories per minute.  Ask the user how many calories 
             they wish to burn in this workout session (this is their goal). 
             Once they tell you, output on the console after each minute, how 
             many calories they have burned (e.g. After 1 minute, you have
             burned 3.9 calories).  Keep outputting the total amount of calories 
             they have burned until they have met their goal.
             */

            //Variables
            string goalCalAsString;
            const double calPerMin = 3.9;
            double burnCal, calTotal, minute = 1;

            //input
            Console.WriteLine("How many calories do you wish to burn this workout? >>");
            goalCalAsString = Console.ReadLine();

            //convert
            double goalCal = Convert.ToDouble(goalCalAsString);

            // question to ask: How to make answers display one at a time?
            //question to ask : What does the ++ sign do in equations. I think I understand this tho.

            //Loop
            calTotal = minute * calPerMin;
            for (minute = 1; calTotal < goalCal; minute++)
            {
                calTotal = minute  * calPerMin;
                Console.WriteLine("After " + minute + " minute(s), you have burned " + calTotal + " calories");
                

            }
            if (calTotal >= goalCal)
            {
                Console.WriteLine("Congrats you reached your goal for this workout! >>");
            }
            else
            {
                Console.WriteLine("Keep it up! You're not at your goal yet!");
            }
            
            //Output
            Console.ReadKey();

        }
    }
}
