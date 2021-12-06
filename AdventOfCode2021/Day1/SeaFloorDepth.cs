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
            int counter = 0;
            for(int i = 0; i < depthReadings.Count - 1; i++)
            {
                if(depthReadings[i] < depthReadings[i+1])
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}