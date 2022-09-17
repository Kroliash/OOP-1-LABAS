using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_LABAS
{
    class Triangle
    {
        
       private int[] a;
       private int[] b;
       private int[] c;
       private double[] sides;

       public Triangle (int x1, int y1, int x2, int y2, int x3, int y3)
       {
           a = new int[] { x1, y1 };
           b = new int[] { x2, y2 };
           c = new int[] { x3, y3 };
           SideLength();
       }

       public void SideLength()
       {
           double sideA = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2));
           double sideB = Math.Sqrt(Math.Pow(c[0] - b[0], 2) + Math.Pow(c[1] - b[1], 2));
           double sideC = Math.Sqrt(Math.Pow(a[0] - c[0], 2) + Math.Pow(a[1] - c[1], 2));
           sides = new double[] { sideA, sideB, sideC };
           
       }
       public double Perimeter()
       {
           double perimeter = sides[0] + sides[1] + sides[2];
           return perimeter;
       }

       public double Square()
       {
           double halfPerimeter = this.Perimeter()/2;
           double square = Math.Sqrt(halfPerimeter*(halfPerimeter-sides[0])*(halfPerimeter-sides[1]) * (halfPerimeter - sides[2]));
           return square;
       }
       public int A0
       {
           get => a[0]; 
           set => a[0] = value;
       }

        public int A1
       {
           get => a[1]; 
           set => a[1] = value;
           
       }
        public int B0
        {
            get => b[0];
            set => b[0] = value;
        }

        public int B1
        {
            get => b[1];
            set => b[1] = value;
        }

        public int C0
        {
            get => c[0];
            set => c[0] = value;
        }

        public int C1
        {
            get => a[1];
            set => c[1] = value;
        }

        public double this[int i]
       {
           get
           {
               if (i >= 0 && i < sides.Length)
                   return sides[i];
               else
                   return 0;
           }
       }

    }


}
