using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько сторон желаете ввести?(от 0 до 3):");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Triangle1 triangle1 = new Triangle1();
                    triangle1.Print();

                    RightTriangle rightTriangle1 = new RightTriangle();
                    rightTriangle1.Print_Name();

                    Triangle1 triangle_1 = (Triangle1)triangle1.Clone1();
                    RightTriangle rightTriangle_1 = (RightTriangle)rightTriangle1.Clone1();
                    triangle_1.Print();
                    rightTriangle_1.Print_Name();
                }
                if (choice == 1)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Triangle1 triangle2 = new Triangle1(a);
                    triangle2.Print();

                    Console.WriteLine();
                    Console.WriteLine("Унаследованный класс:");
                    Console.Write("Сторона a = ");
                    int A = int.Parse(Console.ReadLine());
                    RightTriangle rightTriangle2 = new RightTriangle(A);
                    rightTriangle2.Print_Name();

                    Triangle1 triangle_2 = (Triangle1)triangle2.Clone2();
                    RightTriangle rightTriangle_2 = (RightTriangle)rightTriangle2.Clone2();
                    triangle_2.Print();
                    rightTriangle_2.Print_Name();
                }
                if (choice == 2)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int b = int.Parse(Console.ReadLine());
                    Triangle1 triangle3 = new Triangle1(a, b);
                    triangle3.Print();

                    Console.WriteLine();
                    Console.WriteLine("Унаследованный класс:");
                    Console.Write("Сторона a = ");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int B = int.Parse(Console.ReadLine());
                    RightTriangle rightTriangle3 = new RightTriangle(A, B);
                    rightTriangle3.Print_Name();

                    Triangle1 triangle_3 = (Triangle1)triangle3.Clone3();
                    RightTriangle rightTriangle_3 = (RightTriangle)rightTriangle3.Clone3();
                    triangle_3.Print();
                    rightTriangle_3.Print_Name();
                }
                if (choice == 3)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Сторона c = ");
                    int c = int.Parse(Console.ReadLine());
                    Triangle1 triangle4 = new Triangle1(a, b, c);
                    triangle4.Print();

                    Console.WriteLine();
                    Console.WriteLine("Унаследованный класс:");
                    Console.Write("Сторона a = ");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int B = int.Parse(Console.ReadLine());
                    Console.Write("Сторона c = ");
                    int C = int.Parse(Console.ReadLine());
                    RightTriangle rightTriangle4 = new RightTriangle(A, B, C);
                    rightTriangle4.Print_Name();

                    Triangle1 triangle_4 = (Triangle1)triangle4.Clone4();
                    RightTriangle rightTriangle_4 = (RightTriangle)rightTriangle4.Clone4();
                    triangle_4.Print();
                    rightTriangle_4.Print_Name();
                }
                else if (choice > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не ту цифру,попробуйте ещё раз:");
                    Console.WriteLine("Сколько сторон желаете ввести?(от 0 до 3):");

                    int choice2 = int.Parse(Console.ReadLine());
                    if (choice2 == 0)
                    {
                        Triangle1 triangle1 = new Triangle1();
                        triangle1.Print();

                        RightTriangle rightTriangle1 = new RightTriangle();
                        rightTriangle1.Print_Name();

                        Triangle1 triangle_1 = (Triangle1)triangle1.Clone1();
                        RightTriangle rightTriangle_1 = (RightTriangle)rightTriangle1.Clone1();
                        triangle_1.Print();
                        rightTriangle_1.Print_Name();
                    }
                    if (choice2 == 1)
                    {
                        Console.Write("Сторона a = ");
                        int a = int.Parse(Console.ReadLine());
                        Triangle1 triangle2 = new Triangle1(a);
                        triangle2.Print();

                        Console.WriteLine();
                        Console.WriteLine("Унаследованный класс:");
                        Console.Write("Сторона a = ");
                        int A = int.Parse(Console.ReadLine());
                        RightTriangle rightTriangle2 = new RightTriangle(A);
                        rightTriangle2.Print_Name();

                        Triangle1 triangle_2 = (Triangle1)triangle2.Clone2();
                        RightTriangle rightTriangle_2 = (RightTriangle)rightTriangle2.Clone2();
                        triangle_2.Print();
                        rightTriangle_2.Print_Name();
                    }
                    if (choice2 == 2)
                    {
                        Console.Write("Сторона a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Сторона b = ");
                        int b = int.Parse(Console.ReadLine());
                        Triangle1 triangle3 = new Triangle1(a, b);
                        triangle3.Print();

                        Console.WriteLine();
                        Console.WriteLine("Унаследованный класс:");
                        Console.Write("Сторона a = ");
                        int A = int.Parse(Console.ReadLine());
                        Console.Write("Сторона b = ");
                        int B = int.Parse(Console.ReadLine());
                        RightTriangle rightTriangle3 = new RightTriangle(A, B);
                        rightTriangle3.Print_Name();

                        Triangle1 triangle_3 = (Triangle1)triangle3.Clone3();
                        RightTriangle rightTriangle_3 = (RightTriangle)rightTriangle3.Clone3();
                        triangle_3.Print();
                        rightTriangle_3.Print_Name();
                    }
                    if (choice2 == 3)
                    {
                        Console.Write("Сторона a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Сторона b = ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Сторона c = ");
                        int c = int.Parse(Console.ReadLine());
                        Triangle1 triangle4 = new Triangle1(a, b, c);
                        triangle4.Print();

                        Console.WriteLine();
                        Console.WriteLine("Унаследованный класс:");
                        Console.Write("Сторона a = ");
                        int A = int.Parse(Console.ReadLine());
                        Console.Write("Сторона b = ");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("Сторона c = ");
                        int C = int.Parse(Console.ReadLine());
                        RightTriangle rightTriangle4 = new RightTriangle(A, B, C);
                        rightTriangle4.Print_Name();

                        Triangle1 triangle_4 = (Triangle1)triangle4.Clone4();
                        RightTriangle rightTriangle_4 = (RightTriangle)rightTriangle4.Clone4();
                        triangle_4.Print();
                        rightTriangle_4.Print_Name();
                    }
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Вы ввели не ту цифру,попробуйте ещё раз:");
                Console.WriteLine("Сколько сторон желаете ввести?(от 0 до 3):");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Triangle1 triangle1 = new Triangle1();
                    triangle1.Print();

                    RightTriangle rightTriangle1 = new RightTriangle();
                    rightTriangle1.Print();

                    Triangle1 triangle_1 = (Triangle1)triangle1.Clone1();
                    RightTriangle rightTriangle_1 = (RightTriangle)rightTriangle1.Clone1();
                    triangle_1.Print();
                    rightTriangle_1.Print_Name();
                }
                if (choice == 1)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Triangle1 triangle2 = new Triangle1(a);
                    triangle2.Print();

                    Console.WriteLine();
                    Console.WriteLine("Унаследованный класс:");
                    Console.Write("Сторона a = ");
                    int A = int.Parse(Console.ReadLine());
                    RightTriangle rightTriangle2 = new RightTriangle(A);
                    rightTriangle2.Print();

                    Triangle1 triangle_2 = (Triangle1)triangle2.Clone2();
                    RightTriangle rightTriangle_2 = (RightTriangle)rightTriangle2.Clone2();
                    triangle_2.Print();
                    rightTriangle_2.Print_Name();
                }
                if (choice == 2)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int b = int.Parse(Console.ReadLine());
                    Triangle1 triangle3 = new Triangle1(a, b);
                    triangle3.Print();

                    Console.WriteLine();
                    Console.WriteLine("Унаследованный класс:");
                    Console.Write("Сторона a = ");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int B = int.Parse(Console.ReadLine());
                    RightTriangle rightTriangle3 = new RightTriangle(A, B);
                    rightTriangle3.Print();

                    Triangle1 triangle_3 = (Triangle1)triangle3.Clone3();
                    RightTriangle rightTriangle_3 = (RightTriangle)rightTriangle3.Clone3();
                    triangle_3.Print();
                    rightTriangle_3.Print_Name();
                }
                if (choice == 3)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Сторона c = ");
                    int c = int.Parse(Console.ReadLine());
                    Triangle1 triangle4 = new Triangle1(a, b, c);
                    triangle4.Print();

                    Console.WriteLine();
                    Console.WriteLine("Унаследованный класс:");
                    Console.Write("Сторона a = ");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int B = int.Parse(Console.ReadLine());
                    Console.Write("Сторона c = ");
                    int C = int.Parse(Console.ReadLine());
                    RightTriangle rightTriangle4 = new RightTriangle(A, B, C);
                    rightTriangle4.Print();

                    Triangle1 triangle_4 = (Triangle1)triangle4.Clone4();
                    RightTriangle rightTriangle_4 = (RightTriangle)rightTriangle4.Clone4();
                    triangle_4.Print();
                    rightTriangle_4.Print_Name();
                }
            }
        }
    }
}