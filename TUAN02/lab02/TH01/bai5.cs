using System;

class Program
{
    static void Main()
    {
        double x = 0, y = 0;
        int chon;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");

            Console.Write("Chon chuc nang: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Nhap y: ");
                    y = double.Parse(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine($"x^y = {Math.Pow(x, y)}");
                    break;

                case 3:
                    Console.WriteLine($"Can bac hai x = {Math.Sqrt(x)}");
                    Console.WriteLine($"Can bac hai y = {Math.Sqrt(y)}");
                    break;

                case 4:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }

        } while (chon != 4);
    }
}