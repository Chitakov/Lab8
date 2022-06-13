using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Matrix
    {
        private int n;
        private int[,] matrix;

        public Matrix() { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        public Matrix(int n)
        {
            this.n = n;
            matrix = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }

        // Ввод матрицы с клавиатуры
        public void EnterMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы ({0}; {1})", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Вывод матрицы
        public void PrintMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Умножение матрицы А на матрицу Б
        public static Matrix Multiplicate(Matrix a, Matrix b)
        {
            Matrix matrix_multiplication = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        matrix_multiplication[i, j] += a[i, k] * b[k, j];

            return matrix_multiplication;
        }

        // перегрузка оператора умножения
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.Multiplicate(a, b);
        }

        // Вычитание матрицы Б из матрицы А
        public static Matrix Subtract(Matrix a, Matrix b)
        {
            Matrix matrix_substraction = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    matrix_substraction[i, j] = a[i, j] - b[i, j];
                }
            }
            return matrix_substraction;
        }

        // Перегрузка оператора вычитания
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return Matrix.Subtract(a, b);
        }
        // Сложение матрицы А и матрицы Б
        public static Matrix Add(Matrix a, Matrix b)
        {
            Matrix matrix_addition = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    matrix_addition[i, j] = a[i, j] + b[i, j];
                }
            }
            return matrix_addition;
        }
        // Перегрузка сложения
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Add(a, b);
        }
    }
}
