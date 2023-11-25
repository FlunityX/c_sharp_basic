using System;
public class var_and_dynamic
{
    public static void Main(string[] args)
    {
        /*var: Từ khóa var được sử dụng để khai báo biến khi kiểu dữ liệu của biến có thể được suy luận từ giá trị 
        khởi tạo của biến. Kiểu dữ liệu của biến được xác định tại thời điểm biên dịch dựa trên kiểu dữ liệu
        của giá trị khởi tạo. Điều này có nghĩa là kiểu dữ liệu của biến sẽ được xác định tĩnh và không thay đổi 
        trong quá trình thực thi.*/
        var name = "John"; // Biến name được suy luận là kiểu string
        var age = 25; // Biến age được suy luận là kiểu int
        Console.WriteLine("name :{0} , age :{1} ",name,age);
        /*dynamic: Từ khóa dynamic được sử dụng để khai báo biến có kiểu dữ liệu động. 
        Biến được khai báo là dynamic có thể thay đổi kiểu dữ liệu và thực hiện kiểm tra kiểu dữ liệu 
        tại thời điểm chạy (runtime) thay vì thời điểm biên dịch. Kiểu dữ liệu của biến dynamic sẽ được 
        xác định và giải quyết tại thời điểm chạy.*/
        dynamic data = 12;
         data ="8 byte ";
        Console.WriteLine(data);
        Console.ReadLine();
    }
}