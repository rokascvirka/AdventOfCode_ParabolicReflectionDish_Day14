using System.Reflection;

namespace AdventOfCode_ParabolicReflectionDish_Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "FakeData.txt");

            var platform = FileReader.ReadFile(FILE_PATH);


            foreach (var row in platform.Platform)
            {
                Console.WriteLine(string.Join("", row));
            }

            for (int i = 0; i < platform.Platform.Count; i++)
            {
                platform.UpdatedPlatform.Add(new List<string>(Enumerable.Repeat(".", platform.Platform[0][0].Length).ToList()));
            }
            StoneProcessor.MoveNorth(platform);
            Console.WriteLine();


            foreach (var row in platform.UpdatedPlatform)
            {
                Console.WriteLine(string.Join("", row));
            }
            Console.WriteLine();
            StoneProcessor.MoveWest(platform);

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