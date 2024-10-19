using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SparseMatrix : SomeMatrix
    {
        private readonly double _sparsity;

        public SparseMatrix(int rows, int columns, double sparsity) : base(rows, columns)
        {
            _sparsity = sparsity;
        }

        protected override IVector[] InitializeVectors(int rows, int columns)
        {
            IVector[] vectors = new IVector[rows];
            for (int i = 0; i < rows; i++)
            {
                vectors[i] = new SparseVector(columns);
            }
            return vectors;
        }

        // Метод для заполнения матрицы с коэффициентом разреженности
        public void PopulateWithSparsity(double maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    double chance = random.NextDouble(); // Шанс на добавление значения
                    if (chance < _sparsity)
                    {
                        double value = Math.Round(random.NextDouble() * maxValue, 2);
                        SetValue(i, j, value);  // Устанавливаем ненулевое значение
                    }
                }
            }
        }
    }
}
