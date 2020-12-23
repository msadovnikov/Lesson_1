/*
Написать программу «Анкета».
Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
В результате вся информация выводится в одну строчку:
    а) используя склеивание;
    б) используя форматированный вывод;
    в) используя вывод со знаком $.

// Если я правильно понял на втором уроке в этом задании не обязательно валидировать переменные ))

Садовников М.
*/

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите свою возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите свой рост: ");
            string growth = Console.ReadLine();

            Console.Write("Введите свой вес: ");
            string weigth = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("a) Склеивание: " + name + surname + age + growth + weigth);
            Console.WriteLine("б) Форматированный вывод: " + "{0}, {1}, {2:D3}, {3:D3}, {4:D3}", name, surname, int.Parse(age), int.Parse(growth), int.Parse(weigth));
            Console.WriteLine("в) Вывод со знаком $: " + $"{name}, {surname}, {int.Parse(age):###}, {int.Parse(growth):###}, {int.Parse(weigth):###}");

            Console.ReadKey();
        }
    }
}
