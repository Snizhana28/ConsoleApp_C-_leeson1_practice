namespace ConsoleApp_C__leeson1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 7;
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}