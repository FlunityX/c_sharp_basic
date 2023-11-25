namespace kieu_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kiểu nullable giúp bạn xử lý các trường hợp khi một biến có thể không có giá trị, đồng thời vẫn cho phép sử dụng
             * các phép toán và phương thức của kiểu dữ liệu cơ bản đó.*/
            int? nullableInt = null;
            //nếu nullableInt là null, intValue sẽ được gán giá trị 0. Nếu nullableInt không phải là null,
            //intValue sẽ được gán giá trị của nullableInt.
            int intValue = nullableInt ?? 0;// Sử dụng toán tử ?? để gán giá trị mặc định nếu nullableInt là null
            Console.WriteLine(intValue);
            Console.ReadLine();
        }
    }
}