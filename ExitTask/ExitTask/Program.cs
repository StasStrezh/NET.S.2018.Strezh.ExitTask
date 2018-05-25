using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitTask
{
    class Program
    {
        /// <summary>
        /// Our maze
        /// </summary>
        const string _maze = @"
Ax     x   ;
 x xxx xxx ;
 x   x     ;
 xxx xxxxxx;
 xxx x x   ;
 x   x x x ;
 x xxx   x ;
 x   x xxx ;
 x x   x x ;
 xxxxx x x ;
       x  B";

        /// <summary>
        /// First parse data, then read it, solve and display
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var array = GetArray.GetArrayofMaze(_maze);
            DisplaySet.Display(array);
            int count = 0;

            while (true)
            {
                string step = Console.ReadLine();
                int result = FindPath.PossiblePath(array);
                if (result == 1)
                {
                    Console.WriteLine($"Solved maze in {count} moves");
                    break;
                }
                else if (result == -1)
                {
                    Console.WriteLine($"Failed to solve maze!");
                    break;
                }
                else
                {
                    DisplaySet.Display(array);
                }
                count++;
            }
            Console.ReadLine();
        }
    }
}
