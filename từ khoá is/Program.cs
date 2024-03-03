namespace từ_khoá_is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 56;
            // từ khoá is nhằm tránh lặp lại tên biến

           if( result is > 40 and < 69)
            {
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
