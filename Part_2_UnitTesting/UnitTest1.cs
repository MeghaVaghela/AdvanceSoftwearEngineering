using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ASE_Part2;

namespace Part_2_UnitTesting
{
    /// <summary>
    /// Contains unit tests for various methods in ASE_Part2 classes.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests if statements comparing two numbers.
        /// </summary>
        [TestMethod]
        public void testIfStatements()
        {
            try                 // Test logic for comparing numbers

            {
                int num = 25;
                int num2 = 35;
                string symbol = "=";
                if (symbol == "=")
                {
                    if (num == num2)
                    {
                        Assert.AreEqual(num, num2, 00.1, "Numbers are matched");
                    }
                    else
                    {
                        Assert.AreNotEqual(num, num2, 00.1, "Numbers are not matched");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Symbol is not correct.");
            }
        }

        /// <summary>
        /// Tests the set method of drawRectangle.
        /// </summary>
        [TestMethod]
        public void setParameterTest()             // Test logic for drawRectangle set method
        {
            var r = new drawRectangle();
            int x = 200, y = 200, width = 100, height = 100;
            r.set(x, y, height, width);
            Assert.AreEqual(200, 400);
        }

        /// <summary>
        /// Tests the set method of drawRectangle with different parameters.
        /// </summary>
        [TestMethod]
        public void setParameterTest3()
        {
            var r = new drawRectangle();
            int x = 100, y = 300, width = 200, height = 400;
            r.set(x, y, height, width);
            Assert.AreEqual(x, y);
        }

        /// <summary>
        /// Tests the set method of drawTriangle.
        /// </summary>
        [TestMethod]
        public void setParameterTest2()
        {
            var l = new drawTriangle();
            int x = 200, y = 200, toX = 200, toY = 200;
            l.set(x, y, toX, toY);
            Assert.AreEqual(200, y);
        }
        /// <summary>
        /// Tests the set method of drawCircle.
        /// </summary>
        [TestMethod]
        public void setmethodtest()
        {
            var circle = new drawCircle();
            int x = 200, y = 200, radius = 100;
            circle.set(x, y, radius);
            Assert.AreEqual(200, y);
        }

    }
}
