using System;

namespace Практическая_работа_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] masort = new int[10];
            int[,] ms = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    ms[i, j] = rand.Next(10);
                    Console.Write($"{ms[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Задание 2");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    masort[j] = ms[j, i];
                }
                Array.Sort(masort);
                for (int u = 0; u < 9; u++)
                {
                    ms[u, i] = masort[u];
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(ms[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
    }
