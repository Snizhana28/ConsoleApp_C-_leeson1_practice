using System.Text;
namespace ConsoleApp_C__leeson1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть перше число діапазону");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть останнє число діапазону");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа Фібоначчі з діапазону від {0} до {1}:", first, end);
            int a = 0;
            int b = 1;
            while (a <= end)
            {
                if (a >= first)
                {
                    Console.Write(a + " ");
                }
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.ReadKey();
        }
    }
}