using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod()]
        public void MultiplicateTest()
        {
            int nn = 2;
            Matrix matrix1 = new Matrix(nn);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;
            Matrix matrix2 = new Matrix(nn);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;
            string exp = "19\t22\t43\t50\t";
            string act = "";

            Matrix actual = new Matrix(nn);
            actual = matrix1 * matrix2;
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    act += actual[i, j] + "\t";
                }
            }
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void AddTest()
        {
            int nn = 2;
            Matrix matrix1 = new Matrix(nn);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;
            Matrix matrix2 = new Matrix(nn);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;
            string exp = "6\t8\t10\t12\t";
            string act = "";

            Matrix actual = new Matrix(nn);
            actual = matrix1 + matrix2;
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    act += actual[i, j] + "\t";
                }
            }
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            int nn = 2;
            Matrix matrix1 = new Matrix(nn);
            matrix1[0, 0] = 10;
            matrix1[0, 1] = 20;
            matrix1[1, 0] = 30;
            matrix1[1, 1] = 40;
            Matrix matrix2 = new Matrix(nn);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;
            string exp = "5\t14\t23\t32\t";
            string act = "";

            Matrix actual = new Matrix(nn);
            actual = matrix1 - matrix2;
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    act += actual[i, j] + "\t";
                }
            }
            Assert.AreEqual(exp, act);
        }
    }
}