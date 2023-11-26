using System;

namespace UocChungLonNhatCua2So
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so thu nhat :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap so thu hai:");
            int b = int.Parse(Console.ReadLine());

            int ucln = TimUCLN(a, b);

            Console.WriteLine("uoc chung lon nhat cua 2 so la : " + ucln);
            Console.ReadLine();
        }
        //. Thuật toán Euclid dựa trên việc lặp lại việc chia lấy dư (phép chia Euclid)
        //cho đến khi dư bằng 0. Khi đó, ước chung lớn nhất sẽ là số bị chia cuối cùng.
        /*Ví dụ, giả sử chúng ta muốn tìm ước chung lớn nhất của 24 và 36 bằng thuật toán Euclid:
           Bước 1: Ta tính phép chia lấy dư 24 chia 36, kết quả là 24 (phần dư).
           Bước 2: Gán 36 cho a và 24 cho a.
           Bước 3: Ta tính phép chia lấy dư 36 chia 24, kết quả là 12 (phần dư).
           Bước 4: Gán 24 cho a và 12 cho b
           Bước 5: Ta tính phép chia lấy dư 24 chia 12, kết quả là 0 (phần dư).
           Bước 6: Vì phần dư bằng 0, nên ta kết thúc vòng lặp.
           Bước 7: Trả về giá trị của a là 12. Vậy ước chung lớn nhất của 24 và 36 là 12.*/
        static int TimUCLN(int a, int b)
        {
            while (b != 0)
            {
                int UCLN = a % b;
                a = b;
                b = UCLN;
            }
            return a;
        }
    }
}