using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iroha_và_haiku
{
    //ABC042_A - Iroha và Haiku
    /*Iroha yêu Haiku. Haiku là một dạng thơ ngắn của Nhật Bản. Một bài Haiku bao gồm ba câu với số ký tự lần lượt là 5, 7 và 5.
     Để tạo ra một bài thơ Haiku. Iroha đã nghĩ ra ba câu khác nhau. Mỗi câu có độ dài tương ứng là A ,B ,C 
.   Xác định xem cô ấy có thể tạo một bài Haiku bằng cách sử dụng 3 câu trên mỗi câu 1 lần hay không?*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap do dai cau A :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap do dai cau B :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap do dai cau C :");
            int c = int.Parse(Console.ReadLine());
            if ((a == 7 && b == 5 && c == 5) || (a == 5 && b == 7 && c == 5) || (a == 5 && b == 5 && c == 7))
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
