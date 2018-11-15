/*
declare readPath to set up where the read from file is located
set up new stream reader to do the reading of the file and specify the read path
declare string to be able to read each line
call writefile class and utilize deleteWriteFileIfExists to delete write file and start fresh for each run of the program
set up while loop to read each line until the end
declare string and assign to a variable array to be able to split the lines being read by comma separation 
declare DetermineTypeOfArithmeticToPerform to start the math portion of the project 
 */

using System.IO;

namespace PracticingSOLIDPrinciples
{
    public class ReadFile : IReadFile
    {
        public string readPath { get; set; }
        public StreamReader reader { get; set; }
        public string readLines { get; set; }
        public void readTheFile(string readPath)
        {
            reader = new StreamReader(readPath);

            var clearFile = new WriteFile();
            clearFile.deleteWriteFileIfExists();

            while ((readLines = reader.ReadLine()) != null)
            {
                string[] variables;
                variables = readLines.Split(',');

                var determineArithmetic = new DetermineTypeOfArithmeticToPerform();
                determineArithmetic.determineWhatArithmeticToDo(variables);
            }
        }
    }
}
