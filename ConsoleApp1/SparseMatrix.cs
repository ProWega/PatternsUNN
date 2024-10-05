using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SparseMatrix : SomeMatrix
    {
        private List<SparseVector> _elements = new List<SparseVector>();
        public override int Rows_count { get; }
        public override int Columns_count { get; }

        public override List<IVector> Elements => new List<IVector>(_elements);

        public SparseMatrix(int rows, int columns)
        {
            Rows_count = rows;
            Columns_count = columns;
            for (int i = 0; i < rows; i++)
            {
                _elements.Add(new SparseVector(new double[columns]));
            }
        }

        // Метод для вывода матрицы с красивым форматированием
        public override void Read()
        {
            Console.WriteLine("Элементы разреженной матрицы:");
            foreach (var row in _elements)
            {
                for (int i = 0; i < row.Size; i++)
                {
                    // Форматированный вывод с двумя знаками после запятой и шириной 8 символов
                    Console.Write($"{row.GetElement(i),8:F2}");
                }
                Console.WriteLine(); // Новая строка для каждой строки матрицы
            }
        }

        // Метод для записи данных в матрицу
        public override void Write(List<IVector> vectors)
        {
            if (vectors.Count != Rows_count)
                throw new ArgumentException("Количество векторов не совпадает с количеством строк матрицы.");

            foreach (var vector in vectors)
            {
                if (vector.Size != Columns_count)
                    throw new ArgumentException("Размер вектора не совпадает с количеством столбцов матрицы.");
            }

            _elements.Clear();
            foreach (SparseVector vector in vectors)
            {
                _elements.Add(vector);
            }
        }
    }
}
