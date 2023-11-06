using AdvanceSoftware;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        DesignControl designControl = new DesignControl();

        [TestMethod]
        public void TestDrawLine()
        {
            designControl.DrawLine(100, 300);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
        [TestMethod]
        public void TestSquare()
        {
            designControl.DrawSquare(25);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
        [TestMethod]
        public void TestCircle()
        {
            designControl.DrawCircle(25);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
        [TestMethod]
        public void TestMove()
        {
            designControl.MovePoint(20,100);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
        [TestMethod]
        public void TestTriangle()
        {
            designControl.DrawTriangle(120, 150, 170);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
        [TestMethod]
        public void TestRectangle()
        {
            designControl.DrawRectangle(100, 300);
            Assert.IsTrue(DesignValues.isUnitTestValid);
        }
    }
}
