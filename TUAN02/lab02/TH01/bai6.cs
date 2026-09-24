using System;

class TienIch
{
    public static int Max(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("So lon nhat = " + TienIch.Max(a, b, c));
    }
}