
namespace thamsomacdinh
{
    internal class Program
    {
        static void method (string name = "jack")
        {
            Console.WriteLine(name);
        } 
        static void Main(string[] args)
        {
            method();
            method("david");
            Console.ReadLine();
        }
    }
}
