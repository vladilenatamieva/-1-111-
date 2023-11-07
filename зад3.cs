namespace зад3
{
    internal class зад3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                    if (count > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (count > n)
                {
                    break;
                }
            }
        }
    }
}