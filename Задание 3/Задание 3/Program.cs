using System;

namespace Zadaniye_3
{
    class Program
    {
        public static int Power(int number, int power, int one = 1)
        {


            if (power == 1)
            {
                return number * one;
            }
            else if (power == 0)
            {
                return 1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else
            {

                return Power(number, power -= 1, one *= number);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет сенсей!");
            Console.WriteLine("Возведение в степень любого натурального числа.");
            Console.Write("Введите натуральное число = ");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите степень числа = "); 
            int y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Результат = " + Power(x, y));

        }
    }
}
