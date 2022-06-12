using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: ");
            int nn = Convert.ToInt32(Console.ReadLine());
           
            Matrix matrix1 = new Matrix(nn);
            Matrix matrix2 = new Matrix(nn);
            Matrix matrix_addition = new Matrix(nn);
            Matrix matrix_subtraction = new Matrix(nn);
            Matrix matrix_multiplication = new Matrix(nn);
            
            Console.WriteLine("Ввод Матрица А: ");
            matrix1.EnterMatrix();
            Console.WriteLine("Ввод Матрица B: ");
            matrix2.EnterMatrix();

            Console.WriteLine("Матрица А: ");
            matrix1.PrintMatrix();
            Console.WriteLine();
            Console.WriteLine("Матрица В: ");
            Console.WriteLine();
            matrix2.PrintMatrix();

            Console.WriteLine("Сложение матриц А и Б: ");
            matrix_addition = matrix1 + matrix2;
            matrix_addition.PrintMatrix();

            Console.WriteLine("Вычитание матриц А и Б: ");
            matrix_subtraction = matrix1 - matrix2;
            matrix_subtraction.PrintMatrix();

            Console.WriteLine("Умножение матриц А и Б: ");
            matrix_multiplication = matrix1 * matrix2;
            matrix_multiplication.PrintMatrix();

            Console.ReadKey();
        }
    }
}
