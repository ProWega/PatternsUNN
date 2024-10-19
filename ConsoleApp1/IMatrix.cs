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
        double GetValue(int row, int col);
        void SetValue(int row, int col, double value);
        int Rows { get; }
        int Columns { get; }
        void PrintMatrix();  // Метод для вывода матрицы
    }
}