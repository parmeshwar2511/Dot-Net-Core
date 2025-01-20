using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;


namespace MathLibrary_NUnit
{
    [TestFixture]
    public  class Calculator_Test
    {
        Calculator c;

        [SetUp]
        public void initialSetup()
        {
            c = new Calculator();
        }

        [Test]
        public void Calculator_Add_Method_positive()
        {
            // arrange 
          //  Calculator c = new Calculator();
            int a = 10, b = 10;
            int expectedResult = 20;

            //act
            int actualResult = c.Add(a, b);

            // assert
            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test]
        public void Calculator_Add_Method_Negative()
        {
            // arrange 
           // Calculator c = new Calculator();
            int a = 10, b = 10;
            int expectedResult = 11;

            //act
            int actualResult = c.Add(a, b);

            // assert
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [Test]
        public void Calculator_Add_Method_MaxValues()
        {
            // arrange 
           // Calculator c = new Calculator();
            int a = int.MaxValue, b = int.MaxValue;
            int expectedResult = 0;

            //act
            int actualResult = c.Add(a, b);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
