using System;

class Bai4
{
    static int DemSoLanXuatHien(long n, int chuSo)
    {
        int dem = 0;

        while (n > 0)
        {
            if (n % 10 == chuSo)
                dem++;

            n /= 10;
        }

        return dem;
    }

    public static void Run()
    {
        Console.Write("Moi ban nhap so nguyen n: ");
        long n = long.Parse(Console.ReadLine());

        for (int i = 0; i <= 9; i++)
        {
            int dem = DemSoLanXuatHien(n, i);

            if (dem > 0)
                Console.WriteLine($"Chu so {i} xuat hien {dem} lan.");
        }
    }
}