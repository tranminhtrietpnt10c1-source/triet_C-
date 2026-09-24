using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap m: ");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];

        Random rd = new Random();

        List<int> chan = new List<int>();
        List<int> le = new List<int>();

        Console.WriteLine("\nMa tran:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = rd.Next(10, 101);

                Console.Write(a[i, j] + "\t");

                if (a[i, j] % 2 == 0)
                    chan.Add(a[i, j]);
                else
                    le.Add(a[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nMang chan:");

        foreach (int x in chan)
            Console.Write(x + " ");

        Console.WriteLine("\nMang le:");

        foreach (int x in le)
            Console.Write(x + " ");
    }
}