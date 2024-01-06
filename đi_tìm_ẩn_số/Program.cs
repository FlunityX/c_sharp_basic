using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace đi_tìm_ẩn_số
{
    // tìm số x biết : 1+2+3+...+x<=N với N là giá trị đã nhập 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n :");
            int n=int.Parse(Console.ReadLine());
            int s = sum(n);
            Console.WriteLine("gia tri cua x la :"+s);
            Console.ReadLine();
        }
        static int sum(int n)
        {
            int s = 0;
            int x = 1;
            while (s < n)
            {
                x++;
                s += x;
            }
            return x - 1;
        }
    }
}
