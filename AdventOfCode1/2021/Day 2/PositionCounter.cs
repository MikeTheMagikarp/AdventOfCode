using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1._2021.Day_2
{
    internal class PositionCounter
    {
        public static int FindPosition(string inputFile)
        {
            var horizontal = 0;
            var vertical = 0;

            using(var textReader = new StreamReader(inputFile))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    var values = line.Split(' ');

                    switch (values[0])
                    {
                        case "forward":
                            horizontal += int.Parse(values[1]);
                            break;
                        case "up":
                            vertical -= int.Parse(values[1]);
                            break;
                        case "down":
                            vertical += int.Parse(values[1]);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }

            return horizontal*vertical;
        }

        public static int FindAimedPosition(string inputFile)
        {
            var horizontal = 0;
            var vertical = 0;
            var aim = 0;

            using (var textReader = new StreamReader(inputFile))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    var values = line.Split(' ');

                    switch (values[0])
                    {
                        case "forward":
                            var increase = int.Parse(values[1]);
                            horizontal += increase;
                            vertical += increase * aim;
                            break;
                        case "up":
                            aim -= int.Parse(values[1]);
                            break;
                        case "down":
                            aim += int.Parse(values[1]);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }

            return horizontal * vertical;
        }
    }
}
