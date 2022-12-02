using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1._2021.Day_1
{
    internal class DepthCounter
    {
        public static int CountIncreases(string inputFile)
        {
            var increases = 0;
            using (var textReader = new StreamReader(inputFile))
            {
                string line;
                var previous = -1;

                while ((line = textReader.ReadLine()) != null)
                {
                    var depth = int.Parse(line);

                    if (previous == -1)
                    {
                        previous = depth;
                        continue;
                    }

                    if (previous < depth)
                    {
                        increases++;
                    }
                    
                    previous = depth;
                }
            }

            return increases;
        }

        public static int CountSlidingWindowIncreases(string inputFile)
        {
            var increases = 0;
            var list = new List<int>();
            
            using (var textReader = new StreamReader(inputFile))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    var depth = int.Parse(line);
                    list.Add(depth);
                }
            }

            var index = 0;
            var previous = -1;
            while (index + 2 < list.Count) 
            {
                var depth = list[index] + list[index + 1] + list[index + 2];

                index++;
                if (previous == -1)
                {
                    previous = depth;
                    continue;
                }
                
                if (previous < depth)
                {
                    increases++;
                }

                previous = depth;
            }

            return increases;
        }
    }
}
