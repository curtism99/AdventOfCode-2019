using System;
using static AdventOfCode.Day01;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int PuzzleDay = 1;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Santa has become stranded at the edge of the Solar System while delivering presents to other planets! To accurately calculate his position in space, safely align his warp drive, and return to Earth in time to save Christmas, he needs you to bring him measurements from fifty stars.");
            Console.WriteLine("Collect stars by solving puzzles. Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one star. Good luck!");
            Console.WriteLine("");

            Console.WriteLine("Enter day of puzzle. [int 1-25]");
            PuzzleDay = Int32.Parse(Console.ReadLine());

            switch (PuzzleDay)
            {
                case 1:
                    Day01 day1 = new Day01();
                    day1.ExecuteDay01();
                    break;
            }
        }
    }
}
