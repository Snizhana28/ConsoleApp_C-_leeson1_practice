namespace ConsoleApp_C__leeson1_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить з клавіатури межі числового діапазону. Потрібно показати усі числа Фібоначчі з цього 
            діапазону. Числа Фібоначчі — елементи числової послідовності, у якій перші два числа дорівнюють 0 і 1, а кожне 
            наступне число дорівнює сумі двох попередніх чисел. 
            Наприклад, якщо вказано діапазон 0–20, результат буде: 
            0, 1, 1, 2, 3, 5, 8, 13.*/
            int a = 0;
            int b = 1;
            int c = 0;
            int d = 0;
            Console.WriteLine("Введіть перше число діапазону");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число діапазону");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа Фібоначчі з діапазону від {0} до {1}:", first, second);
            while (c < second)
            {
                if (c >= first)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                }
                c++;

            }

        }
    }
}