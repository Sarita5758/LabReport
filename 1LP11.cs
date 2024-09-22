using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita
{
    internal class _1LP11
    {
        /*static void Main()
        {
            Console.WriteLine("Enter the number of rows for the first matrix: ");
            int rowsA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns for the first matrix (and rows for the second matrix): ");
            int colsA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns for the second matrix: ");
            int colsB = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[colsA, colsB];
            int[,] resultMatrix = new int[rowsA, colsB];

            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < colsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            Console.WriteLine("The result of matrix multiplication is:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }*/
    }
}
