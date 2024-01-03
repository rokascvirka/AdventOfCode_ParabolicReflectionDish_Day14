using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_ParabolicReflectionDish_Day14.Models
{
    public class PlatformModel
    {
        public List<LineModel> Platform {  get; set; }

        public List<LineModel>UpdatedPlatform { get; set; }

        public PlatformModel()
        {
            Platform = new List<LineModel>();
            UpdatedPlatform = new List<LineModel>();
        }
    }
}
