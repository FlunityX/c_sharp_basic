using System.Text;

namespace swich_case_vd_tin_can_chi
{
    /* Viết chương trình tính năm âm lịch từ năm dương lịch đã nhập.

     Thuật toán tính năm âm lịch:
     Năm âm lịch = Can + Chi. Vì thế cần tính được Can và Chi sau đó ghép lại là xong.
     Tính Can bằng cách:
     Tìm phần dư của phép chia năm dương lịch cho 10.
     Can tương ứng 0 đến 9 --> Canh Tân Nhâm Quý Giáp Ất Bính Đinh Mậu Kỷ
     Năm dương % 10
     Tìm Chi bằng cách:
     Tìm phần dư của phép chia năm dương lịch cho 12.
     Tra bảng sau để tìm ra Chi tương ứng:
     Năm dương % 12
     Nối Can và Chi lại để được kết quả.*/
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int can, chi;
            Console.WriteLine("nhap nam ");
            int nam = int.Parse(Console.ReadLine());
            can = nam % 10;
            chi = nam % 12;
            switch ( can)
            {
                case 0:
                    Console.WriteLine("Canh");
                    break;
                case 1:
                    Console.WriteLine("Tân");
                    break;
                 case 2:
                    Console.WriteLine("Nhâm");
                    break;
                case 3:
                    Console.WriteLine("Quý");
                    break;
                case 4:
                    Console.WriteLine("Giáp");
                    break;
                case 5:
                    Console.WriteLine("Ất");
                    break;
                case 6:
                    Console.WriteLine("Bính");
                    break;
                case 7:
                    Console.WriteLine("Đinh");
                    break;
                case 8:
                    Console.WriteLine("Mậu");
                    break;
                case 9:
                    Console.WriteLine("Kỷ");
                    break;
            }
            switch (chi)
            {
                case 0:
                    Console.WriteLine("Thân");
                    break;
                case 1:
                    Console.WriteLine("Dậu");
                    break;
                case 2:
                    Console.WriteLine("Tuất");
                    break;
                case 3:
                    Console.WriteLine("Hợi");
                    break;
                case 4:
                    Console.WriteLine("Tý");
                    break;
                case 5:
                    Console.WriteLine("Sửu");
                    break;
                case 6:
                    Console.WriteLine("Dần");
                    break;
                case 7:
                    Console.WriteLine("Mão");
                    break;
                case 8:
                    Console.WriteLine("Thìn");
                    break;
                case 9:
                    Console.WriteLine("Tỵ");
                    break;
                case 10:
                    Console.WriteLine("Ngọ");
                    break;
                case 11:
                    Console.WriteLine("Mùi");
                    break;


            }
            
            Console.ReadLine();
        }
    }
}