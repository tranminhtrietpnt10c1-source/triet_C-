using System;

class Bai3
{
    public static void Run()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine());

        double[] a = new double[n];

        Console.Write($"Day so co {n} phan tu: ");
        string[] s = Console.ReadLine().Split();

        for (int i = 0; i < n; i++)
            a[i] = double.Parse(s[i]);

        bool danDau = true;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] * a[i + 1] >= 0)
            {
                danDau = false;
                break;
            }
        }

        if (danDau)
            Console.WriteLine("Day so tren la day dan dau.");
        else
            Console.WriteLine("Day so tren khong phai la day dan dau.");
    }
}