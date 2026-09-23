using System;

class Bai1
{
    public static void Run()
    {
        Console.Write("Moi ban nhap diem toan, ly, hoa: ");

        string[] s = Console.ReadLine().Split();

        double toan = double.Parse(s[0]);
        double ly = double.Parse(s[1]);
        double hoa = double.Parse(s[2]);

        double dtb = (toan * 2 + ly * 3 + hoa) / 6;

        string xepLoai;

        if (dtb >= 8)
            xepLoai = "Gioi";
        else if (dtb >= 6.5)
            xepLoai = "Kha";
        else if (dtb >= 5)
            xepLoai = "Trung binh";
        else
            xepLoai = "Yeu";

        Console.WriteLine($"Ban co diem trung binh {dtb:F2} duoc xep loai {xepLoai}.");
    }
}