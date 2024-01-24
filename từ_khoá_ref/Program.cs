using System;

namespace từ_khoá_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Increment( ref number);
            Console.WriteLine(number);  // Kết quả: 11
        }
        // nếu ko dùng ref number sẽ đc copy Increment chỉ anh hưởng đến biến value- Kết quả: 10
        // nếu dùng ref thì nó tham chiếu trực tiếp đến number 
        static void Increment( ref int value)
        {
            value = value + 1;
        }
    }
}