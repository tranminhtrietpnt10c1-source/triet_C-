using System;

class Bai3
{
    public static void Run()
    {
        Console.Write("Moi ban nhap ngay, thang, nam: ");

        string[] s = Console.ReadLine().Split();

        int ngay = int.Parse(s[0]);
        int thang = int.Parse(s[1]);
        int nam = int.Parse(s[2]);

        DateTime d = new DateTime(nam, thang, ngay);
        DateTime ngaySau = d.AddDays(1);

        Console.WriteLine(
            $"Ngay sau ngay {ngay}/{thang}/{nam} la ngay {ngaySau.Day}/{ngaySau.Month}/{ngaySau.Year}.");
    }
}