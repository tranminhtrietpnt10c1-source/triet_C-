using System;
using System.Collections.Generic;

class Program
{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nMang:");

        foreach (int x in a)
            Console.Write(x + " ");

        int max = a[0];
        int min = a[0];

        foreach (int x in a)
        {
            if (x > max) max = x;
            if (x < min) min = x;
        }

        Console.WriteLine($"\nMax = {max}");
        Console.WriteLine($"Min = {min}");

        List<int> nt = new List<int>();

        foreach (int x in a)
        {
            if (LaSoNguyenTo(x))
                nt.Add(x);
        }

        Console.WriteLine("Mang so nguyen to:");

        foreach (int x in nt)
            Console.Write(x + " ");
    }
}