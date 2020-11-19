using System;

namespace ConsoleApp55
{
    class Program
    {
        int x;
        public static void Main(string[] args)
        {
            int m, n, i, j;

            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Setting Zero to illustrate Upper Triangular Matrix\n");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    if (i <= j)
                        Console.Write(A[i, j] + "\t");
                    else
                        Console.Write("0\t");
                }
            }
            Console.ReadLine();
        }
    }
}