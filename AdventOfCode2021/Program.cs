using AdventOfCode2021Day1;
using AdventOfCode2021Day1.Day1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader(@"C:\Users\ttwigden\Desktop\Projects\AdventOfCode\AdventOfCode2021\MeasurementsOfDepths.txt");
            string line = "";
            List<string> measurements = new List<string>();

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    measurements.Add(line);
                }
            }

            myReader.Close();

            var convertedMeasurements = measurements.Select(int.Parse).ToList();
            Console.WriteLine(SeaFloorDepth.rateOfIncrease(convertedMeasurements));
        }
    }
}
