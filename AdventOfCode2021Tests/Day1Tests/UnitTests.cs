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
    }
}
