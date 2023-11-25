namespace date_time_and_date_time_off_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            DateTime specificDate = new DateTime(2023, 5, 15, 10, 30, 0);

            // Xuất ra ngày giờ năm cụ thể từ biến currentDate
            Console.WriteLine("ngay h hien tai: {0}", currentDate.ToString("dd/MM/yyyy HH:mm:ss"));

            // Xuất ra ngày giờ năm cụ thể từ biến specificDate
            Console.WriteLine("ngay h cu the: {0}", specificDate.ToString("dd/MM/yyyy HH:mm:ss"));

            DateTimeOffset currentOffset = DateTimeOffset.Now;
            DateTimeOffset specificOffset = new DateTimeOffset(2023, 5, 15, 10, 30, 0, new TimeSpan(7 ,0,0));

            // Xuất ra ngày giờ năm cụ thể từ biến currentOffset
            Console.WriteLine("Ngày giờ hiện tại: {0}", currentOffset.ToString("dd/MM/yyyy HH:mm:ss zzz"));

            // Xuất ra ngày giờ năm cụ thể từ biến specificOffset
            Console.WriteLine("Ngày giờ cụ thể: {0}", specificOffset.ToString("dd/MM/yyyy HH:mm:ss zzz"));
            Console.ReadLine();
        }
    }
}