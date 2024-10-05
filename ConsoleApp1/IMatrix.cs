using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для матриц
    public interface IMatrix
    {
        int Rows_count { get; }
        int Columns_count { get; }
        List<IVector> Elements { get; }
        void Read();
        void Write(List<IVector> vectors);
    }
}