using System.Threading;

namespace chay_chuong_trinh_theo_thoi_gian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" start ! toi cho ban 3 s de chuan bi ");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(" doan code duoi day chay theo thoi gian cach nhau 2 s ");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine(" doan code nay cach doan code tren 2s dung chu");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Console.WriteLine(" doan code nay cach doan code tren 4s dung chu :)) , chuong trinh ket thuc sau 3 s ");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(" the end !" );
            Console.ReadLine();
        }
    }
}