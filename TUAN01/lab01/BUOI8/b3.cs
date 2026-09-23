using System;

class Bai3
{
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return Math.Abs(a);
    }

    public static void Run()
    {
        Console.Write("Moi ban nhap tu so: ");
        int tu = int.Parse(Console.ReadLine());

        Console.Write("Moi ban nhap mau so: ");
        int mau = int.Parse(Console.ReadLine());

        int tuGoc = tu;
        int mauGoc = mau;

        int ucln = UCLN(tu, mau);

        tu /= ucln;
        mau /= ucln;

        Console.WriteLine($"Phan so {tuGoc}/{mauGoc} duoc rut gon thanh {tu}/{mau}.");
    }
}
