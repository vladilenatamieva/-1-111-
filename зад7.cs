namespace зад7
{
    internal class зад7
    {
        static void Main(string[] args)
        {
            int N, M, S;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите M:");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите S:");
            S = Convert.ToInt32(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i != S)
                {
                    Console.WriteLine(i);
                }
                else if (i == S)
                {
                    break;
                }
            }
        }
    }
}
