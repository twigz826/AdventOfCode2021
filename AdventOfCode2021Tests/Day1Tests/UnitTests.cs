using AdventOfCode2021.Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AdventOfCodeTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod, TestCategory("No inputs")]
        public void Return_0_Empty_List()
        {
            List<int> depthReadings = new List<int> { };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(0, depthReport);
        }

        [TestMethod, TestCategory("Single number input")]
        public void Return_0()
        {
            List<int> depthReadings = new List<int> { 0 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(0, depthReport);
        }

        [TestMethod, TestCategory("Two number input")]
        public void Return_0_Where_The_Second_Number_Is_Less_Than_The_First()
        {
            List<int> depthReadings = new List<int> { 100, 50 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(0, depthReport);
        }

        [TestMethod, TestCategory("Two number input")]
        public void Return_0_Where_The_Second_Number_Is_The_Same_As_The_First()
        {
            List<int> depthReadings = new List<int> { 50, 50 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(0, depthReport);
        }

        [TestMethod, TestCategory("Two number input")]
        public void Return_1_Where_The_Second_Number_Is_Greater_Than_The_First()
        {
            List<int> depthReadings = new List<int> { 50, 100 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(1, depthReport);
        }

    }
}
