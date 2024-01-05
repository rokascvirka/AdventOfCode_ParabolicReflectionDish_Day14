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

        public static void MoveInCycles(PlatformModel platform, long cycles)
        {
            var count = 0;
            while(count <= cycles)
            {
                MoveNorth(platform);
                MoveWest(platform);
                MoveSouth(platform);
                MoveEast(platform);
                count++;
            }
        }
        public static void MoveNorth(PlatformModel platform)
        {
            var columns = platform.Platform[0][0].Length;
            var rows = platform.Platform.Count;


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

        public static void MoveSouth(PlatformModel platform)
        {
            var columns = platform.Platform[0][0].Length;
            var rows = platform.Platform.Count-1;


            for (int col = 0; col < columns; col++)
            {
                int bottomMostEmptyPosition = rows;

                for (int row = rows; row >= 0; row--)
                {
                    if (platform.UpdatedPlatform[row][col] == "O")
                    {
                        platform.UpdatedPlatform[row][col] = ".";
                        platform.UpdatedPlatform[bottomMostEmptyPosition][col] = "O";
                        bottomMostEmptyPosition--;
                    }
                    else if (platform.UpdatedPlatform[row][col] == "#")
                    {
                        platform.UpdatedPlatform[row][col] = "#";
                        bottomMostEmptyPosition = row - 1;
                    }
                }
            }

        }

        public static void MoveWest(PlatformModel platform)
        {
            var columns = platform.Platform[0][0].Length;
            var rows = platform.Platform.Count;

            for (int row = 0; row < rows; row++)
            {
                int mostLeftPosition = 0;
                for (int col = 0; col < columns; col++)
                {
                    if (platform.UpdatedPlatform[row][col] == "O")
                    {
                        platform.UpdatedPlatform[row][col] = ".";
                        platform.UpdatedPlatform[row][mostLeftPosition] = "O";
                        mostLeftPosition++;
                    }
                    else if (platform.UpdatedPlatform[row][col]== "#")
                    {
                        platform.UpdatedPlatform[row][col] = "#";
                        mostLeftPosition = col + 1;
                    }
                }
            }
        }

        public static void MoveEast(PlatformModel platform)
        {
            var columns = platform.Platform[0][0].Length-1;
            var rows = platform.Platform.Count;

            for (int row = 0; row < rows; row++)
            {
                int mostRightPosition = columns;

                for (int col = columns; col >= 0; col--)
                {
                    if (platform.UpdatedPlatform[row][col] == "O")
                    {
                        platform.UpdatedPlatform[row][col] = ".";
                        platform.UpdatedPlatform[row][mostRightPosition] = "O";
                        mostRightPosition--;
                    }
                    else if (platform.UpdatedPlatform[row][col] == "#")
                    {
                        platform.UpdatedPlatform[row][col] = "#";
                        mostRightPosition = col - 1;
                    }
                }
            }
        }
    }
}
