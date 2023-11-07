namespace зад4
{
    internal class зад4
    {
        static void Main(string[] args)
        {
            int[] arr = { 65, 30, 2, 6, 17, 83, 99, 8, 12, 91 };

            Array.Sort(arr);

            Console.WriteLine("Отсортированный массив:");

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}