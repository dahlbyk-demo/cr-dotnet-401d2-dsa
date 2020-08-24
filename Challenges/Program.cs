using System;
using Challenges.Arrays;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToReverse = new[] { 1, 2, 3 };

            Reverse.ReverseArray(arrayToReverse);

            Console.WriteLine(String.Join(",", arrayToReverse));
        }
    }
}
