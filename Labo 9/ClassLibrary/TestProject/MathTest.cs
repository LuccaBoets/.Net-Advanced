using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class MathTest
    {
        [DataTestMethod]
        [DataRow(1,1)]
        [DataRow(6,1)]
        [DataRow(-1,1)]
        [DataRow(1,-1)]
        [DataRow(-1,-1)]
        [DataRow(1,100)]
        public void AddTest(int getal1, int getal2)
        {
            Math math = new Math();

            var result = math.Add(getal1, getal2);

            Assert.AreEqual(getal1 + getal2, result);
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(6, 1)]
        [DataRow(-1, 1)]
        [DataRow(1, -1)]
        [DataRow(-1, -1)]
        [DataRow(1, 100)]
        public void DivideTest(int getal1 , int getal2)
        {
            Math math = new Math();

            var result = math.Divide(getal1, getal2);

            Assert.AreEqual(getal1 / getal2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideTestDivideZero()
        {
            Math math = new Math();

            int getal1 = 1;
            int getal2 = 0;

            var result = math.Divide(getal1, getal2);
        }
    }
}
