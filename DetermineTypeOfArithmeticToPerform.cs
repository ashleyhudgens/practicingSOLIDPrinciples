/*
set up class that takes in the variable array containing the type of arithmetic, first number and second number
declare variable to the first item in the dependency array and set to the type of arithmetic being used
declare variable to the second item in the dependency array and set to the first number (converted from string to double to be able to perform math)
declare variable to the third item in the dependency array and set to the second number (converted from string to double to be able to perform math)
set up lists for totals/first numbers/second numbers
call the Math class to be able to perform the performMath method 
set up if statement to void anything other than the accepted types of arithmetic
call performMath function from DoTheMath class and add results to the list of totals
add first and second numbers to a list to be able to call writeFile after if statement
declare variable and call writeFile to write results
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticingSOLIDPrinciples
{
    public class DetermineTypeOfArithmeticToPerform
    {
        public void determineWhatArithmeticToDo(string[] variablesFromReadFile)
        {
            string typeOfMath;
            typeOfMath = variablesFromReadFile[0];

            double firstNumber;
            firstNumber = Convert.ToDouble(variablesFromReadFile[1]);

            double secondNumber;
            secondNumber = Convert.ToDouble(variablesFromReadFile[2]);

            List<double> listOfTotals = new List<double>();
            List<double> listOfFirstNumbers = new List<double>();
            List<double> listOfSecondNumbers = new List<double>();
            List<string> listOfOperators = new List<string>();

            var performArithmetic = new DoTheMath();
            var gettingOperator = new DetermineOperator();

            string[] listOfAcceptedTypesOfArithmetic = { "add", "subtract", "multiply", "divide" };

            if (listOfAcceptedTypesOfArithmetic.Contains(variablesFromReadFile[0]))
            {
                listOfTotals.Add(performArithmetic.performMath(firstNumber, secondNumber, variablesFromReadFile[0]));
                listOfFirstNumbers.Add(firstNumber);
                listOfSecondNumbers.Add(secondNumber);
                listOfOperators.Add(gettingOperator.getOperator(typeOfMath));
            }
            else
            {
                Console.WriteLine("Unable to perform arithmetic. Invalid arithmetic type.");
            }
            var writeOutToFile = new WriteFile();
            writeOutToFile.writeTheFile(listOfFirstNumbers, listOfOperators, listOfSecondNumbers, listOfTotals);
        }
    }
}
