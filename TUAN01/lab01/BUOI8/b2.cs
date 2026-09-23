using System;

class Bai2
{
    static bool LaSoHoanHao(int n)
    {
        int tong = 0;

        for (int i = 1; i <= n / 2; i++)
            if (n % i == 0)
                tong += i;

        return tong == n;
    }

    public static void Run()
    {
        Console.Write("Moi ban nhap so n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Cac so hoan hao trong doan [1, {n}]: ");

        for (int i = n; i >= 1; i--)
            if (LaSoHoanHao(i))
                Console.Write(i + " ");

        Console.WriteLine();
    }
}
`