using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.WriteLine("Chu thuong:");
        Console.WriteLine(s.ToLower());

        Console.WriteLine("Chu hoa:");
        Console.WriteLine(s.ToUpper());

        string[] words = s.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("So tu: " + words.Length);
    }
}