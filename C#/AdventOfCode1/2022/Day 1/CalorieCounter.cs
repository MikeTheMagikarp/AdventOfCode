using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1.Day_1
{
    internal class CalorieCounter
    {
        public static int CountCalories(string inputFile)
        {
            if (!File.Exists(inputFile))
            {
                throw new FileNotFoundException("Could not find file");
            }

            var all = GetCalories(inputFile);

            return all.Max();
        }

        public static int CountCaloriesTopThree(string inputFile)
        {
            if (!File.Exists(inputFile))
            {
                throw new FileNotFoundException("Could not find file");
            }

            var all = GetCalories(inputFile);

            all.Sort();
            var length = all.Count;
            var total = all[length-1] + all[length - 2] + all[length - 3];

            return total;
        }

        public static List<int> GetCalories(string inputFile)
        {
            var all = new List<int>();

            using (var textReader = new StreamReader(inputFile))
            {
                string line;
                var count = 0;

                while ((line = textReader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        all.Add(count);
                        count = 0;
                        continue;
                    }

                    count += int.Parse(line);
                }
            }

            return all;
        }
    }
}
