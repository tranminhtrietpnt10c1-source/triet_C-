using System;

class Bai1
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

        double tong = 0;

        for (int i = 1; i < n - 1; i++)
        {
            bool cucDai = a[i] > a[i - 1] && a[i] > a[i + 1];
            bool cucTieu = a[i] < a[i - 1] && a[i] < a[i + 1];

            if (cucDai || cucTieu)
                tong += a[i];
        }

        Console.WriteLine($"Tong cac phan tu cuc tri co trong day so: {tong}.");
    }
}