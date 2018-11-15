using System;

namespace PracticingSOLIDPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declare ReadFile class to call the readTheFile method to read file contents
            string readPath = "C:\\Users\\ahudgens\\desktop\\testingfiles.txt";

            var read = new ReadFile();
            read.readTheFile(readPath);

            //just keeping console window open
            Console.ReadLine();
        }
    }
}
