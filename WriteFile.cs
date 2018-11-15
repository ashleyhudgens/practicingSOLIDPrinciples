/*
declare writePath (where results will write to)
set up streamwriter and set append to true as to not overwrite each iteration
set up string variable to encapsulate the lists of first/second numbers, operators and total
write to file
deleteWriteIfFileExists method is used in readFile to remove the file before writing out to avoid writing to a previous instance
 */

using System.IO;
using System.Collections.Generic;

namespace PracticingSOLIDPrinciples
{
    public class WriteFile
    {
        string writePath = "C:\\Users\\ahudgens\\desktop\\testingresults.txt";

        public void writeTheFile(List<double> testingFirstNumber, List<string> listOfOperators, List<double> testingSecondNumber, List<double> totals)
        {

            StreamWriter writer = new StreamWriter(writePath, append: true);

            string testingAgain = string.Join(" ", testingFirstNumber);
            string blah = string.Join(" ", testingSecondNumber);
            string operatotoerasf = string.Join(" ", listOfOperators);
            string whatever = string.Join(" ", totals);

            using (writer)
            {
                writer.WriteLine(testingAgain + " " + operatotoerasf + " " + blah + " " + whatever);

            }
        }

        public void deleteWriteFileIfExists()
        {
            if (File.Exists(writePath) == true)
            {
                File.Delete(writePath);
            }
        }
    }
}
