using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so_thảy_xúc_sắc
{
    internal class Program
    {
        // bạn thắng và hùng thi đọ số xúc xắc viết chương trình xem ai thắng 
        // hùng thắng chữ xanh dương thắng thắng chữ xanh lá , hoà chữ màu vàng
        static void Main(string[] args)
        {
            int random1 = new Random().Next(1,6);
            int random2 = new Random().Next(1,6);
            Console.WriteLine("hung tung duoc so xuc sac la :" +random1);
            Console.WriteLine("thang tung do so xuc sac la :" + random2);
            if (random1 > random2)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                int chenhlenh = random1 - random2;
                Console.WriteLine("hung da danh chien thang vi hon thang tan :" + chenhlenh);
                Console.ResetColor();
            }
            else if(random1 == random2)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("2 ban hoa nhau , ko ai thang ");
                Console.ResetColor();
            }
            else{
                Console.ForegroundColor = ConsoleColor.Green;
                int chenhlenh1 = random2 - random1;
                Console.WriteLine("thang da danh chien thang vi hon hung tan :" + chenhlenh1);
                Console.ResetColor();
            }
            Console.ReadLine();
        }
    }
}
