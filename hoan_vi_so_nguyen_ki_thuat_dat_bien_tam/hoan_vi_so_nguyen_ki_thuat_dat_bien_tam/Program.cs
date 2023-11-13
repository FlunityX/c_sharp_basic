using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoan_vi_so_nguyen_ki_thuat_dat_bien_tam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so nguyen can hoan , a = :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap so nguyen can hoan , b = :");
            int b = int.Parse(Console.ReadLine());
            // đặt biến tạm là 1 kĩ thuật lập trình cơ bản . biến này tạm lưu giá trị của biến khác trước khi nó bị thay đổi và chỉnh sửa 
            // giá trị temp ban đầu là a nhưng cuối cùng gán b 
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("  so nguyen a da bi hoan doi thanh so nguyen b , do la :" + a);
            Console.WriteLine(" so nguyen b da bi bien doi thanh so nguyen a , do la : " + b);
            Console.ReadLine();
        }
    }
}
