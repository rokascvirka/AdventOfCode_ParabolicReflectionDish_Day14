using System.Reflection;

namespace AdventOfCode_ParabolicReflectionDish_Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay14.txt");

            var platform = FileReader.ReadFile(FILE_PATH);


            foreach (var row in platform.Platform)
            {
                Console.WriteLine(string.Join("", row));
            }
            StoneProcessor.MoveStones(platform);

            Console.WriteLine();

            foreach (var row in platform.UpdatedPlatform)
            {
                Console.WriteLine(string.Join("", row));
            }

           var sum = Calculator.CountSum(platform);

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}