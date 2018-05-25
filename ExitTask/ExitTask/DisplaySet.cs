using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitTask
{
    public class DisplaySet
    {
        /// <summary>
        /// Display int data as a characters
        /// </summary>
        /// <param name="array"></param>
        public static void Display(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var row = array[i];
                for (int x = 0; x < array[i].Length; x++)
                {
                    switch (row[x])
                    {
                        case -1:
                            Console.Write('x');
                            break;
                        case 1:
                            Console.Write('A');
                            break;
                        case 100:
                            Console.Write('B');
                            break;
                        case 0:
                            Console.Write(' ');
                            break;
                        default:
                            Console.Write('.');
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
