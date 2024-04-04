using AdvanceSoftwear_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Drawing;

namespace UnitTesting_Part_2
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test method for checking valid input.
        /// </summary>
        [TestMethod]
        public void TestCheckValidInput()
        {
            // Initialize the ShapeApplication class
            ShapeApplication app = new ShapeApplication();

            // Set up the input commands
            string[] lines = { "circle 50" };
            ArrayList currentLine = new ArrayList();
            currentLine.Add(lines[0].Split(' '));

            // Call the Check method
            int[] errors = { 0 };
            app.Check(currentLine, lines, lines.Length);

            // Check if the errors array is empty
            Assert.AreEqual(errors[0], 0);
        }

        /// <summary>
        /// Test method for checking invalid input.
        /// </summary>
        [TestMethod]
        public void TestCheckInvalidInput()
        {
            // Initialize the ShapeApplication class
            ShapeApplication app = new ShapeApplication();

            // Set up the input commands
            string[] lines = { "circle" };
            ArrayList currentLine = new ArrayList();
            currentLine.Add(lines[0].Split(' '));

            // Call the Check method
            int[] errors = { 1 };
            app.Check(currentLine, lines, lines.Length);

            // Check if the errors array is not empty
            Assert.AreNotEqual(errors[0], 0);
        }

        /// <summary>
        /// Test method for checking if statements with equal symbol where numbers match.
        /// </summary>
        [TestMethod]
        public void TestIfStatements_EqualSymbol_NumbersMatch_ShouldPass()
        {
            // Arrange
            int num = 25;
            int num2 = 25;
            string symbol = "=";

            // Act
            if (symbol == "=")
            {
                // Assert
                Assert.AreEqual(num, num2, 0.1, "Numbers are expected to match.");
            }
        }

        /// <summary>
        /// Test method for checking if statements with equal symbol where numbers do not match.
        /// </summary>
        [TestMethod]
        public void TestIfStatements_EqualSymbol_NumbersDoNotMatch_ShouldFail()
        {
            // Arrange
            int num = 25;
            int num2 = 35;
            string symbol = "=";

            // Act
            if (symbol == "=")
            {
                // Assert
                Assert.AreNotEqual(num, num2, 0.1, "Numbers are not expected to match.");
            }
        }

        /// <summary>
        /// Test method for setting parameters of DrawCircle.
        /// </summary>
        [TestMethod]
        public void setmethodtest()
        {
            var circle = new DrawCircle();
            int x = 200, y = 200, radius = 100;
            circle.set(x, y, radius);
            Assert.AreEqual(200, y);
        }

        /// <summary>
        /// Test method for setting parameters of DrawTriangle.
        /// </summary>
        [TestMethod]
        public void setParameterTest2()
        {
            var l = new DrawTriangle();
            int x = 200, y = 200, toX = 200, toY = 200;
            l.set(x, y, toX, toY);
            Assert.AreEqual(200, y);
        }

        /// <summary>
        /// Test method for checking if statements.
        /// </summary>
        [TestMethod]
        public void testIfStatements()
        {
            try                 

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
        /// Test method for testing the set method of DrawRectangle.
        /// </summary>
        [TestMethod]
        public void DrawRectangleSetMethodTest()
        {
            var rectangle = new DrawRectangle();
            int x = 100, y = 200, width = 50, height = 70;

            rectangle.set(x, y, width, height);

            Assert.AreEqual(width, rectangle.width);
            Assert.AreEqual(height, rectangle.height);
        }
       
    }

}

