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
    public class WriteFile : IWriteFile
    {
        public string writePath { get; set; }
        public StreamWriter writer { get; set; }
        public string writeOutFirstNumbers { get; set; }
        public string writeOutSecondNumbers { get; set; }
        public string writeOutOperators { get; set; }
        public string writeOutTotals { get; set; }

        public void writeTheFile(List<double> firstNumbers, List<string> operators, List<double> secondNumbers, List<double> totals)
        {
            writePath = "C:\\Users\\ahudgens\\desktop\\testingresults.txt";

            StreamWriter writer = new StreamWriter(writePath, append: true);

            string writeOutFirstNumbers = string.Join(" ", firstNumbers);
            string writeOutSecondNumbers = string.Join(" ", secondNumbers);
            string writeOutOperators = string.Join(" ", operators);
            string writeOutTotals = string.Join(" ", totals);

            using (writer)
            {
                writer.WriteLine("The total of " + writeOutFirstNumbers + " " + writeOutOperators + " " + writeOutSecondNumbers + " is " + writeOutTotals);

            }
        }

        public void deleteWriteFileIfExists()
        {
            writePath = "C:\\Users\\ahudgens\\desktop\\testingresults.txt";

            if (File.Exists(writePath) == true)
            {
                File.Delete(writePath);
            }
        }
    }
}
