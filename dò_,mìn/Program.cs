using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dò__mìn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = new Random().Next(1, 100);
           
            int solandoan = 0;
            Console.WriteLine("chao mung den voi game do min ");
            Console.WriteLine("chon 1 so tu 1 den 100 , moi ban chon so");
            do
            {
                Console.WriteLine("nhap so du doan :");
                int guess = int.Parse(Console.ReadLine());
                if ( guess < min)
                {
                    solandoan++;
                    Console.WriteLine("so can tim lon hon so ban chon");
                }
                else if (guess > min)
                {
                    solandoan++;
                    Console.WriteLine("so can tim be hon so ban chon");
                }
                if(guess ==min)
                {
                    Console.WriteLine("ban da chien thang : so min la :{0} , so lan doan cua ban la :{1}",guess,solandoan);
                    Console.ReadLine();
                    return;
                   
                }
          
            } while (true);
            
        }
        
    }
    
}
