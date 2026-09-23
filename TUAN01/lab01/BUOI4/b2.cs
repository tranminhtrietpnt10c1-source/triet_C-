using System;

class Bai2
{
    public static void Run()
    {
        Console.Write("Moi ban nhap chi so tieu thu nuoc thang truoc (m^3): ");
        double chiSoCu = double.Parse(Console.ReadLine());

        Console.Write("Moi ban nhap chi so tieu thu nuoc trong thang (m^3): ");
        double chiSoMoi = double.Parse(Console.ReadLine());

        Console.Write("Moi ban nhap so nguoi trong ho: ");
        int soNguoi = int.Parse(Console.ReadLine());

        double tieuThu = chiSoMoi - chiSoCu;

        double dm1 = 4 * soNguoi;
        double dm2 = 2 * soNguoi;

        double tienNuoc;

        if (tieuThu <= dm1)
        {
            tienNuoc = tieuThu * 4400;
        }
        else if (tieuThu <= dm1 + dm2)
        {
            tienNuoc = dm1 * 4400
                     + (tieuThu - dm1) * 8300;
        }
        else
        {
            tienNuoc = dm1 * 4400
                     + dm2 * 8300
                     + (tieuThu - dm1 - dm2) * 10500;
        }

        double tongTien = tienNuoc * 1.15;

        Console.WriteLine($"So tien phai tra cho {tieuThu} m^3 tieu thu trong thang la {tongTien:N0} Đ.");
    }
}
