using System;

class Bai4
{
    public static void Run()
    {
        Console.Write("Moi ban nhap ba so thuc a, b, c: ");

        string[] s = Console.ReadLine().Split();

        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine($"Ba so ({a}, {b}, {c}) khong tao thanh tam giac.");
            return;
        }

        Console.WriteLine($"Ba so ({a}, {b}, {c}) tao thanh duoc tam giac.");

        bool can = (a == b || b == c || a == c);

        bool vuong =
            Math.Abs(a * a + b * b - c * c) < 0.0001 ||
            Math.Abs(a * a + c * c - b * b) < 0.0001 ||
            Math.Abs(b * b + c * c - a * a) < 0.0001;

        if (a == b && b == c)
            Console.WriteLine("Tam giac tao thanh la tam giac deu.");
        else if (vuong && can)
            Console.WriteLine("Tam giac tao thanh la tam giac vuong can.");
        else if (vuong)
            Console.WriteLine("Tam giac tao thanh la tam giac vuong.");
        else if (can)
            Console.WriteLine("Tam giac tao thanh la tam giac can.");
        else
            Console.WriteLine("Tam giac tao thanh la tam giac thuong.");
    }
}