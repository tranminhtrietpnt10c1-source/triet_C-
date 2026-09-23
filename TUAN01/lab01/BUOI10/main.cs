using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== BAI TAP BUOI 10 =====");
        Console.WriteLine("1. Trung binh cong cuc tri");
        Console.WriteLine("2. Ke nhau trai dau");
        Console.WriteLine("3. Day dan dau");
        Console.WriteLine("4. Tim doan");
        Console.Write("Moi ban chon bai: ");

        int chon = int.Parse(Console.ReadLine());

        switch (chon)
        {
            case 1:
                Bai1.Run();
                break;
            case 2:
                Bai2.Run();
                break;
            case 3:
                Bai3.Run();
                break;
            case 4:
                Bai4.Run();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }
    }
}