using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    public class Triangle
    {
        int a = 2;
        int b = 2;
        int c = 1;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle() { }
        public Triangle(int a)
        {
            this.a = a;
        }

        public Triangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetTriangleArea()
        {
            this.a = a;
            this.b = b;
            this.c = c;

            double j = (double)a;
            double k = (double)b;
            double l = (double)c;

            double S = 0;
            double d = (j + k + l) / 2;
            S = Math.Sqrt(d * (d - j) * (d - k) * (d - l));
            return S;
        }

        public bool Existence()
        {
            bool existence;
            if ((a + b > c) && (c + a > b) && (b + c > a))
            {
                existence = true;
            }
            else
            {
                existence = false;
            }
            return existence;
        }
        public bool IsRightTriangle()
        {
            this.a = a;
            this.b = b;
            this.c = c;
            bool check;
            if ((a == b) && (a == c) && (c == b))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        public bool IsRectangular()
        {
            this.a = a;
            this.b = b;
            this.c = c;
            bool chek2 = false;

            if ((a > b) && (a > c))
            {
                if ((Math.Pow(a, 2)) == (Math.Pow(b, 2)) + (Math.Pow(c, 2)))
                {
                    chek2 = true;
                }
                else
                {
                    chek2 = false;
                }
                return chek2;
            }
            if ((b > a) && (b > c))
            {
                if ((Math.Pow(b, 2)) == (Math.Pow(a, 2)) + (Math.Pow(c, 2)))
                {
                    chek2 = true;
                }
                else
                {
                    chek2 = false;
                }
                return chek2;
            }
            if ((c > b) && (c > a))
            {
                if ((Math.Pow(c, 2)) == (Math.Pow(b, 2)) + (Math.Pow(a, 2)))
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

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Существует ли такой треугольник: " + Existence());
            Console.WriteLine("Площадь треугольника: " + GetTriangleArea());
            Console.WriteLine("Является ли треугольник правильным: " + IsRightTriangle());
            Console.WriteLine("Является ли треугольник прямогульным: " + IsRectangular());
        }
    }
}
