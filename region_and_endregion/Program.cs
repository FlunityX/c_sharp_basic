namespace region_and_endregion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region lời chào 
            Console.WriteLine("Hello, World!");
            #endregion
            #region xuất ra số đã nhập 
            Console.WriteLine(" NHAP SO CUAR BAN :");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(" SO BAN VUA NHAP LA " + N);
            #endregion
            Console.ReadLine();
        }
    }
}