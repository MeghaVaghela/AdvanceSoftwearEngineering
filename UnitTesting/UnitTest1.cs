using AdvanceSoftware;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTesting
{
    /// <summary>
    /// Unit tests for validating drawing actions in the DesignControl class.
    /// </summary>
    [TestClass]
    
    public class UnitTest1
    {
        DesignControl designControl = new DesignControl();

        /// <summary>
        /// Tests the DrawLine method in DesignControl by drawing a line at specified coordinates.
        /// </summary>
        [TestMethod]
        public void TestDrawLine()
        {
            designControl.DrawLine(100, 300);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }

        /// <summary>
        /// Tests the DrawSquare method in DesignControl by drawing a square of specified size.
        /// </summary>
        [TestMethod]
        public void TestSquare()
        {
            designControl.DrawSquare(25);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }

        /// <summary>
        /// Tests the DrawCircle method in DesignControl by drawing a circle of specified radius.
        /// </summary>
        [TestMethod]
        public void TestCircle()
        {
            designControl.DrawCircle(25);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }

        /// <summary>
        /// Tests the MovePoint method in DesignControl by changing the current drawing position.
        /// </summary>
        [TestMethod]
        public void TestMove()
        {
            designControl.MovePoint(20,100);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }

        /// <summary>
        /// Tests the DrawTriangle method in DesignControl by drawing a triangle with specified coordinates.
        /// </summary>
        [TestMethod]
        public void TestTriangle()
        {
            designControl.DrawTriangle(120, 150, 170);
            Assert.IsTrue(DesignValues.isUnitTestValid);    
        }

        /// <summary>
        /// Tests the DrawRectangle method in DesignControl by drawing a rectangle with specified dimensions.
        /// </summary>
        [TestMethod]
        public void TestRectangle()
        {
            designControl.DrawRectangle(100, 300);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
    }
}
