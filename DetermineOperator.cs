/*
declare string variable to hold the operator
set up if/else statement to determine operator based on type of arithmetic
 */

namespace PracticingSOLIDPrinciples
{
    public class DetermineOperator
    {
        public string getOperator(string arithmeticType)
        {
            string operation;

            if(arithmeticType == "add")
            {
                operation = "+";
                return operation;

            } else if (arithmeticType == "subtract")
            {
                operation = "-";
                return operation;
            }
            else if (arithmeticType == "multiply")
            {
                operation = "*";
                return operation;
            }
            else if (arithmeticType == "divide")
            {
                operation = "/";
                return operation;
            }
            else
            {
                operation = "Unable to determine operator.";
                return operation;
            }
        }
    }
}
