namespace tong_1_day_so
{
    internal class Program
    {
        // tính tổng của A = 1+ 1/2+ 1/3+1/4+1/5 +... 1/N với N nhap tu ban phím
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n :");
            int N = int.Parse(Console.ReadLine());
            double tong = 0;
            for (int i = 1; i <= N; i++)
            {
                tong += 1.0 / i;
            }
            Console.WriteLine(" tong cua bieu thuc a la :{0} ", tong);
            Console.ReadLine();

        }
    }
}