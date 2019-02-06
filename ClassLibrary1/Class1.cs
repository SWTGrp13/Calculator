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
          uut = new FuncsForCalc();
        }

        //TEST OF ADD
        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 0)]
        [TestCase(1.1, 1.9, 3)]
        [TestCase(9999999999, 9999999999, 19999999998)]
        [TestCase(2, -2, 0)]
        [TestCase(2, 1, 3)]
        //Removed dublicate
        public void Add_AddAandB_ReturnsC(double a, double b, double c)
            {
                Assert.That(uut.Add(a, b), Is.EqualTo(c).Within(0.01));
            }

        //TEST OF SUBTRACT
        [TestCase(1.0001, 1, 0)]
        [TestCase(-2, -2, 0)]
        [TestCase(-2, 2, -4)]
        public void Subtract_SubtractAandB_ReturnsC(double a, double b, double c)
            {
                Assert.That(uut.Subtract(a, b), Is.EqualTo(c).Within(0.01));
            }

        //TEST OF MULTIPLY
        [TestCase(2, 2, 4)]
        [TestCase(-2, -2, 4)]
        [TestCase(-2, 2, -4)]
        public void Multiply_MultiplyAandB_ReturnsC(double a, double b, double c)
            {
                Assert.That(uut.Multiply(a, b), Is.EqualTo(c).Within(0.01));
            }

        //TEST OF POWER
        [TestCase(2, 2, 4)]
        [TestCase(2, 0, 1)]
        [TestCase(8, 0, 1)]
        [TestCase(-2, 2, 4)]
        [TestCase(-2, -2, 0.25)]
        [TestCase(2, 0.5, 1.414)]
        public void Power_AtothepowerofB_returnsC(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c).Within(0.01));
        }

        //TEST OF DIVISION
        [TestCase(2, 2, 1)]
        [TestCase(2,1,2)]
        [TestCase(1,2,0.5)]
        [TestCase(1,3,0.33)]
        public void Division_DivideAandB_ReturnsC(double a, double b, double c)
            {
                Assert.That(uut.Division(a, b), Is.EqualTo(c).Within(0.01));
            }
        //TEST OF DIVISION EXCEPTION
        [Test]
        public void Division_Divide2and0_returnException()
            {
                Assert.Throws<DivideByZeroException>(() => uut.Division(2,0));
            }

        //TEST OF MODULUS
        [TestCase(2, 5, 2)]
        [TestCase(5, 2, 1)]
        [TestCase(-5, -2, -1)]
        public void Mod_ModAofB_ReturnsC(double a, double b, double c)
        {
            Assert.That(uut.Mod(a, b), Is.EqualTo(c).Within(0.01));
        }

        //TEST OF ACCUMULATOR
        public void Accumulator_ResultAfter_Add2and2_Returns4()
        {
           // Assert.That(uut.Accumulator(), Is);
        }

        //TEST OF LETTER INSTEAD OF NUMBER

        public void LetterInsteadOfNumber_ReturnsWarning()
        {
            var testResult = new FuncsForCalc();
            double result = testResult.Add(5, 4);
            Assert.Fail();
        }

        [TestCase(5, 4, 9)]
        public void GetSum_AddOneThenGetSum(double a, double b, double c)
        {
            var uut_Sum = new FuncsForCalc();
            uut_Sum.Add(a, b);
            Assert.That(uut_Sum.getSum(), Is.EqualTo(c));

        }
    }
}
