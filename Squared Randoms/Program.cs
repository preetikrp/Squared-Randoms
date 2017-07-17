using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squared_Randoms
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.

                Random random = new Random();
                // Create a list
                // Populate the list
                With the resulting List, populate a new List that contains each number squared. For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.

                Then remove any number that is odd from the list of squared numbers.
             */
            Random random = new Random();
            List<int> numSquare = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                numSquare.Add (random.Next(1, 50));

            }
            List<int> squaredNew = new List<int>();

            foreach(int num in numSquare)
            {
                squaredNew.Add(num * num);
                
            }
            Console.WriteLine("Squared even numbers");
            Console.WriteLine("=====================");

            foreach (int num2 in squaredNew.ToList()) 
            {
                

                if( num2 % 2 != 0)
                {
                    squaredNew.Remove(num2);
                }
                else
                {
                    
                    Console.WriteLine(num2);

                }


            }

            Console.ReadKey();

        }
    }
}
