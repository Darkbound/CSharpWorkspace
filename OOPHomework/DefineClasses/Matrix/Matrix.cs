namespace Matrix
{
    using System;

    public class Matrix
    {
        private int rows;
        private int cols;

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                this.rows = value;
                if (this.cols > 0)
                {
                    this.Elements = new int[this.rows, this.cols];
                }
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            set
            {
                this.cols = value;
                if (this.rows > 0)
                {
                    this.Elements = new int[this.rows, this.cols];
                }
            }
        }

        public int[,] Elements { get; private set; }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if ((matrix1.Cols != matrix2.Cols) || (matrix1.Rows != matrix2.Rows))
            {
                throw new ArithmeticException("Matrix dimensions do not agree!");
            }
            
            Matrix matrix = new Matrix();
            matrix.Rows = matrix1.Rows;
            matrix.Cols = matrix1.Cols;
            
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix.Elements[i, j] = matrix1.Elements[i, j] + matrix2.Elements[i, j];
                }
            }

            return matrix;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if ((matrix1.Cols != matrix2.Cols) || (matrix1.Rows != matrix2.Rows))
            {
                throw new ArithmeticException("Matrix dimensions do not agree!");
            }

            Matrix matrix = new Matrix();
            matrix.Rows = matrix1.Rows;
            matrix.Cols = matrix1.Cols;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix.Elements[i, j] = matrix1.Elements[i, j] - matrix2.Elements[i, j];
                }
            }

            return matrix;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Cols)
            {
                throw new ArithmeticException("Matrix dimensions do not agree!");
            }

            Matrix matrix = new Matrix();
            matrix.Cols = matrix1.Cols;
            matrix.Rows = matrix1.Rows;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    for (int z = 0; z < matrix.Rows; z++)
                    {
                        matrix.Elements[i, j] = matrix.Elements[i, j] + (matrix1.Elements[i, z] * matrix2.Elements[z, j]);
                    }
                }
            }

            return matrix;
        }
    }
}
