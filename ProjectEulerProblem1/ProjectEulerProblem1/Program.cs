using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int sumOfMultiples = 0;
               
                //Takes user input for maximum number
                Console.WriteLine("Maximum Number:");
                int maximumNumber = int.Parse(Console.ReadLine());

                //Checks every # under the set maximumNumber if it is a multiple
                for(int i = 0; i < maximumNumber; i++)
                {
                    //If the number is a multiple, adds it to the sum
                    if (IsMultipleOf3Or5(i))
                    {
                        sumOfMultiples += i;
                    }
                }
                //Prints solution
                Console.WriteLine(sumOfMultiples);
            }
        }

        static bool IsMultipleOf3Or5(int number)
        {
            if((number % 3 == 0)  || (number % 5 == 0))
            {
                return true;
            } else {
                return false;
            }
        }
    }
}
