using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tính_hàm_bậc_2
{
    internal class Program
    {
        //  ax^2+bx+c =0
        static void Main(string[] args)
        {
            Console.WriteLine("PHUONG TRINH ax^2+bx+c ");
            Console.WriteLine("nhap he so a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so c :");
            int c = int.Parse(Console.ReadLine());
            tinhphuongtrinhbac2(a, b, c);
            Console.ReadLine();
        }
        static void tinhphuongtrinhbac2(int a , int b, int c)
        {
            double dental = Math.Pow(b, 2);
            if(dental  < 0 )
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if (dental ==0)
            {
                double x;
                x=-b/2*a;
                Console.WriteLine("phuong trinh co nghiem kep la : x1 = x2 ={0}" ,x  );
            }
            else
            {
                double x1, x2;
                x1 = -b + Math.Sqrt(dental) / 2 * a;
                x2 = -x1;
                Console.WriteLine("phuong trinh co 2 nghiem la : x1 = {0} và x2 = {1}" ,x1 ,x2);
            }
        }
    }
}
