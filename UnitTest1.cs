using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticingSOLIDPrinciples;

namespace UnitTestsForPracticingSOLIDPrinciples
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testAdditionTotal()
        {
            //arrange
            var x = new DoTheMath();
            x.performMath(1, 2, "add");
            Assert.AreEqual(x.total, 3);
        }
        [TestMethod]
        public void testSubtractionTotal()
        {
            //arrange
            var x = new DoTheMath();
            x.performMath(1, 2, "subtract");
            Assert.AreEqual(x.total, -1);
        }
        [TestMethod]
        public void testMultiplicationTotal()
        {
            //arrange
            var x = new DoTheMath();
            x.performMath(1, 2, "multiply");
            Assert.AreEqual(x.total, 2);
        }
        [TestMethod]
        public void testDivisionTotal()
        {
            //arrange
            var x = new DoTheMath();
            x.performMath(1, 2, "divide");
            Assert.AreEqual(x.total, .5);
        }
        [TestMethod]
        public void testAdditionOperator()
        {
            //arrange
            var x = new DetermineOperator();
            x.getOperator("add");
            Assert.AreEqual(x.operation, "+");
        }
        [TestMethod]
        public void testSubtractionOperator()
        {
            //arrange
            var x = new DetermineOperator();
            x.getOperator("subtract");
            Assert.AreEqual(x.operation, "-");
        }
        [TestMethod]
        public void testMultiplicationOperator()
        {
            //arrange
            var x = new DetermineOperator();
            x.getOperator("multiply");
            Assert.AreEqual(x.operation, "*");
        }
        [TestMethod]
        public void testDivisionOperator()
        {
            //arrange
            var x = new DetermineOperator();
            x.getOperator("divide");
            Assert.AreEqual(x.operation, "/");
        }
        [TestMethod]
        public void testReadingFile()
        {
            var x = new ReadFile();
            string readPath = "C:\\Users\\ahudgens\\desktop\\testingfiles.txt";
            x.readTheFile(readPath);
            Assert.AreEqual(x.readLines = x.reader.ReadLine(), null);
        }
    }
}
