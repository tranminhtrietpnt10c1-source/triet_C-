using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== BAI TAP BUOI 3 =====");
        Console.WriteLine("1. Tinh to hop C(n, k)");
        Console.WriteLine("2. Liet ke so hoan hao");
        Console.WriteLine("3. Rut gon phan so");
        Console.WriteLine("4. Dem chu so");
        Console.Write("Moi ban chon bai can chay: ");

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