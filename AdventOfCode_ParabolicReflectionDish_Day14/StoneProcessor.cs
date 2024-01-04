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
            var columns = platform.Platform[0].Count;
            var rows = platform.Platform.Count;

            for (int i = 1; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (platform.Platform[j][i] == "#")
                    {
                        var stones = CountStones(platform, i, j);

                    }
                }
            }
        }


        private static int CountStones(PlatformModel platform, int column, int startingRow)
        {
            var count = 0;
            var columns = platform.Platform[0].Count;
            var rows = platform.Platform.Count;

            for(int i = startingRow; i < rows; i++)
            {
                for(int j = column; j < columns; j++)
                {
                    if (platform.Platform[i][j] == "0")
                    {
                        count++;
                    }
                    if (platform.Platform[i][j] == "#")
                    {
                        break;
                    }
                }
                break;
            }

            return count;
        }

        private static (List<Coordinates>, List<Coordinates>)  GetStonesInfoFromColumn(PlatformModel platform, int columnIndex)
        {
            var columns = platform.Platform[0].Count;
            var rows = platform.Platform.Count;

            List<Coordinates> hashCoordinates = new List<Coordinates>();
            List<Coordinates> stones = new List<Coordinates>();

            for(int row = 0; row < rows; row++)
            {
                if (platform.Platform[row][columnIndex] == "#")
                {
                     hashCoordinates.Add(new Coordinates(row, columnIndex));
                }
                if (platform.Platform[row][columnIndex] == "O")
                {
                    stones.Add(new Coordinates(row, columnIndex));
                }
            }

            return (hashCoordinates, stones);
        }

        private static void MoveStones(PlatformModel platform, (List<Coordinates>, List<Coordinates>) coords)
        {

        }
    }
}
