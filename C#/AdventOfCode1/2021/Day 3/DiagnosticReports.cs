using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1._2021.Day_3
{
    internal class DiagnosticReports
    {
        public static int CalculatePower(string inputFile)
        {
            using (var textReader = new StreamReader(inputFile))
            {
                var list = new List<string>();
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    list.Add(line);
                }

                var length = list.First().Length;
                var total = new int[length];
                foreach (var item in list)
                {
                    for (var i = 0; i < length; i++)
                    {
                        total[i] += int.Parse(item[i].ToString());
                    }
                }

                var gamma = new StringBuilder();
                var epsilon = new StringBuilder();

                for (var i = 0; i < length; i++)
                {
                    if (total[i] > list.Count()/2)
                    {
                        gamma.Append("1");
                        epsilon.Append("0");
                    }
                    else
                    {
                        gamma.Append("0");
                        epsilon.Append("1");
                    }
                }

                var gammaInt = Convert.ToInt32(gamma.ToString(), 2);
                var epsilonInt = Convert.ToInt32(epsilon.ToString(), 2);

                return gammaInt * epsilonInt;
            }
        }
        
        public static int CalculateLifeSupport(string inputFile)
        {
            using (var textReader = new StreamReader(inputFile))
            {
                var list = new List<string>();
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    list.Add(line);
                }

                var length = list.First().Length;
                var total = new int[length];
                foreach (var item in list)
                {
                    for (var i = 0; i < length; i++)
                    {
                        total[i] += int.Parse(item[i].ToString());
                    }
                }

                var pop = new char[length];
                var notPop = new char[length];

                for (var i = 0; i <= length; i++)
                {
                    if (total[i] > list.Count() / 2)
                    {
                        pop[i] = '1';
                        notPop[i] = '0';
                    }
                    else
                    {
                        pop[i] = '0';
                        notPop[i] = '1';
                    }
                }

                var index = 0;

                var o2 = new string[list.Count()];
                var co2Scrubber = new string[list.Count()];

                list.CopyTo(o2);
                list.CopyTo(co2Scrubber);

                var o2List = o2.ToList();
                var co2Scrubberlist = co2Scrubber.ToList();

                while (o2List.Count > 1)
                {
                    o2List = o2List.Where(x => x[index] == pop[index]).ToList();
                    index++;
                }

                var oxygenRating = Convert.ToInt32(o2List.Single(), 2);

                index = 0;

                while (co2Scrubberlist.Count > 1)
                {
                    co2Scrubberlist = co2Scrubberlist.Where(x => x[index] == notPop[index]).ToList();
                    index++;
                }

                var co2ScrubberRating = Convert.ToInt32(co2Scrubberlist.Single(), 2);

                return oxygenRating * co2ScrubberRating;
            }
        }
    }
}
