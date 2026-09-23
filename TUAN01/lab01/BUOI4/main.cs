using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== BAI TAP BUOI 2 =====");
        Console.WriteLine("1. Diem trung binh");
        Console.WriteLine("2. Tien nuoc");
        Console.WriteLine("3. Ngay sau");
        Console.WriteLine("4. Phan loai tam giac");
        Console.Write("Moi ban chon bai: ");

        int chon = int.Parse(Console.ReadLine());

        Console.WriteLine();

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