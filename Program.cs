using System.Text;

namespace ConsoleApp_C__leeson1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть довжину лінії");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть символ заповнювач");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введіть напрямок лінії (горизонтальна - x , вертикальна - y )");
            string direction = Console.ReadLine();
            if (direction == "x")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
            }
            else if (direction == "y")
            {
               for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                Console.WriteLine("Невірно введені дані");
            }
            Console.ReadKey();
        }
    }
}