using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:"); 
            int y = int.Parse(Console.ReadLine());
            Console.Write($"Сумма чисел между ними:{Sum(x, y)}");
        }
        
        static int Sum(int number1,int number2, int variable=0)
        {
            if (number1 - 1 > number2)
            {
                number1--;

             return Sum(number1, number2, variable + number1);
                
            }
            else if (number2 - 1 > number1)
            {
                number2--;

             return Sum(number1, number2, variable + number2);

            }
            else
            {
                return variable;
            }
        }
    }
}
