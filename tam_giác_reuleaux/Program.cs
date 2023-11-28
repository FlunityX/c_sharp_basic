using System; 
namespace tam_giác_reuleaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.outputEncoding = system.Encoding.UTF8;
            Console.WriteLine("Nhập cạnh của tam giác Reuleaux đều:");
            double n = double.Parse(Console.ReadLine());
            double cv = 3 * n;
            double dt = ((3 * Math.Sqrt(3) / 4) * Math.Pow(n, 2));
            Console.WriteLine("Chu vi tam giác Reuleaux đều là: " + cv);
            Console.WriteLine("Diện tích tam giác Reuleaux đều là: " + dt);
            Console.ReadLine();
        }
    }
}