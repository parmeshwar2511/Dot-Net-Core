using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Math_Library_XUnit
{

    public class CalculatorTests
    {
        Calculator c;

        public CalculatorTests()
        {
            c = new Calculator();
        }

        [Fact]
        public void Calculator_Add_Method_Positive()
        {
           // Calculator c = new Calculator();
            int a = 10, b = 10;
            int expectedResult = 20;

            int actualResult = c.Add(a, b);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Calculator_Add_Method_Negative()
        {
            // arrange 
           // Calculator c = new Calculator();
            int a = 10, b = 10;
            int expectedResult = 11;

            //act
            int actualResult = c.Add(a, b);

            // assert
            Assert.NotEqual(expectedResult, actualResult);
        }

        [Fact]
        public void Calculator_Add_Method_MaxValues()
        {
            // arrange 
            //Calculator c = new Calculator();
            int a = int.MaxValue, b = int.MaxValue;
            int expectedResult = 0;

            //act
            int actualResult = c.Add(a, b);

            // assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
