using System;

namespace Задание_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет сенсей!");
            Console.Write("Сумма чисел от 2**2 до 2**10(включительно) : ");
            Console.WriteLine(sum(2,11));

        }
        static int sum(int delimoe,int delitel,int peremennaya=0)
        {

            if (delitel == 1)
            {
                return peremennaya - 2; //от z отнимаем 2 потому что при первом цикле плюсюется первое знаение x (x=2)
                
            }
            else
            {
                return  sum(2* delimoe, delitel - 1, peremennaya += delimoe);
            }
        }

    }
}
