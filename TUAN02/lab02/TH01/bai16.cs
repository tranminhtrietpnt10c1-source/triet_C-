using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguoi: ");
        int n = int.Parse(Console.ReadLine());

        string[] ds = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ho ten {i + 1}: ");
            ds[i] = Console.ReadLine();
        }

        Array.Sort(ds);

        Console.WriteLine("\nDanh sach sau khi sap xep:");

        foreach (string item in ds)
        {
            Console.WriteLine(item);
        }
    }
}