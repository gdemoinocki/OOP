using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LAB2.Library
{
    public class Cone<T> : Figure<T> where T : INumber<T>
    {
        private T _r;
        private T _h;

        public Cone(T r, T h) : base(nameof(Cone<T>), FigureType.ThreeD)
        {
            if (r <= T.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(r));
            }
            if ( h <= T.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(h));
            }
            _r = r; 
            _h = h;
        }

        public void Deconstruct(out T r,out T h) 
        { 
            r = _r;
            h = _h;
        }
        public override T CalculatePerimeter()
        {
            return  T.CreateChecked(Math.Round(Math.PI, 20)) * _r * T.CreateChecked(2);
        }

        public override T CalculateSquare()
        {
            //T _l = (T)Convert.ChangeType(Math.Round(Math.Sqrt(Convert.ToDouble((_r * _r) + (_h * _h))), 3), typeof(T));
            //return (T.CreateChecked(Math.Round(Math.PI, 20)) * _r * _l) + (T.CreateChecked( Math.Round(Math.PI, 20)) *(_r * _r));
            T _l = (T)Convert.ChangeType(Math.Round(Math.Sqrt(Convert.ToDouble((_r * _r) + (_h * _h))), 3), typeof(T));
            return (T.CreateChecked(Math.Round(Math.PI, 20)) * _r * _l) + (T.CreateChecked(Math.Round(Math.PI, 20)) * (_r * _r));
        }


        public override T CalculateVolume()
        {
            return T.CreateChecked(1 / 3) * T.CreateChecked(Math.Round(Math.PI, 20)) * (_r * _r) * _h;
        }

    }
}
