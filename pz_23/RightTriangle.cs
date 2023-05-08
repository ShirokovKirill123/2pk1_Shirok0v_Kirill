using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class RightTriangle : Triangle1
    {
        public int d = 6;
        public int e = 8;
        public int f = 10;


        public RightTriangle(int z, int x, int c)
            : base(z, x, c)
        {
            this.d = z;
            this.e = x;
            this.f = c;
        }

        public RightTriangle() : base() { }

        public RightTriangle(int z)
            : base(z)
        {
            this.d = z;
        }

        public RightTriangle(int z, int x)
            : base(z, x)
        {
            this.d = z;
            this.e = x;
        }

        public override double GetTriangleArea()
        {
            double j = (double)d;
            double k = (double)e;
            double l = (double)f;

            double S1 = 0;
            if ((f > e) && (f > d))
            {
                S1 = ((double)1 / 2) * j * k;
                return S1;
            }
            else if ((d > e) && (d > f))
            {
                S1 = ((double)1 / 2) * k * l;
                return S1;
            }
            else if ((e > d) && (e > f))
            {
                S1 = ((double)1 / 2) * l * j;
                return S1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Метод не считает площадь не прямоугольного треугольника");
            }
            return S1;
        }

        public override bool IsRectangular()
        {
            bool chek2 = false;

            if ((d > e) && (d > f))
            {
                if ((Math.Pow(d, 2)) == (Math.Pow(e, 2)) + (Math.Pow(f, 2)))
                {
                    chek2 = true;
                }
                else
                {
                    chek2 = false;
                }
                return chek2;
            }
            if ((e > d) && (e > f))
            {
                if ((Math.Pow(e, 2)) == (Math.Pow(d, 2)) + (Math.Pow(f, 2)))
                {
                    chek2 = true;
                }
                else
                {
                    chek2 = false;
                }
                return chek2;
            }
            if ((f > e) && (f > d))
            {
                if ((Math.Pow(f, 2)) == (Math.Pow(e, 2)) + (Math.Pow(d, 2)))
                {
                    chek2 = true;
                }
                else
                {
                    chek2 = false;
                }
                return chek2;
            }
            bool result = chek2;
            return result;
        }

        public void Print_Name()
        {
            Console.WriteLine();
            Console.WriteLine("Площадь треугольника: " + GetTriangleArea());
            Console.WriteLine("Является ли треугольник прямогульным: " + IsRectangular());
        }
    }
}
