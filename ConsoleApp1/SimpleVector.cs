using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Реализация плотного (простого) вектора
    internal class SimpleVector : IVector
    {
        private List<double> _elements;
        public int Size => _elements.Count;

        public SimpleVector(int size, List<double> elements)
        {
            _elements = elements;
        }

        public double GetElement(int index)
        {
            return _elements[index];
        }

        public void SetElement(int index, double value)
        {
            _elements[index] = value;
        }

        public void Read()
        {
            foreach (var el in _elements)
            {
                // Форматированный вывод с двумя знаками после запятой и шириной 8 символов
                Console.Write($"{el,8:F2}");
            }
            Console.WriteLine();
        }
    }
}
