using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа._3
{
    class Fraction
    {
        private int top;
        private int bottom;
        public Fraction(int t, int b)
        {
            top = t;
            bottom = b;
        }
        public int GetTop()
        {
            return top;
        }
        public int GetBottom()
        {
            return bottom;
        }
        public void SetTop(int t)
        {
            top = t;
        }
        public int Bottom
        {
            get { return Bottom; }
            set { bottom = value; }
        }
        public Fraction plus(Fraction f)
        {
            int b = this.bottom * f.bottom;
            int t = this.top * f.bottom + f.top * this.bottom;
            Fraction res = new Fraction(t, b);
            return res;
        }
        public Fraction minus(Fraction f)
        {
            int b = this.bottom * f.bottom;
            int t = this.top * f.bottom - f.top * this.bottom;
            Fraction res = new Fraction(t, b);
            return res;
        }
        public Fraction mult(Fraction f)
        {
            int b = this.bottom * f.bottom;
            int t = this.top * f.top;
            Fraction res = new Fraction(t, b);
            return res;
        }
        public Fraction div(Fraction f)
        {
            int b = this.bottom * f.top;
            int t = this.top * f.bottom;
            Fraction res = new Fraction(t, b);
            return res;
        }
    }
}
