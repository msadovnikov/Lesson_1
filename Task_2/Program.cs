/*
Ввести вес и рост человека.
Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
где m — масса тела в килограммах, h — рост в метрах.

Садовников М.
*/

using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вес человека (кг.): ");
            double m = double.Parse(Console.ReadLine());

            Console.Write("Введите рост человека в (м.): ");
            double h = double.Parse(Console.ReadLine());

            double I = m / (h * h);

            Console.WriteLine();
            Console.WriteLine("Индекс массы тела: " + I);

            Console.ReadKey();
        }
    }
}
