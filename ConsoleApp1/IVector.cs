using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для векторов
    public interface IVector
    {
        double GetValue(int index);
        void SetValue(int index, double value);
        int Dimension { get; }
    }
}
