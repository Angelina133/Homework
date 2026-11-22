namespace Homework
{
    public class MMath : Math
    {
        // Среднее значение из ДЗ
        public double Average(int[] numbers)
        {
            return Sum(numbers) / numbers.Length;
        }

        // Проверка на четное / нечетное из ДЗ
        public string CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
                return "Четное";
            else
                return "Нечетное";
        }
    }
}
