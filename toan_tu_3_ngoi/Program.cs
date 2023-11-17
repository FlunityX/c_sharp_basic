using System;

namespace toan_tu_3_ngoi
{
    internal class Program
    {
        // nhập vào 1 điểm số bất kì và cho biết điểm đó có được học sing giỏi ko
        static void Main(string[] args)
        {
            bool hocsinhkogioi = false;
            Console.WriteLine("Nhập vào số điểm của bạn: ");
            double n = double.Parse(Console.ReadLine());
            if ( n <= 8.0)
            {
                hocsinhkogioi = true;
            }
            Console.WriteLine(hocsinhkogioi ?  "Bạn chưa là học sinh giỏi" : "Bạn là học sinh giỏi");
            Console.ReadLine();
        }
    }
}