using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Абстрактный класс для матриц
    abstract class SomeMatrix : IMatrix
    {
        public abstract int Rows_count { get; }
        public abstract int Columns_count { get; }
        public abstract List<IVector> Elements { get; }

        public abstract void Read();
        public abstract void Write(List<IVector> vectors);
    }
}