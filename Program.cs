namespace ConsoleApp_C__leeson1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть шестизначне число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int number1 = number / 100000;
            int number2 = number / 10000 % 10;
            int number3 = number / 1000 % 10;
            int number4 = number / 100 % 10;
            int number5 = number / 10 % 10;
            int number6 = number % 10;
            Console.WriteLine("Ваше число: " + number);
            Console.WriteLine("Перевернуте число: " + number6 + number5 + number4 + number3 + number2 + number1);
            Console.ReadKey();
        }
    }
}