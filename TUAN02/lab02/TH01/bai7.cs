using System;

class Program
{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

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

        if (LaSoNguyenTo(n))
            Console.WriteLine("La so nguyen to");
        else
            Console.WriteLine("Khong la so nguyen to");
    }
}