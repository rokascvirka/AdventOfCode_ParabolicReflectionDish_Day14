using AdventOfCode_ParabolicReflectionDish_Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_ParabolicReflectionDish_Day14
{
    public static class Calculator
    {
        public static int CountSum(PlatformModel platform)
        {
            var lineValue = 1;
            var sum = 0;    
            for (int i = platform.UpdatedPlatform.Count-1; i >= 0 ; i--)
            {
                var repetitions = 0;
                var item = platform.UpdatedPlatform[i];
                repetitions = item.Count(x => x == "O");
                sum += lineValue * repetitions;
                lineValue++;
            }

            return sum;
        }
    }
}
