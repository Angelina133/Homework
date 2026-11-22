using System;

namespace Homework
{
    public abstract class Math
    {
        public double Sum(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Max(int[] numbers)
        {
            double max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }

        public double Min(int[] numbers)
        {
            double min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }
    }
}
