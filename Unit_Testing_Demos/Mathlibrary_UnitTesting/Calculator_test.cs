using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathlibrary_UnitTesting
{
    [TestClass]
    public  class Calculator_test
    {
        Calculator c;
        [TestInitialize]
        public void Setup()
        {
            c = new Calculator();
        }

        [TestMethod]
        public void Calculator_Add_Positive()
        {
            //1  arrange
           // Calculator c = new Calculator();
            int a = 10, b = 10;
            int exceptedResult = 20;

            // 2  Act
            int actualResult = c.Add(a,b);

            // 3 assert

            Assert.AreEqual(exceptedResult, actualResult);   // if pass true

        }


        [TestMethod]
        public void Calculator_Add_Negative()
        {
            
          //  Calculator c = new Calculator();
            int a = 10, b = 10;
            int exceptedResult = 11;

            int actualResult = c.Add(a, b);

            Assert.AreNotEqual(exceptedResult, actualResult);
        }

        [TestMethod]
        public void Calculator_Add_MaxValues()
        {
           // Calculator c = new Calculator();
            int a = int.MaxValue, b = int.MaxValue;
            int exceptedResult = 0;

            int actualResult = c.Add(a,b);

            Assert.AreEqual(exceptedResult, actualResult);
        
        }

        [TestMethod]
        public void Calculator_Sub_Positive()
        {

            int a = 10, b = 10;
            int exceptedResult = 0;

            int actualResult = c.Sub(a, b);

            Assert.AreEqual(exceptedResult,actualResult);
        }

        public void CleanUp()
        { 
          // dispose all objects
        }

    }
}
