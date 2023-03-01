using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet8_playground
{
    public static class RandomnessDemo
    {
        private static readonly string[] s_data = { "Red", "Green", "Blue" };

        public static void TestRandomness()
        {
            //Get Item
            string[] result = Random.Shared.GetItems<string>(s_data, 31);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Get Item\n");
            Console.WriteLine("[{0}]\n", string.Join(", ", result));

            //Shuffle
            string[] trainingData = LoadTrainingData();
            Random.Shared.Shuffle(trainingData);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Shuffle\n");
            Console.WriteLine("[{0}]\n", string.Join(", ", s_data));
        }

        public static string[] LoadTrainingData()
        {
            return s_data;
        }
    }
}
