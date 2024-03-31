namespace phan_loai_so_nguyen_to__va_hop_so
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thuật toán phân loại số nguyên tố và hợp số từ 1 số nhập vào
            Console.WriteLine("nhap n :");
            int n =int.Parse(Console.ReadLine());
            double  can_n = Math.Sqrt(n);
            bool isprime = true;
            if (n < 2)
            {
                Console.WriteLine(" so ko hop le !");
            }
            for(int i = 2; i <= can_n; i++) {
                if (n % i == 0)
                {
                    isprime = false;
                    break;
                }
                    }
            if (isprime==true) { Console.WriteLine("so {0} la so nguyen to", n); }
            if(isprime == false) { Console.WriteLine("so {0} la hop so", n); }
            Console.ReadLine();

        }
    }
}
