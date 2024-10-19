using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Абстрактный класс для матриц
    public abstract class SomeMatrix : IMatrix
    {
        protected IVector[] _matrix;
        protected int _rows;
        protected int _columns;

        public SomeMatrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _matrix = InitializeVectors(rows, columns); // Инициализация должна быть в наследниках
        }

        // Абстрактный метод для инициализации векторов
        protected abstract IVector[] InitializeVectors(int rows, int columns);

        public double GetValue(int row, int col)
        {
            return _matrix[row].GetValue(col);
        }

        public void SetValue(int row, int col, double value)
        {
            _matrix[row].SetValue(col, value);
        }

        public int Rows => _rows;
        public int Columns => _columns;

        // Метод для вывода матрицы
        public void PrintMatrix()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"{GetValue(i, j),8:F2} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}