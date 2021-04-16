using DemoTestingMain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoNUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Operations opr;

        [TestInitialize]
        public void Setup()
        {
            ///follow AAA rule
            ///Arrangr(create a object, input)
            // empwage = new CompanyEmpWage("Dmart", 12, 32, 12);

            opr = new Operations();
        }

        [TestMethod]
        [DataRow(10,20)]
        [DataRow(30, 40)]

        public void GivenTwoNumbersOfInputForResultingAddition(int a, int b)
        {
            //Act
            int expected = a + b; ;
            var actual = opr.add(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(50, 20)]
        public void GivenTwoNumbersOfInputForResultingSubstraction(int a, int b)
        {
            int exp = a - b; ;
            var act = opr.sub(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [DataRow(11, 20)]
        public void GivenTwoNumbersOfInputForResultingMultiplication(int a, int b)
        {
            int exp = a * b; ;
            var act = opr.mul(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [DataRow(100, 5)]
        public void GivenTwoNumbersOfInputForResultingDivision(int a, int b)
        {
            int exp = a / b; ;
            var act = opr.div(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [DataRow(10,     2)]
        public void GivenTwoNumbersOfInputForResultingModulo(int a, int b)
        {
            int exp = a % b; ;
            var act = opr.mod(a, b);
            Assert.AreEqual(exp, act);
        }
    }
}