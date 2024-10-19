using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Обычная матрица
    public class RegularMatrix : SomeMatrix
    {
        public RegularMatrix(int rows, int columns) : base(rows, columns) { }

        protected override IVector[] InitializeVectors(int rows, int columns)
        {
            IVector[] vectors = new IVector[rows];
            for (int i = 0; i < rows; i++)
            {
                vectors[i] = new RegularVector(columns);
            }
            return vectors;
        }
    }
}
