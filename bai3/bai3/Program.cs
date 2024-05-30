using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao mot ki tu: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int asciiCode = (int)character;
        Console.WriteLine($"Ky tu ban da nhap la '{character}', ma ASCII la {asciiCode}");
    }
}
