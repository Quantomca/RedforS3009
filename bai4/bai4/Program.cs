using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Nhập vao cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxValue = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
        }
        Console.WriteLine($"Gia tri lon nhat trong mang la: {maxValue}");
    }
}
