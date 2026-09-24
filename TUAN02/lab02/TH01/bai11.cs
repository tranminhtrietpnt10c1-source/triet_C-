using System;

class Program
{
    static string DaoChuoi(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.WriteLine("Chuoi dao: " + DaoChuoi(s));
    }
}