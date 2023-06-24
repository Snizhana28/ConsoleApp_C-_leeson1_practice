namespace ConsoleApp_C__leeson1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            int max = 0;
            int min = 1;
            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
                mult *= arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);
            Console.WriteLine("Multiplication of numbers: " + mult);
            Console.ReadKey();
        }
    }
}