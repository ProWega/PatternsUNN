using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MatrixStatistics
    {
        // Свойства для хранения статистики
        public double Sum { get; private set; }
        public double Average { get; private set; }
        public double MaxValue { get; private set; }
        public int NonZeroCount { get; private set; }

        // Параметризованный конструктор принимает матрицу
        public MatrixStatistics(IMatrix matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix), "Матрица не может быть null.");

            CalculateStatistics(matrix);
        }

        // Метод для вычисления статистики матрицы
        private void CalculateStatistics(IMatrix matrix)
        {
            double sum = 0;
            double maxValue = double.MinValue;
            int nonZeroCount = 0;
            int totalElements = matrix.Rows_count * matrix.Columns_count;

            // Проходим по всем элементам матрицы
            for (int row = 0; row < matrix.Rows_count; row++)
            {
                IVector vector = matrix.Elements[row];
                for (int col = 0; col < matrix.Columns_count; col++)
                {
                    double value = vector.GetElement(col);
                    sum += value;
                    if (value > maxValue)
                    {
                        maxValue = value;
                    }
                    if (value != 0)
                    {
                        nonZeroCount++;
                    }
                }
            }

            // Устанавливаем свойства статистики
            Sum = sum;
            MaxValue = maxValue;
            Average = totalElements > 0 ? sum / totalElements : 0;
            NonZeroCount = nonZeroCount;
        }
    }
}
