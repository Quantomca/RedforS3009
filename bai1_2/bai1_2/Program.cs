using System;
using System.Text;

namespace bai1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;

            while (true)
            {
                Console.WriteLine("Chọn chức năng:");
                Console.WriteLine("1. Tính toán với 2 số nguyên 4 byte");
                Console.WriteLine("2. Tính tổng mảng số nguyên có dấu 4 byte");
                Console.WriteLine("3. Đảo ngược số nguyên không dấu 4 byte");
                Console.WriteLine("4. Thoát");

                // Nhập lựa chọn, kiểm soát ngoại lệ
                while (true)
                {
                    try
                    {
                        Console.Write("Nhập lựa chọn: ");
                        choice = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ.");
                    }
                }

                // Thực hiện chức năng tương ứng
                switch (choice)
                {
                    case 1:
                        TinhToan2SoNguyen();
                        break;
                    case 2:
                        TinhTongMangSoNguyen();
                        break;
                    case 3:
                        DaoNguocSoNguyen();
                        break;
                    case 4:
                        Console.WriteLine("Kết thúc chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void TinhToan2SoNguyen()
        {
            int a, b;

            // Nhập a và b, kiểm soát ngoại lệ
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên a (4 byte): ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số nguyên b (4 byte): ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ.");
                }
            }

            // Tính toán và in kết quả
            Console.WriteLine("Kết quả:");
            Console.WriteLine($"Tổng: {a + b}");
            Console.WriteLine($"Hiệu: {a - b}");
            Console.WriteLine($"Tích: {a * b}");
            Console.WriteLine($"Thương (số nguyên): {a / b}");
            Console.WriteLine($"Thương (số thực): {(double)a / b}");
        }

        static void TinhTongMangSoNguyen()
        {
            int[] numbers;
            int n, sum = 0;

            // Nhập kích thước mảng
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            n = int.Parse(Console.ReadLine());

            // Nhập các phần tử của mảng
            numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            // In kết quả
            Console.WriteLine($"Tổng của các số trong mảng: {sum}");
        }

        static void DaoNguocSoNguyen()
        {
            uint number;

            // Nhập số nguyên không dấu
            Console.Write("Nhập số nguyên không dấu (4 byte): ");
            number = uint.Parse(Console.ReadLine());

            // Đảo ngược các chữ số
            uint reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + (number % 10);
                number /= 10;
            }

            // In kết quả
            Console.WriteLine($"Số đảo ngược: {reversed}");
        }
    }
}