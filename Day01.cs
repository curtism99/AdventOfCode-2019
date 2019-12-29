using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AdventOfCode
{
    class Day01
    {
        //static void Main(string[] args)
        //{
            
            

        //}

        internal void ExecuteDay01()
        {
            Console.WriteLine("Day 01 Puzzle");
            Console.WriteLine("The Elves quickly load you into a spacecraft and prepare to launch.");
            Console.WriteLine("At the first Go / No Go poll, every Elf is Go until the Fuel Counter-Upper. They haven't determined the amount of fuel required yet.");
            Console.WriteLine("Fuel required to launch a given module is based on its mass. Specifically, to find the fuel required for a module, take its mass, divide by three, round down, and subtract 2.");
            Console.WriteLine("For example: \nFor a mass of 12, divide by 3 and round down to get 4, then subtract 2 to get 2. \nFor a mass of 14, dividing by 3 and rounding down still yields 4, so the fuel required is also 2. \nFor a mass of 1969, the fuel required is 654. \nFor a mass of 100756, the fuel required is 33583.");
            Console.WriteLine("The Fuel Counter-Upper needs to know the total fuel requirement. To find it, individually calculate the fuel needed for the mass of each module (your puzzle input), then add together all the fuel values. \nWhat is the sum of the fuel requirements for all of the modules on your spacecraft ? ");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            int counter = 0;
            string line;
            string directory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); 
            Console.WriteLine(directory);
            string newPath = Path.GetFullPath(Path.Combine(directory, @"..\..\..\PuzzleInputs\"));
            Console.WriteLine(newPath);
            System.IO.StreamReader file = new System.IO.StreamReader(newPath + "Day01Puzzle1.txt");

            int[] PuzzleInput = new int[100];
            int CurrentArrayPosition = 0;

            while ((line = file.ReadLine()) != null)
            {
                PuzzleInput[CurrentArrayPosition] = Int32.Parse(line);
                CurrentArrayPosition++;
                //System.Console.WriteLine(line);
                counter++;
            }
            file.Close();
            Console.WriteLine("There were {0} lines of input text.\nPress Enter to continue.", counter);
            Console.ReadLine();

            int RunningTotal = 0;

            foreach (decimal current in PuzzleInput)
            {
                
                int CurrentMath = Convert.ToInt32(Math.Floor(current / 3));
                CurrentMath = CurrentMath - 2;
                RunningTotal = RunningTotal + CurrentMath;
            };

            Console.WriteLine("Total fuel needed = {0}\nPress Enter to continue to Part 2.", RunningTotal);
            Console.ReadLine();

            //throw new NotImplementedException();
        }
    }
}
