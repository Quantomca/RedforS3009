using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao mot so thuc: ");
        double number = double.Parse(Console.ReadLine());
        int intNumber = (int)number;
        long longNumber = (long)number;
        Console.WriteLine($"So ban da nhap la {number}, duoi dang so nguyen int la {intNumber} va duoi dang so nguyen long la {longNumber}");
    }
}
