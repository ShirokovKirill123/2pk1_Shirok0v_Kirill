﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
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
                }
                if (choice == 1)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Triangle1 triangle2 = new Triangle1(a);
                    triangle2.Print();
                }
                if (choice == 2)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int b = int.Parse(Console.ReadLine());
                    Triangle1 triangle3 = new Triangle1(a, b);
                    triangle3.Print();
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
                    }
                    if (choice2 == 1)
                    {
                        Console.Write("Сторона a = ");
                        int a = int.Parse(Console.ReadLine());
                        Triangle1 triangle2 = new Triangle1(a);
                        triangle2.Print();
                    }
                    if (choice2 == 2)
                    {
                        Console.Write("Сторона a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Сторона b = ");
                        int b = int.Parse(Console.ReadLine());
                        Triangle1 triangle3 = new Triangle1(a, b);
                        triangle3.Print();
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
                }
                if (choice == 1)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Triangle1 triangle2 = new Triangle1(a);
                    triangle2.Print();
                }
                if (choice == 2)
                {
                    Console.Write("Сторона a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Сторона b = ");
                    int b = int.Parse(Console.ReadLine());
                    Triangle1 triangle3 = new Triangle1(a, b);
                    triangle3.Print();
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
                }
            }
        }
    }
}