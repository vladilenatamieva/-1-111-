namespace зад10
{
    internal class зад10
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите индекс N:");
            int index = Convert.ToInt32(Console.ReadLine());

            FindNthDigit(number, index);
        }

        static void FindNthDigit(int number, int index)
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                if (count == index)
                {
                    Console.WriteLine($"N-я цифра числа: {number % 10}");
                    return;
                }
                number /= 10;
            }
            Console.WriteLine("Искомая цифра не найдена.");
        }
    }
}
