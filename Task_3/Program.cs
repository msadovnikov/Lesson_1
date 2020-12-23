/*
а)
    Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2)
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б)
    *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

Садовников М.
*/


using System;

namespace Task_3
{
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1 = 1.5;
            double y1 = 1.5;
            double x2 = 5.0;
            double y2 = 5.0;

            double distance = Distance(x1, y1, x2, y2);

            Console.Write("Расстояние между точками с координатами ({0}; {1}) и ({2}; {3}): " , x1, y1, x2, y2);
            Console.Write("{0:F2}", distance);

            Console.ReadKey();
        }
    }
}
