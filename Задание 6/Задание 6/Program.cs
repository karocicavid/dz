using System;

class Program
{

    static int Power(int cow=0,int bull=0)
    {

        int[] have = { 2, 3, 5, 6 };
        int[] input = new int[4];


        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine($"\nВведите {i + 1}-номер массива:");
            input[i] = int.Parse(Console.ReadLine());
        }

        for (int x = 0; x < have.Length; x++)
        {
            for (int y = 0; y < input.Length; y++)
            {
                if (have[x] == input[y] & x == y)
                {
                    cow += 1;
                }

                else if (have[x] == input[y] & x != y)
                {
                    bull += 1;
                }
            }
        }
        Console.Write($"{cow} коровы,");
        Console.Write($" {bull} быка");

        if (cow == 4)
        {
            return 0 ;
        }
        else
        {
            return Power(cow, bull);
        }
        

    }
    static void Main(string[] args)
    {
        Console.Write(Power());
    }
}   