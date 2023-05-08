﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    public class Triangle1 : ICloneable
    {
        public int a = 2;
        public int b = 2;
        public int c = 1;
        static public bool Existance { get; set; }//проверка на существование
        static public int X { get; set; }//количество  равносторонних трейгольников        

        public Triangle1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle1() { }

        public Triangle1(int a)
        {
            this.a = a;
        }

        public Triangle1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual double GetTriangleArea()
        {
            double j = (double)a;
            double k = (double)b;
            double l = (double)c;

            double S = 0;
            double d = (j + k + l) / 2;
            S = Math.Sqrt(d * (d - j) * (d - k) * (d - l));
            return S;
        }


        public bool Ex()
        {
            if ((a + b > c) && (c + a > b) && (b + c > a))
            {
                return Existance = true;
            }
            else
            {
                return Existance = false;
            }
            Exist();
        }

        public static bool Exist()
        {
            return Existance;
        }

        public bool IsRightTriangle()
        {
            bool check;
            if ((a == b) && (a == c) && (c == b))
            {
                check = true;
                X = 1;
            }
            else
            {
                check = false;
                X = 0;
            }
            return check;
        }

        public int IsRightTriangle2()
        {

            if ((a == b) && (a == c) && (c == b))
            {
                return X = 1;
            }
            else
            {
                return X = 0;
            }
            Right();
        }

        public static int Right()
        {
            return X;
        }

        public virtual bool IsRectangular()
        {

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

        public Object Clone1()
        {
            Triangle1 o = new Triangle1();
            return o;
        }

        public Object Clone2()
        {
            int a = 4;
            Triangle1 p = new Triangle1(a);
            return p;
        }

        public Object Clone3()
        {
            int a = 4;
            int b = 5;
            Triangle1 r = new Triangle1(a, b);
            return r;
        }

        public Object Clone4()
        {
            int a = 4;
            int b = 5;
            int c = 3;
            Triangle1 s = new Triangle1(a, b, c);
            return s;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Существует ли такой треугольник: " + Ex());
            Console.WriteLine("Количество равносторонних треугольников " + IsRightTriangle2());
            Console.WriteLine("Площадь треугольника: " + GetTriangleArea());
            Console.WriteLine("Является ли треугольник правильным: " + IsRightTriangle());
            Console.WriteLine("Является ли треугольник прямогульным: " + IsRectangular());
        }
    }
}