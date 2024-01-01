using System;

namespace mat_xuc_sac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập mặt xúc xắc nhảy lần 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mặt xúc xắc nhảy lần 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mặt xúc xắc nhảy lần 3:");
            int c = int.Parse(Console.ReadLine());

            int matA = MatConLaiXucSac(a);
            int matB = MatConLaiXucSac(b);
            int matC = MatConLaiXucSac(c);
            int tongMatConLai = TongMat(matA, matB, matC);
            Console.WriteLine("Tổng số mặt con lại sau 3 lần gieo: " + tongMatConLai);
            Console.ReadLine();
        }

        static int MatConLaiXucSac(int xucSac)
        {
            if (xucSac == 1)
                return 6;
            if (xucSac == 2)
                return 5;
            if (xucSac == 3)
                return 4;
            if (xucSac == 4)
                return 3;
            if (xucSac == 5)
                return 2;
            return 1;
        }

        static int TongMat(int matA, int matB, int matC)
        {
            return matA + matB + matC;
        }
    }
}
