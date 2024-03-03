namespace các_cách_ghi_chuỗi_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "manh";
            int age = 20;
            // cách 1:
            Console.WriteLine("ten cua ban la :{0} va tuoi la :{1} ",name,age);
            // cách 2 :
            Console.WriteLine("ten cua ban la :" + name + " va tuoi la :" + age);
            // cách 3 :
            Console.WriteLine($"ten cua ban la :{name} va tuoi la :{age}");
            Console.ReadLine();

        }
    }
}
