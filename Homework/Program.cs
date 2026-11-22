using Homework;
using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            HMath calc = new HMath();

            Console.WriteLine("Сумма: " + calc.Sum(numbers));
            Console.WriteLine("Минимум: " + calc.Min(numbers));
            Console.WriteLine("Максимум: " + calc.Max(numbers));
            Console.WriteLine("Среднее: " + calc.Average(numbers));
            Console.WriteLine("Число 4 — это: " + calc.CheckEvenOdd(4));

            // Теперь программа ждет ввод вашего числа с клавиатуры:
            Console.Write("Введите число от 1 до 9: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Блинд нума: " + calc.BlindNum(userNumber));
        }
    }
}
