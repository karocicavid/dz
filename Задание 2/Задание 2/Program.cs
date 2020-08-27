using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Привет сенсей!");
            Console.Write("Введите делимое: ");
            int delimoe = int.Parse(Console.ReadLine());
            Console.Write("Введите делитель: ");
            int delitel = int.Parse(Console.ReadLine());
            if (delimoe < delitel)
            {
                Console.WriteLine("Делимое меньше делителя.");
                
            }
            else if(delimoe<0 && delitel < 0)
            {
                Console.WriteLine("Введите натуральные числа!");
            }
            else
            {
                Console.Write($"Наибольшей общий делитель числа равен: {Nod(delimoe, delitel)}");
            }
            
        }

        static int Nod(int delimoe, int delitel)
        {   
            int temp;
            if (delimoe % delitel == 0)
            {
                return delitel;
            }
            else 
            {
                temp = delimoe % delitel;

                return Nod(delimoe = delitel, delitel = temp);
            }
        }
    }
}
