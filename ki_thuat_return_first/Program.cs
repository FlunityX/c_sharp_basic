using System;

namespace ki_thuat_return_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhập số: " );
            a =int.Parse(Console.ReadLine());

            /* cách này khá dài  :
             if (a % 3 == 0)
             {
                 if (a % 4 == 0)
                 {
                     if (a % 5 == 0)
                     {
                         Console.WriteLine("a thỏa mãn điều kiện chia hết cho 3, 4 và 5.");
                     }
                     else
                     {
                         Console.WriteLine("a không thỏa mãn điều kiện chia hết cho 3, 4 và 5.");
                     }
                 }
                 else
                 {
                     Console.WriteLine("a không thỏa mãn điều kiện chia hết cho 3, 4 và 5.");
                 }
             }
             else
             {
                 Console.WriteLine("a không thỏa mãn điều kiện chia hết cho 3, 4 và 5.");
             } */

            /*  if (a % 3 != 0)
                      return ;
                  if (a % 4 !=0)
                      return;
                  if ((a % 5) != 0) 
                      return;  */
            if (a % 3 != 0 || a % 4 != 0 || a % 5 != 0)
            {
                Console.WriteLine("a khong thỏa mãn điều kiện chia hết cho 3, 4 và 5.");
            }
            else
            {
                Console.WriteLine("a thỏa mãn điều kiện chia hết cho 3, 4 và 5.");
            }
            Console.ReadLine();

        }
    }
}