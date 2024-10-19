using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Реализация плотного (простого) вектора
    public class RegularVector : IVector
    {
        private double[] _components;

        public RegularVector(int size)
        {
            _components = new double[size];
        }

        public double GetValue(int index)
        {
            return _components[index];
        }

        public void SetValue(int index, double value)
        {
            _components[index] = value;
        }

        public int Dimension => _components.Length;
    }
}
