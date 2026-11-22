using Homework;
using System;

namespace Lesson1
{
    public class HMath : MMath
    {
        public string BlindNum(int num)
        {
            Random rnd = new Random();
            int sec = rnd.Next(1, 10);

            if (num == sec)
                return "Угадали! Скрытое число: " + sec;
            else
                return "Не угадали. Скрытое число: " + sec;
        }
    }
}
