using System;

class Bai1
{
    static long GiaiThua(int n)
    {
        long gt = 1;
        for (int i = 2; i <= n; i++)
            gt *= i;
        return gt;
    }

    public static void Run()
    {
        Console.Write("Moi ban nhap k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Moi ban nhap n: ");
        int n = int.Parse(Console.ReadLine());

        long c = GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k));

        Console.WriteLine($"C({k}, {n}) = {c}.");
    }
}