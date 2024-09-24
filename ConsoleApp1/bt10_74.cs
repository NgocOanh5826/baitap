using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class bt10_74
    {
        public static void Main(string[] args)
        {
            Console.Write("nhap x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x1};{y1}");
            Console.Write("nhap x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{x2};{y2} \n");
            double kc = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
            Console.WriteLine("khoang cach cua toa do la:{0} ", kc);
        }
    }
}
