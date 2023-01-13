using Calc;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitCalcTests
    {
      
        [Theory]
        [InlineData(2,4,6)]
        public void AddCorrect(double a, double b, double expected) 
        {
            //arrange
            Calcu calc = new Calcu();

            //act
            double actual = calc.Add(a, b);
            //assert
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, -2)]
        public void SubtracrCorrect(double a, double b, double expected)
        {
            //arrange
            Calcu calc = new Calcu();

            //act
            double actual = calc.Subtract(a, b);
            //assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, 8)]
        public void MultiplyCorrect(double a, double b, double expected)
        {
            //arrange
            Calcu calc = new Calcu();

            //act
            double actual = calc.Multiply(a, b);
            //assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, .5)]
        public void DivisionCorrect(double a, double b, double expected)
        {
            //arrange
            Calcu calc = new Calcu();

            //act
            double actual = calc.Divide(a, b);
            //assert

            Assert.Equal(expected, actual);
        }
    }
}
