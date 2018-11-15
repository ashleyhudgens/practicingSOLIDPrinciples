/*
declare variable for total
set up if/else statement to determine how to calculate the total 
 */

using System;

namespace PracticingSOLIDPrinciples
{
    public class DoTheMath : IDoTheMath
    {
        public double total { get; set; }
        public double performMath(double firstNumber, double secondNumber, string typeOfMath)
        {
            total = 0;

            if (typeOfMath == "add")
            {
                total = firstNumber + secondNumber;
                return total;
            }
            else if (typeOfMath == "subtract")
            {
                total = firstNumber - secondNumber;
                return total;
            }
            else if (typeOfMath == "multiply")
            {
                total = firstNumber * secondNumber;
                return total;
            }
            else if (typeOfMath == "divide")
            {
                total = firstNumber / secondNumber;
                return total;
            }
            else
            {
                Console.WriteLine("Unable to perform calculations to determine total. Invalid type of arithmetic.");
            }
            return total;
        }
    }
}
