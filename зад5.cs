namespace зад5
{
    internal class зад5
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите день a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год c:");
            c = int.Parse(Console.ReadLine());
            if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
            {
                if (a <= 31)
                {
                    Console.WriteLine("The date is correct");
                }
            }
            else { Console.WriteLine("the date is incorrect"); }
            if (b == 11 || b == 4 || b == 6 || b == 9 || b == 10)
            {
                if (a <= 30)
                {
                    if (b == 2)
                    {
                        if (a <= 28)
                        {
                            Console.WriteLine("the date is correct");
                        }
                    }
                }
            }
        }
    }
}



