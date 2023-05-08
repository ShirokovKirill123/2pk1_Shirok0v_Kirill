using System;
using System.Collections.Generic;
using System.Text;

namespace pz_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о маршрутах...");//Ввод информации о маршрутах
            Console.WriteLine();
            int a = 8;
            MARSH[] TRAFIC = new MARSH[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Начальный пункт маршрута:");
                TRAFIC[i].BEGST = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Конечный пункт маршрута:");
                TRAFIC[i].TERM = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Номер маршрута:");
                TRAFIC[i].NUMER = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < a - 1; i++)//Сортировка
            {
                for (int j = i + 1; j < a; j++)
                {
                    if (TRAFIC[i].NUMER > TRAFIC[j].NUMER)
                    {
                        MARSH x = TRAFIC[i];
                        TRAFIC[i] = TRAFIC[j];
                        TRAFIC[j] = x;
                    }
                }
            }

            Console.WriteLine();//Вывод всей имеющейся информации о маршрутах в базе
            Console.WriteLine("Информация о маршрутах в базе:");
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(TRAFIC[i]);
            }

            Console.WriteLine();//Вывод интересующео нас маршрута
            Console.WriteLine("Введите номер интересующего маршрута: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < a; i++)
            {
                if (TRAFIC[i].NUMER == M)
                {
                    Console.WriteLine(TRAFIC[i]);
                    c++;
                }
            }

            if (c == 0)//Если совпадений нет
            {
                Console.WriteLine("Совпадения не найдены!");
                Console.ReadKey(true);
            }
        }
    }

    
}
