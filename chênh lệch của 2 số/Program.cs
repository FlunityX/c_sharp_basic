using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chênh_lệch_của_2_số
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so thu nhat ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai ");
            int b = int.Parse(Console.ReadLine());
            int chenhlech =chenhlenh2so(a, b);
            Console.WriteLine("2 so do chenh nhau la :"+chenhlech);
            Console.ReadLine();
        }
        public static int chenhlenh2so(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            else 
                return b - a;
        }
    }
}
