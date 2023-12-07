namespace đổi_màu_chữ_và_đổi_màu_nền___chương_trình
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // đổi màu chữ thành màu vàng 
           Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" đây là màu vàng ");
            Console.ResetColor();
            // đổi màu nền thành xanh dương
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" đây là màu nền xanh");
            Console.ResetColor();
            // kết hợp cả 2 
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" kết hợp cả hai ");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}