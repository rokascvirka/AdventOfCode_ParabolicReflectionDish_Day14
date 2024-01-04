using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_ParabolicReflectionDish_Day14.Models
{
    public class PlatformModel
    {
        public List<List<string>> Platform {  get; set; }

        public List<List<string>>  UpdatedPlatform { get; set; }

        public PlatformModel()
        {
            Platform = new List<List<string>>();
            UpdatedPlatform = new List<List<string>>();
        }
    }
}
