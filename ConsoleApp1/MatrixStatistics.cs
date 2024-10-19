using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс для статистики матрицы
    public class MatrixStatistics
    {
        private double _sum;
        private double _maxValue;
        private int _nonZeroCount;

        public MatrixStatistics(IMatrix matrix)
        {
            _sum = 0;
            _maxValue = double.MinValue;
            _nonZeroCount = 0;
            CalculateStatistics(matrix);
        }

        private void CalculateStatistics(IMatrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    double value = matrix.GetValue(i, j);
                    if (value != 0)
                    {
                        _sum += value;
                        _maxValue = Math.Max(_maxValue, value);
                        _nonZeroCount++;
                    }
                }
            }
        }

        public double Sum => _sum;
        public double Average => _nonZeroCount > 0 ? _sum / _nonZeroCount : 0;
        public double MaxValue => _maxValue;
        public int NonZeroCount => _nonZeroCount;
    }
}
