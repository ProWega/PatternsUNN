using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Реализация обычной матрицы
    internal class SimpleMatrix : SomeMatrix
    {
        private List<SimpleVector> _elements = new List<SimpleVector>();
        public override int Rows_count { get; }
        public override int Columns_count { get; }

        public override List<IVector> Elements => new List<IVector>(_elements);

        public SimpleMatrix(int rows, int columns)
        {
            Rows_count = rows;
            Columns_count = columns;
            for (int i = 0; i < rows; i++)
            {
                _elements.Add(new SimpleVector(columns, new List<double>(new double[columns])));
            }
        }

        // Метод для вывода матрицы с красивым форматированием
        public override void Read()
        {
            Console.WriteLine("Элементы плотной матрицы:");
            foreach (var vector in _elements)
            {
                for (int i = 0; i < vector.Size; i++)
                {
                    // Форматирование вывода: выделяем по 8 символов на число с двумя знаками после запятой
                    Console.Write($"{vector.GetElement(i),8:F2}");
                }
                Console.WriteLine(); // Новая строка для каждого вектора (строки матрицы)
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
            foreach (SimpleVector vector in vectors)
            {
                _elements.Add(vector);
            }
        }
    }
}
