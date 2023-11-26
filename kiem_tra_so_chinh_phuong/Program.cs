namespace kiem_tra_so_chinh_phuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so n :");
            int n = int.Parse(Console.ReadLine());
            sochinhphuong(n);
            bool so_n = sochinhphuong(n);
            if (so_n )
            {
                Console.WriteLine(" so {0} la so chinh phuong" ,n);
            }
            else
            {
                Console.WriteLine(" so {0} khong la so chinh phuong ", n);
            }
            Console.ReadLine();
        }
        public static bool sochinhphuong(int n)
        {
            double can_n = Math.Sqrt(n);
            int can_nguyen = (int)can_n;
            if (n < 0)
            {
                Console.WriteLine("so ko hop le !");
            }
             if (can_n -can_nguyen ==0)
            {
                return true;
            }
            return false;
        }
    }
}