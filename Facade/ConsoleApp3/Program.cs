using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MagicSquareGenerator();
            var square = test.Generate(4);

            Console.WriteLine(SquareToString(square));
        }
        private static string SquareToString(List<List<int>> square)
        {
            var sb = new StringBuilder();
            foreach (var row in square)
            {
                sb.AppendLine(string.Join(" ",
                  row.Select(x => x.ToString())));
            }

            return sb.ToString();
        }
    }
}
