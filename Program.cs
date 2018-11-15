using System;

namespace PracticingSOLIDPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declare ReadFile class to call the readTheFile method to read file contents
            var read = new ReadFile();
            read.readTheFile();

            //just keeping console window open
            Console.ReadLine();
        }
    }
}
