using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_LABAS
{
    class TETriangle
    {
        protected int a;
        public TETriangle()
        {
            this.a = 3;
        }
        public TETriangle(int a)
        {
            if (a <= 0)
                throw new ArgumentException("Сторона трикутника має бути додатним числом");
            this.a = a;
        }
        public TETriangle(TETriangle other)
        {
            this.a = other.A;
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона трикутника має бути додатнім числом");
                a = value;
            }
        }
        public override string ToString()
        {
            return $"Сторона: {this.a}";
        }

        public void PrintData()
        {
            Console.WriteLine(this.ToString());
        }

        public double Square()
        {
            return (Math.Sqrt(3) / 4) * (a * a);
        }

        public double Perimetr()
        {
            return 3 * a;
        }

        public bool Equals(TETriangle other)
        {
            return (other != null && other.A == this.A);
        }

        public static TETriangle operator *(int num, TETriangle other)
        {
            if (num <= 0) throw new ArgumentException("Число має бути додатнім");
            return new TETriangle(num * other.A);
        }
        public static TETriangle operator *(TETriangle other, int num)
        {
            if (num <= 0) throw new ArgumentException("Число має бути додатнім");
            return num * other;
        }
    }


    class TEPiramid : TETriangle
    {
        private int h;
        public TEPiramid()
        {
            this.h = 4;
        }
        public TEPiramid(int a, int h)
            : base(a)
        {
            if (h <= 0)
                throw new ArgumentException("Висота має бути додатнім числом");
            this.h = h;
        }
        public TEPiramid(TEPiramid other)
            : base(other.A)
        {
            this.h = other.H;
        }
        public int H
        {
            get { return h; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Висота має бути додатнім числом");
                h = value;
            }
        }
        public override string ToString()
        {
            return $"Сторона: {this.a}, Висота: {this.h}";
        }

        public new void PrintData()
        {
            Console.WriteLine(this.ToString());
        }
        public new bool Equals(TEPiramid other)
        {
            return (other != null && other.A == this.A && other.H == this.H);
        }

        public double Volume()
        {
            return 1.0 / 3 * (base.Square() * this.h);
        }

        public static TEPiramid operator *(int num, TEPiramid other)
        {
            if (num <= 0) throw new ArgumentException("Число має бути додатнім");
            return new TEPiramid(num * other.A, num * other.H);
        }
        public static TEPiramid operator *(TEPiramid other, int num)
        {
            if (num <= 0) throw new ArgumentException("Число має бути додатнім");
            return new TEPiramid(num * other.A,num * other.H);
        }

    }
}
