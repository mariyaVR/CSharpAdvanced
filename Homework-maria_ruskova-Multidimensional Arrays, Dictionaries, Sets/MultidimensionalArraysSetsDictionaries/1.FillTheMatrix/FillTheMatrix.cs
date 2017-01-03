using System;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        // input
        int n = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];

        //filling matrix1
        int index1 = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix1[row, col] = index1;
                index1++;
            }
        }

        //filling matrix2
        int index2 = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix2[row, col] = index2;
                    index2++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix2[row, col] = index2;
                    index2++;
                }
            }
        }

        //printing
        PrintMatrix(matrix1);
        PrintMatrix(matrix2);
    }

    private static void PrintMatrix(int[,] matrix)
    {
    for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }

            Console.WriteLine();
        }

         Console.WriteLine();
    }
}

