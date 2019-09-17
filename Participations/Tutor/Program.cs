using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor
    //Clinton Carter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         Create a C# console application (do not create a .NET CORE project)
         and name the project Tutor.  Generate two random integers, each between 
         1 and 50, that you will be adding together to test the users ability to
         perform the addition operator.  Display the numbers in the console,
         such as:
	     7 + 22 = ?
         Once the user provides their answer, check to see if it is correct
         and if not, tell them sorry, please try again.  If their answer is 
         correct, congratulate them on getting the right answer. 
         */

            //random
            Random rand = new Random();
            int rand1 = rand.Next(1, 51);

            Random rands = new Random();
            int rand2 = rands.Next(1, 51);

            //input
            Console.WriteLine(rand1 + " + "  + rand2 + "= ?" );
            string ansString = Console.ReadLine();
            double ans = Convert.ToDouble(ansString);
            
             

                
                    while (rand1 + rand2 != ans)
                    {
                if (rand1 + rand2 != ans)
                {
                    Console.WriteLine("Sorry, that is not correct. Please try again. >>");
                    Console.WriteLine(rand1 + " + " + rand2 + " = ?");
                    ansString = Console.ReadLine();
                    ans = Convert.ToDouble(ansString);
                }
                else

                {

                   

                }
                Console.WriteLine("Congrats, you are correct!");

            }
                
                


                Console.ReadKey();

            
           


        }
    }
}
