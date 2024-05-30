using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao mot so nguyen: ");
        int number = int.Parse(Console.ReadLine());
        double doubleNumber = (double)number;
        Console.WriteLine($"So ban da nhap la {number} va duoi dang so thuc la {doubleNumber}");
    }
}
