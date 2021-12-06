using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day1
{
    public static class SeaFloorDepth
    {
        public static int rateOfIncrease(List<int> depthReadings)
        {
            if(depthReadings.Count > 1 && depthReadings[0] < depthReadings[1])
            {
                return 1;
            }
            return 0;
        }
    }
}
