using System;

class NhanVien
{
    public string HoTen;
    public double Luong;
    public int NgayVang;

    public void Nhap()
    {
        Console.Write("Ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Luong co ban: ");
        Luong = double.Parse(Console.ReadLine());

        Console.Write("So ngay vang: ");
        NgayVang = int.Parse(Console.ReadLine());
    }

    public double TinhLuong()
    {
        return Luong - NgayVang * 100000;
    }

    public void Xuat()
    {
        Console.WriteLine($"Luong thuc nhan: {TinhLuong():N0} VNĐ");
    }
}

class Program
{
    static void Main()
    {
        NhanVien nv = new NhanVien();

        nv.Nhap();
        nv.Xuat();
    }
}