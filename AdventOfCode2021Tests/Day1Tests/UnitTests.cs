using AdventOfCode2021.Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AdventOfCodeTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Return_0_For_A_Single_Number_Input()
        {
            List<int> depthReadings = new List<int> { 0 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(0, depthReport);
        }

        [TestMethod]
        public void Return_0_For_A_2_Number_Input_Where_The_Second_Number_Is_Less_Than_The_First()
        {
            List<int> depthReadings = new List<int> { 100, 50 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(0, depthReport);
        }

        [TestMethod]
        public void Return_1_For_A_2_Number_Input_Where_The_Second_Number_Is_Greater_Than_The_First()
        {
            List<int> depthReadings = new List<int> { 50, 100 };
            var depthReport = SeaFloorDepth.rateOfIncrease(depthReadings);
            Assert.AreEqual(1, depthReport);
        }
    }
}
