using System.Collections.Generic;

namespace ConsoleApp3
{
    public class MagicSquareGenerator
    {
        public List<List<int>> Generate(int size)
        {
            var square = new Square();
            var verifier = new Verifier();
            bool verified = false;
            List<List<int>> generatedArray = new List<List<int>>();

            while (!verified)
            {
                generatedArray.Clear();

                for (int i = 0; i < size; i++)
                {
                    generatedArray.Add(square.Generate(size));
                }

                verified = verifier.Verify(generatedArray);
            }

            return generatedArray;
        }
    }
}
