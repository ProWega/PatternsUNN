using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    // Реализация разреженного вектора
    public class SparseVector : IVector
    {
        private Dictionary<int, double> elements_ = new Dictionary<int, double>();
        private readonly int _size;

        public int Size => _size;

        public SparseVector(double[] elements)
        {
            _size = elements.Length;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] != 0)
                {
                    elements_.Add(i, elements[i]);
                }
            }
        }

        public double GetElement(int index)
        {
            return elements_.ContainsKey(index) ? elements_[index] : 0.0;
        }

        public void SetElement(int index, double value)
        {
            if (value != 0)
            {
                elements_[index] = value;
            }
            else
            {
                elements_.Remove(index);
            }
        }

        public void Read()
        {
            for (int i = 0; i < _size; i++)
            {
                // Форматированный вывод с двумя знаками после запятой и шириной 8 символов
                Console.Write($"{GetElement(i),8:F2}");
            }
            Console.WriteLine();
        }
    }
}
