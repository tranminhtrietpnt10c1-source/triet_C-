using System;

class SinhVien
{
    public string MaSV;
    public string HoTen;
    public string DiaChi;
    public int NamHoc;

    public void Nhap()
    {
        Console.Write("Ma SV: ");
        MaSV = Console.ReadLine();

        Console.Write("Ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Dia chi: ");
        DiaChi = Console.ReadLine();

        Console.Write("Nam hoc: ");
        NamHoc = int.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("\nTHONG TIN SINH VIEN");
        Console.WriteLine($"Ma SV: {MaSV}");
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"Dia chi: {DiaChi}");
        Console.WriteLine($"Nam hoc: {NamHoc}");
    }
}

class Program
{
    static void Main()
    {
        SinhVien sv = new SinhVien();

        sv.Nhap();
        sv.Xuat();
    }
}