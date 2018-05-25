using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitTask
{
    public class FindPath
    {
        /// <summary>
        /// Possible moves
        /// </summary>
        static int[][] _moves = {
        new int[] { 1, 0 },
        new int[] { 0, 1 },
        new int[] { -1, 0 },
        new int[] { 0, -1 }, };

        /// <summary>
        /// Checking if our position is valid or not
        /// </summary>
        /// <param name="array"></param>
        /// <param name="row"></param>
        /// <param name="newRow"></param>
        /// <param name="newColumn"></param>
        /// <returns>Bool</returns>
        static bool IsValidPosition(int[][] array, int row, int newRow, int newColumn)
        {
            if (newRow < 0) return false;
            if (newColumn < 0) return false;
            if (newRow >= array.Length) return false;
            if (newColumn >= array[row].Length) return false;
            return true;
        }
        /// <summary>
        /// Make all possible moves from our position
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Step, error or finish</returns>
        public static int PossiblePath(int[][] array)
        {
            for (int rowIndex = 0; rowIndex < array.Length; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < array[rowIndex].Length; columnIndex++)
                {
                    int value = array[rowIndex][columnIndex];
                    if (value >= 1)
                    {
                        foreach (var movePair in _moves)
                        {
                            int newRow = rowIndex + movePair[0];
                            int newColumn = columnIndex + movePair[1];
                            if (IsValidPosition(array, rowIndex, newRow, newColumn))
                            {
                                if (array[newRow][newColumn] == 0)
                                {
                                    array[newRow][newColumn] += 2;
                                    return 0;
                                }
                                else if (array[newRow][newColumn] == 100)
                                {
                                    return 1;
                                }
                            }
                        }
                    }
                }
            }
            return -1;
        }
    }
}
