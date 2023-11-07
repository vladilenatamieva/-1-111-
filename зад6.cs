namespace зад6
{
    internal class зад6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Ввод числа n
            int l = int.Parse(Console.ReadLine()); // Ввод числа l

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            for (char c = (char)(Math.Max(i, j) + 1); c <= 'z'; c++)
                            {
                                Console.WriteLine($"{i}{j}{(char)('a' + k)}{(char)('a' + m)}{c}");
                            }
                        }
                    }
                }
            }
        }
    }
}