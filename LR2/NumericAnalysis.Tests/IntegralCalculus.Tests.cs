using System;
using Xunit;

namespace NumericAnalysis.Tests
{
    public class IntegralCalculusTests
    {
        [Fact(DisplayName = "Works with sinus function")]
        public void WorksWithSinus()
        {
            //  arrange
            Func<double, double> func = Math.Sin;

            //  act
            double actual = IntegralCalculus.Calculate(func, 0, Math.PI, 0.01);

            //  assert
            Assert.InRange(actual, 1.99, 2.01);
        }

        [Fact(DisplayName = "Works with polynomial function")]
        public void WorksWithPolynomialFunction()
        {
            //  arrange
            Func<double, double> func = PolynomialFunction;

            //  act
            double actual = IntegralCalculus.Calculate(func, 5.4, 6.7, 0.01);

            //  assert
            Assert.InRange(actual, 162.75975, 162.77975);
        }

        static double PolynomialFunction(double x)
        {
            return 3.45 * x * x - 2.34 * x + 12.6;
        }
    }
}
