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
                Console.Write("Maximum Number: ");
                int maximumNumber = int.Parse(Console.ReadLine());
                //Takes user input for what are the multiples
                Console.Write("Multiple 1: ");
                int multiple1 = int.Parse(Console.ReadLine());
                Console.Write("Multiple 2: ");
                int multiple2 = int.Parse(Console.ReadLine());

                //Checks every # under the set maximumNumber if it is a multiple
                for (int i = 0; i < maximumNumber; i++)
                {
                    //If the number is a multiple, adds it to the sum
                    if (IsMultipleOf(i, multiple1, multiple2))
                    {
                        sumOfMultiples += i;
                    }
                }
                //Prints solution
                Console.Write("The sum of all natural numbers that are a multiple of " + multiple1 + " or " + multiple2 + " that are under " + maximumNumber + " is ");
                Console.WriteLine(sumOfMultiples);
            }
        }
        //Function chekcing if a number is a multiple of one number or the other
        static bool IsMultipleOf(int number, int multipleNumber1, int multipleNumber2)
        {
            if((number % multipleNumber1 == 0)  || (number % multipleNumber2 == 0))
            {
                return true;
            } else {
                return false;
            }
        }
    }
}
