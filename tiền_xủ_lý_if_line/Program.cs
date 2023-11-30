using System.Diagnostics;

namespace tiền_xủ_lý_if_line
{
    internal class Program
    {
        //#if: Kiểm tra một hoặc nhiều biểu tượng để xem liệu chúng có ước lượng thành true hay không.
        //Nếu điều kiện đúng, các đoạn mã bên trong sẽ được biên dịch.
        //Ví dụ: #if DEBUG sẽ kiểm tra xem biểu tượng DEBUG có được định nghĩa hay không.
        
        //#else: Tạo một chỉ thị có điều kiện phức hợp, bên trong một khối #if.
        //Nếu điều kiện #if không đúng, các đoạn mã bên trong #else sẽ được biên dịch.

        //#endif: Đánh dấu phần cuối của một chỉ thị có điều kiện (conditional directive).
        //Nó chỉ định kết thúc của các khối #if, #else, #elif.

        //#line: Cho phép bạn chỉ định số dòng và tên tệp tin cho trình biên dịch và cảnh báo.
        //Ví dụ: #line 10 "myfile.cs" sẽ đặt số dòng hiện tại thành 10 và tên tệp tin thành "myfile.cs".
        static void Main(string[] args)
        {
            
           #if DEBUG 
            Console.WriteLine("Debug mode is enabled.");
           #else
            Console.WriteLine("Debug mode is disabled.");
           #endif

            #line 10 "myfile.cs"

            Console.WriteLine("Rest of the program.");

            Console.ReadLine();
        }
    }
}