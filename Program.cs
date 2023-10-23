using System;

namespace Inlämningsuppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många X per grupp? ");
            int antalX = int.Parse(Console.ReadLine());

            Console.Write("Hur många O per grupp? ");
            int antalO = int.Parse(Console.ReadLine());

            Console.Write("Hur många O-mönster per rad? ");
            int antalOMonsterPerRad = int.Parse(Console.ReadLine());

            Console.Write("Hur många rader? ");
            int antalRader = int.Parse(Console.ReadLine());

            for (int i = 0; i < antalRader; i++)
            {
                for (int j = 0; j < antalOMonsterPerRad; j++)
                {
                    for (int k = 0; k < antalX; k++)
                    {
                        Console.Write("X");
                    }
                    for (int k = 0; k < antalO; k++)
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}