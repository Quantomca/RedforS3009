using System;

class Program
{
    static string ReverseString(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static int CountOccurrences(string inputString, string searchString)
    {
        int count = 0;
        int index = inputString.IndexOf(searchString);
        while (index != -1)
        {
            count++;
            index = inputString.IndexOf(searchString, index + searchString.Length);
        }
        return count;
    }
    static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
    {
        return inputString.Replace(oldSubstring, newSubstring);
    }
    static string RemoveWhitespace(string inputString)
    {
        return string.Join("", inputString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
    }

    static void Main()
    {
        Console.Write("Nhap vao mot chuoi: ");
        string userInput = Console.ReadLine();
        string reversedString = ReverseString(userInput);
        Console.WriteLine($"Chuoi dao nguoc la: {reversedString}");
        Console.Write("Nhap vao chuoi tim kiem: ");
        string searchString = Console.ReadLine();
        int occurrences = CountOccurrences(userInput, searchString);
        Console.WriteLine($"So lan xuat hien cua chuoi tim kiem: {occurrences}");
        Console.Write("Nhap vao chuoi cu: ");
        string oldSubstring = Console.ReadLine();
        Console.Write("Nhap vao chuoi moi: ");
        string newSubstring = Console.ReadLine();
        string replacedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
        Console.WriteLine($"Chuoi sau khi thay the: {replacedString}");
        string stringWithoutWhitespace = RemoveWhitespace(userInput);
        Console.WriteLine($"Chuoi sau khi bo khoang trang: {stringWithoutWhitespace}");
    }
}
