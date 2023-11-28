namespace chuyen_thap_phan_sang_nhi_phan
{
    internal class Program
    {
        // ý tưởng : đầu tiên nhập vào số thập phân rồi truyền vào hàm đổi nhị phân , 1 chuỗi trống 
        // và thực hiện vòng lập nếu số nhập vào lớn hơn 0 
        //chuỗi tróng đó sẽ đc thêm phần tử là 0 hoăc 1 theo phép chia dư cho 2
        static void Main(string[] args)
        { 
            Console.Write("nhap so thap phan : ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binary = ConvertDecimalToBinary(decimalNumber);

                Console.WriteLine("so nhi phan : " + binary);
            Console.ReadLine();
            }

            static string ConvertDecimalToBinary(int decimalNumber)
            {
                string binary = "";

                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binary = remainder + binary;
                    decimalNumber /= 2;
                }

                return binary;
            }
        }
    }
