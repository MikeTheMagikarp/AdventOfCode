using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1._2022.Day_2
{
    internal class RockPaperScissors
    {
        public static int CheckScore(string inputFile)
        {
            if (!File.Exists(inputFile))
            {
                throw new FileNotFoundException("Could not find file");
            }

            var totalScore = 0;

            using (var textReader = new StreamReader(inputFile))
            {
                string line;

                while ((line = textReader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {

                    }

                    var values = line.Split(' ');

                    var opponent = GetItemValue(values[0]);
                    var elf = GetItemValue(values[1]);

                    // Draw
                    if (opponent == elf)
                    {
                        totalScore += elf + 3;
                    }
                    else if (opponent == 1 && elf == 2) // Win R - P 
                    {
                        totalScore += elf + 6;
                    }
                    else if (opponent == 2 && elf == 3) // Win P - S
                    {
                        totalScore += elf + 6;
                    }
                    else if (opponent == 3 && elf == 1) // Win S - R
                    {
                        totalScore += elf + 6;
                    }
                    else if (opponent == 2 && elf == 1) // Lose R - P 
                    {
                        totalScore += elf;
                    }
                    else if (opponent == 3 && elf == 2) // Lose P - S
                    {
                        totalScore += elf;
                    }
                    else if (opponent == 1 && elf == 3) // Lose S - R
                    {
                        totalScore += elf;
                    }

                    else // Win
                    {
                        
                    }

                }
            }

            return totalScore;
        }

        public static int GetNeededScore(string inputFile)
        {
            if (!File.Exists(inputFile))
            {
                throw new FileNotFoundException("Could not find file");
            }

            var totalScore = 0;

            using (var textReader = new StreamReader(inputFile))
            {
                string line;

                while ((line = textReader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {

                    }

                    var values = line.Split(' ');

                    var opponent = GetItemValue(values[0]);
                    var roundResult = values[1];

                    // Lose
                    if (roundResult == "X")
                    {
                        if (opponent == 1)
                        {
                            totalScore += 3;
                        }
                        else if(opponent == 2)
                        {
                            totalScore += 1;
                        }
                        else
                        {
                            totalScore += 2;
                        }
                    }
                    else if (roundResult == "Y") // Draw
                    {
                        totalScore += 3;
                        
                        if (opponent == 1)
                        {
                            totalScore += 1;
                        }
                        else if (opponent == 2)
                        {
                            totalScore += 2;
                        }
                        else
                        {
                            totalScore += 3;
                        }
                    }
                    else // Win 
                    {
                        totalScore += 6;

                        if (opponent == 1)
                        {
                            totalScore += 2;
                        }
                        else if (opponent == 2)
                        {
                            totalScore += 3;
                        }
                        else
                        {
                            totalScore += 1;
                        }
                    }
                }
            }

            return totalScore;
        }

        private static int GetItemValue(string key)
        {
            switch (key)
            {
                // Rock
                case "A":
                case "X":
                    return 1;

                // Paper
                case "B":
                case "Y":
                    return 2;

                //Scissors
                case "C":
                case "Z":
                    return 3;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
