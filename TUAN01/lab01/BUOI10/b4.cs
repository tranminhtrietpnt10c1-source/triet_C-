using System;

class Bai4
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

        Console.Write("Moi ban nhap so k: ");
        double k = double.Parse(Console.ReadLine());

        int batDau = -1;
        int ketThuc = -1;
        int doDaiMax = 0;

        for (int i = 0; i < n; i++)
        {
            double tong = 0;

            for (int j = i; j < n; j++)
            {
                tong += a[j];

                if (Math.Abs(tong - k) < 0.0001)
                {
                    int doDai = j - i + 1;

                    if (doDai > doDaiMax)
                    {
                        doDaiMax = doDai;
                        batDau = i;
                        ketThuc = j;
                    }
                }
            }
        }

        if (batDau == -1)
        {
            Console.WriteLine("Khong tim thay doan co tong bang k.");
        }
        else
        {
            Console.Write($"Doan [{batDau}, {ketThuc}] dai nhat co tong bang {k}: ");

            for (int i = batDau; i <= ketThuc; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine();
        }
    }
}