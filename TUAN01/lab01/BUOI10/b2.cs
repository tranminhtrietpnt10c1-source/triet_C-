using System;

class Bai2
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

        int dem = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] * a[i + 1] < 0)
                dem++;
        }

        Console.WriteLine($"So luong cac phan tu ke nhau ma trai dau: {dem}.");
    }
}