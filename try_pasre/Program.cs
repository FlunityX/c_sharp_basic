using System.Diagnostics;

namespace try_pasre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên n (nhỏ hơn 50):");
            string input = Console.ReadLine();

            int n;
            // out là tham số đầu ra n là đầu ra thành công của input
            //  && là toán tử và cho biết phải thoả mãn cả 2 mới out n , nếu ko thực hiện else và nhập lại 
            if (int.TryParse(input, out n) && n < 50)
            {
                // Đầu vào hợp lệ và n nhỏ hơn 50
                Console.WriteLine("Số n đã nhập: " + n);
            }
            else
            {
                // Đầu vào không hợp lệ hoặc n không nhỏ hơn 50
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập lại.");
            }
            Console.ReadLine();
        }
    }
}
