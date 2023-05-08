using System;
using System.Threading;

namespace pz_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 задание
            Console.WriteLine("Задание 2:");
            Console.WriteLine();
            Temperature temperature = new Temperature();

            // Подписываемся на событие TemperatureChanged
            temperature.TemperatureChanged += (sender, e) =>
            {
                if (e.Temperature == -25)
                {
                    Console.WriteLine("Temperature is -25");
                }
                else if (e.Temperature == 0)
                {
                    Console.WriteLine("Temperature is 0");
                }
                else if (e.Temperature == 25)
                {
                    Console.WriteLine("Temperature is 25");
                }
                else if (e.Temperature == 35)
                {
                    Console.WriteLine("Temperature is 35");
                }
            };
            temperature.Start();

            Console.WriteLine();

            //5 задание
            Console.WriteLine("Задание 5:");
            Console.WriteLine();

            Visitor[] visitors = new Visitor[50];
            Controller controller = new Controller();

            for (int i = 0; i < 50; i++)
            {
                visitors[i] = new Visitor();
                controller.AddVisitor(visitors[i]);
            }
            Console.ReadKey();
        }
    }
}