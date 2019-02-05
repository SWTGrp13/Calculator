using NUnit.Framework;
using System;
using Calculator;


namespace ClassLibrary1
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private FuncsForCalc uut;

        [SetUp]
        public void SetUp()
        {
          //  uut = new FuncsForCalc();
        }

        [TestCase(2, 2, 4)] 
        [TestCase(-2, 2, 0)]
        [TestCase(1.1, 1.9, 3)]
        [TestCase(9999999999,9999999999,19999999998)]
        [TestCase(2, -2, 0)]
        [TestCase(2, 1, 3)]
            //Removed dublicate
        public void Add_AddaAndb_Returnsc(double a, double b, double c)
        {
            Assert.That(FuncsForCalc.Add(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(2,1,2)]
        [TestCase(1,2,0.5)]
        public void Division_DivideaAndb_Returnsc(double a, double b, double c)
        {
            Assert.That(FuncsForCalc.Division(a, b), Is.EqualTo(c));
        }

        [Test]
        public void Division_Divide2and0_returnException()
        {
            Assert.Throws<DivideByZeroException>(() => FuncsForCalc.Division(2,0));
        }
    }
}
