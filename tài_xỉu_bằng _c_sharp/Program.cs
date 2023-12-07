using System;

namespace ramdom_tai_xiu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start !");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("loading ...");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            int a = 100000;
            Console.WriteLine(" ban co 50% vao tai va 50% vao xiu !");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("ban dang co {0} dong ", a);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Random random = new Random();
            // nếu a >0 tức còn tiền cược 
            while (a > 0)
            {
                Console.WriteLine("So du tai khoan: " + a + " dong");
                Console.WriteLine("nhap tien cuoc (nhap 0 de thoat):");
                int cuoc = int.Parse(Console.ReadLine());
                // hết tiền 
                if (cuoc == 0)
                {
                    Console.WriteLine("Thoat khoi tro choi.");
                    break;
                }
                // cược nhiều hơn tiền 
                if (cuoc > a)
                {
                    Console.WriteLine("So du tai khoan khong du. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Chon cuoc (0 - tai, 1 - xiu):");
                int chon = int.Parse(Console.ReadLine());
                // nếu ko bấm 0 hoăc 1 
                if (chon != 0 && chon != 1)
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    continue;
                }

                Console.WriteLine("Ban da dat cuoc {0} dong vao {1}. An Enter de hien thi ket qua.", cuoc, chon == 0 ? "Tai" : "Xiu");
                Console.ReadLine();

                int randomNumber = random.Next(1, 101);  // Tạo số ngẫu nhiên từ 1 đến 100
                Console.WriteLine("ket qua: " + randomNumber);
                // chọn tài mà ramdom ra số nhỏ hơn 50 và chọn xỉu random số lớn hơn 50 thì thắng 
                if ((chon == 0 && randomNumber <= 50) || (chon == 1 && randomNumber > 50))
                {
                    a += cuoc;
                    Console.WriteLine("Ket qua: {0}. Ban da thang!", chon == 0 ? "Tai" : "Xiu");
                }
                else // ngược lại 
                {
                    a -= cuoc;
                    Console.WriteLine("Ket qua: {0}. Ban da thua!", chon == 0 ? "Tai" : "Xiu");
                }
            }
            Console.WriteLine("Het tien! Tro choi ket thuc.");
            Console.ReadLine();
        }
    }
}