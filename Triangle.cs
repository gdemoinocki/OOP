using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LAB2.Library
{

    public class Triangle<T> : Figure<T> where T : INumber<T>
    {
        private T _a;
        private T _b;
        private T _c;

        public Triangle(T a, T b, T c) : base(nameof(Triangle<T>), FigureType.SecondD)
        {
            if (a <= T.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }
            if (b <= T.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }
            if (c <= T.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }
            _a = a; 
            _b = b;
            _c = c;

        }
        public void Deconstruct(out T a,out T b,out T c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public override T CalculatePerimeter()
        {
            return _a + _b + _c;
        }

        public override T CalculateSquare()
        {
            T _p = (_a + _b + _c)*T.CreateChecked(0.5);
            return (T)Convert.ChangeType(Math.Round(Math.Sqrt(Convert.ToDouble(_p * (_p - _a) * (_p - _b)*(_p - _c))), 3), typeof(T));
        }


        public override T CalculateVolume()
        {
            //throw new NotSupportedException();
            throw new ArgumentOutOfRangeException();
        }
    }
}
