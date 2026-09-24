using System;

class Program
{
    static bool DoiXung(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        if (DoiXung(s))
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");
    }
}