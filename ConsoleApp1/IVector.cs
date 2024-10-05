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
        int Size { get; }
        double GetElement(int index);
        void SetElement(int index, double value);
        void Read();
    }
}
