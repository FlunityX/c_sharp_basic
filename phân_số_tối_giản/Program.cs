using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phân_số_tối_giản
{
    internal class Program
    {
        //Cho tử số a và mẫu số b của 1 phân số là các số nguyên, bạn cần viết 1 chương trình rút gọn phân số về phân số tối giản.
        //Nếu phân số được yêu cầu không hợp lệ, in ra INVALID
        //Nếu giá trị của phân số là một số nguyên, in ra số nguyên đó
        //Trường hợp khác, in ra tử số và mẫu số của phân số tối giản cách nhau 1 dấu cách
        static void Main(string[] args)
        {
            Console.WriteLine(" nhap tu so a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" nhap tu so b :");
            int b = int.Parse(Console.ReadLine());
          
            if (b == 0)
            {
                Console.WriteLine("INVALID");
                return;
            }
            int ucln = Ucln(a,b);
            chiaphanso(a, b,ucln);
            Console.ReadLine();


        }
        public static int Ucln(int a, int b)
        {
            while (b != 0)
            {
                int UCLN = a % b;
                a = b;
                b = UCLN;
            }
            return a;
        }
        public static void chiaphanso(int a, int b , int ucln)
        {
            if (a % b == 0)
            {
              int c = a / b;
                Console.WriteLine("đây là phân số tối giản thành số nguyên thành "+c);
            }
            else
            {
                int amoi = a / ucln;
                int bmoi = b / ucln;
                Console.WriteLine(" phân số tối giản là :{0}/{1}", amoi, bmoi);
            }
            
        }
    }
}
