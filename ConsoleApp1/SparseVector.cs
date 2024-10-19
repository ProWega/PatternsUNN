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
        private readonly Dictionary<int, double> _components;
        private readonly int _size;

        public SparseVector(int size)
        {
            _components = new Dictionary<int, double>();
            _size = size;
        }

        public double GetValue(int index)
        {
            return _components.ContainsKey(index) ? _components[index] : 0.0;
        }

        public void SetValue(int index, double value)
        {
            if (value != 0.0)
            {
                _components[index] = value;
            }
            else
            {
                _components.Remove(index);
            }
        }

        public int Dimension => _size;
    }
}
