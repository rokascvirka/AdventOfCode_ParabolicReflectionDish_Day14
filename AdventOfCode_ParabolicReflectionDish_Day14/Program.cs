using System.Reflection;

namespace AdventOfCode_ParabolicReflectionDish_Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay14.txt");

            var platform = FileReader.ReadFile(FILE_PATH);
            Console.WriteLine("Done!");
        }
    }
}