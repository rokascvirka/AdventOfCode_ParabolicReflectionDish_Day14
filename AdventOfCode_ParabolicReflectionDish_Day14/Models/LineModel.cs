using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_ParabolicReflectionDish_Day14.Models
{
    public class LineModel
    {
        public List<string> Line {  get; set; }
        public int Value { get; set; }

        public LineModel(List<string> line)
        {
            Line = line;
        }
    }
}
