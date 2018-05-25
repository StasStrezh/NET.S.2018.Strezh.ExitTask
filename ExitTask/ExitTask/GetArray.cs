using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitTask
{
    public class GetArray
    {
        /// <summary>
        /// Split our maze and set ints from chars
        /// </summary>
        /// <param name="maze"></param>
        /// <returns>Int jagged array</returns>
        public static int[][] GetArrayofMaze(string maze)
        {
            string[] maze_lines = maze.Split(new char[] { ';', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            int[][] array = new int[maze_lines.Length][];

            for (int i = 0; i < maze_lines.Length; i++)
            {
                string line = maze_lines[i];
                var row = new int[line.Length];
                for (int x = 0; x < line.Length; x++)
                {
                    switch (line[x])
                    {
                        case 'x':
                            row[x] = -1;
                            break;
                        case 'A':
                            row[x] = 1;
                            break;
                        case 'B':
                            row[x] = 100;
                            break;
                        default:
                            row[x] = 0;
                            break;
                    }
                }
                array[i] = row;
            }
            return array;
        }

    }
}
