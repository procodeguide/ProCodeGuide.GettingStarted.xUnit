using ProCodeGuide.GettingStarted.xUnit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProCodeGuide.xUnitTests
{
    public class MathServiceTests
    {
        private MathsService _unitUnderTesting = null;
        public MathServiceTests()
        {
            if (_unitUnderTesting == null)
            {
                _unitUnderTesting = new MathsService();
            }
        }

        [Fact]
        public void Add()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 13;

            var actual = _unitUnderTesting.Add(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Substract()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            var actual = _unitUnderTesting.Subtract(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Multiply()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 40;

            var actual = _unitUnderTesting.Multiply(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact(Skip = "Dont run now")]
        public void Divide()
        {
            double x1 = 100;
            double x2 = 10;
            double expected = 10;

            var actual = _unitUnderTesting.Divide(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact(DisplayName = "Maths - Divided by Zero Exception")]
        public void DivideByZeroException()
        {
            double x1 = 100;
            double x2 = 0;

            Action act = () => _unitUnderTesting.Divide(x1, x2);

            Assert.Throws<DivideByZeroException>(act);
        }

        [Theory(DisplayName = "Maths - Divided with Parameters")]
        [InlineData(40, 20, 2)]
        public void DivideWithParameter(double value1, double value2, double ExpectedValue)
        {
            double x1 = value1;
            double x2 = value2;
            double expected = ExpectedValue;

            var actual = _unitUnderTesting.Divide(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
