using AdventOfCode1._2021.Day_1;
using AdventOfCode1.Day_1;
using AdventOfCode1._2022.Day_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode1._2021.Day_2;
using AdventOfCode1._2021.Day_3;

namespace AdventOfCode1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var problem = args[0];


            switch (problem)
            {
                #region 2022
                case "2022-1a":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(CalorieCounter.CountCalories(args[1]));
                    break;
                case "2022-1b":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(CalorieCounter.CountCaloriesTopThree(args[1]));
                    break;

                case "2022-2a":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(RockPaperScissors.CheckScore(args[1]));
                    break;
                case "2022-2b":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(RockPaperScissors.GetNeededScore(args[1]));
                    break;

                #endregion


                #region 2021

                case "2021-1a":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(DepthCounter.CountIncreases(args[1]));
                    break;
                case "2021-1b":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(DepthCounter.CountSlidingWindowIncreases(args[1]));
                    break;
                case "2021-2a":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(PositionCounter.FindPosition(args[1]));
                    break;
                case "2021-2b":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(PositionCounter.FindAimedPosition(args[1]));
                    break;
                case "2021-3a":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(DiagnosticReports.CalculatePower(args[1]));
                    break;
                case "2021-3b":
                    if (args.Length != 2)
                    {
                        throw new ArgumentException("No input file");
                    }

                    Console.WriteLine(DiagnosticReports.CalculateLifeSupport(args[1]));
                    break;

                #endregion
                default: 
                    throw new ArgumentException();
            }
        }
    }
}
