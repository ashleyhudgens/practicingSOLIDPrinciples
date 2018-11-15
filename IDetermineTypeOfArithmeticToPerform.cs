using System.Collections.Generic;

namespace PracticingSOLIDPrinciples
{
    interface IDetermineTypeOfArithmeticToPerform
    {
        string typeOfMath { get; set; }
        double firstNumber { get; set; }
        double secondNumber { get; set; }
        List<double> listOfTotals { get; set; }
        List<double> listOfFirstNumbers { get; set; }
        List<double> listOfSecondNumbers { get; set; }
        List<string> listOfOperators { get; set; }
        string[] listOfAcceptedTypesOfArithmetic { get; set; }
    }
}
