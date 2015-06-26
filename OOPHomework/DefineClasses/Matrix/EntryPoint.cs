namespace Matrix
{
    using System;

    public class EntryPoint
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix();
            matrix1.Cols = 5;
            matrix1.Rows = 5;
            RandomMatrix(matrix1.Elements, 0, 9);

            Matrix matrix2 = new Matrix();
            matrix2.Cols = 5;
            matrix2.Rows = 5;
            RandomMatrix(matrix2.Elements, 0, 9);

            Matrix result = new Matrix();

            Console.WriteLine("Matrix 1 elements: ");
            PrintMatrix(matrix1.Elements);
            Console.WriteLine();

            Console.WriteLine("Matrix 2 elements: ");
            PrintMatrix(matrix2.Elements);
            Console.WriteLine();

            result = matrix1 + matrix2;
            Console.WriteLine("Addition: ");
            PrintMatrix(result.Elements);
            Console.WriteLine();

            result = matrix1 - matrix2;
            Console.WriteLine("Subtraction: ");
            PrintMatrix(result.Elements);
            Console.WriteLine();

            result = matrix1 * matrix2;
            Console.WriteLine("Multiplication: ");
            PrintMatrix(result.Elements);
            Console.WriteLine();
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void RandomMatrix(int[,] matrix, int smallestNumber, int largestNumber)
        {
            Random rng = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rng.Next(smallestNumber, largestNumber + 1);
                }
            }
        }
    }
}
