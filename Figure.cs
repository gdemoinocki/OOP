using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LAB2.Library
{
    public enum FigureType
    {
        SecondD,
        ThreeD
    }
    public abstract class Figure<T> where T : INumber<T>
    {
        public string Name { get; }

        public FigureType Type { get; }

        protected Figure(string name, FigureType type)
        {
            Name = name;
            Type = type;
        }


        public abstract T CalculatePerimeter();
        public abstract T CalculateSquare();
        public abstract T CalculateVolume();

        //public event EventHandler<FigureEventArgs> CalculatePerimeter;
        //public event EventHandler<FigureEventArgs> CalculateSqure;
        //public event EventHandler<FigureEventArgs> CalculateVolume;


    }
}
