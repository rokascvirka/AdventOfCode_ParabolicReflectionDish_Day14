using AdventOfCode_ParabolicReflectionDish_Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_ParabolicReflectionDish_Day14
{
    public class StoneProcessor
    {
        public static void MoveStones(PlatformModel platform)
        {
            var columns = platform.Platform[0][0].Length;
            var rows = platform.Platform.Count;



            for (int i = 0; i < rows; i++)
            {
                platform.UpdatedPlatform.Add(new List<string>(Enumerable.Repeat(".", columns).ToList()));
            }

            for (int col = 0; col < columns; col++)
            {
                int topmostEmptyPosition = 0;

                for (int row = 0; row < rows; row++)
                {
                    if (platform.Platform[row][0][col].ToString() == "O")
                    {
                 
                        platform.UpdatedPlatform[topmostEmptyPosition][col] = "O";
                        topmostEmptyPosition++;
                    }
                    else if (platform.Platform[row][0][col].ToString() == "#")
                    {
                      
                        platform.UpdatedPlatform[row][col] = "#";
                        topmostEmptyPosition = row + 1; 
                    }
                }
            }

        }
    }
}
