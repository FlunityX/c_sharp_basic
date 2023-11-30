namespace xử_lý_ngoại_lệ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Trong lập trình, "tình huống ngoại lệ" (exception) là một sự kiện hoặc điều kiện đặc biệt mà khi xảy ra,
             * nó làm gián đoạn luồng bình thường của chương trình và yêu cầu một xử lý đặc biệt
             * . Các tình huống ngoại lệ thường xuyên xảy ra khi có sự cố hoặc
             * điều kiện không mong muốn xảy ra trong quá trình thực thi chương trình.
             * vd : chia cho 0,Truy cập mảng với chỉ số vượt quá giới hạn,Không thể mở tệp không tồn tại
 * try: Một khối try nhận diện một khối code mà ở đó các exception cụ thể được kích hoạt. Nó được theo sau bởi một hoặc nhiều khối catch.

catch: Một chương trình bắt một Exception với một Exception Handler tại vị trí trong một
            chương trình nơi bạn muốn xử lý vấn đề đó. Từ khóa catch trong C# chỉ dẫn việc bắt một exception.

finally: Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho,
            dù có hay không một exception đươc ném hoặc không được ném. Ví dụ, nếu bạn mở một file, nó phải được đóng, nếu không sẽ có một exception được tạo ra.

throw: Một chương trình ném một exception khi có một vấn đề xuất hiện. Điều này được thực hiện bởi
            sử dụng từ khóa throw trong C#.*/
            try
            {
                ValidateAge(15);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This block always executes, regardless of whether an exception occurs or not.");
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or older.", nameof(age));
            }

            Console.WriteLine("Age is valid.");
        }
    }
    }
