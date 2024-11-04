using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5111
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                {   
                    int[,] matrix = new int[7, 7];
                    Random rand = new Random();

                    Console.WriteLine("Початкова матриця:");
                   
                    for (int i = 0; i < matrix.GetLength(0); i++) { 
                    
                        for (int j = 0; j < matrix.GetLength(1); j++) { 
                        
                            matrix[i, j] = rand.Next(0, 100);
                            Console.Write(matrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    int maxRow = 0;
                    int maxElement = Math.Abs(matrix[0, 0]);

                    for (int i = 1; i < matrix.GetLength(0); i++)
                    {
                        if (Math.Abs(matrix[i, i]) >= maxElement)
                        {
                            maxElement = Math.Abs(matrix[i, i]);
                            maxRow = i;
                        }
                    }

                    if (maxRow < matrix.GetLength(0) - 1)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            int temp = matrix[maxRow, j];
                            matrix[maxRow, j] = matrix[maxRow + 1, j];
                            matrix[maxRow + 1, j] = temp;
                        }
                    }
                    else
                    {
                        
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            int temp = matrix[maxRow, j];
                            matrix[maxRow, j] = matrix[0, j];
                            matrix[0, j] = temp;
                        }
                    }

                    Console.WriteLine("\nПеретворена матриця:");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
