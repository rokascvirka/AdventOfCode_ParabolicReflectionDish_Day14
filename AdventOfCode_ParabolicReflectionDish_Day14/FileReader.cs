using AdventOfCode_ParabolicReflectionDish_Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_ParabolicReflectionDish_Day14
{
    public static class FileReader
    {
        public static PlatformModel ReadFile(string path)
        {
            PlatformModel platform = new PlatformModel();
            
            using (StreamReader sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);
                foreach (var line in text)
                {
                    var newLine = line.Split("").ToList();
                    platform.Platform.Add(newLine);
                }
            }

            return platform;
        }
    }
}
