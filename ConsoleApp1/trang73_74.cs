using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class trang73_74
    {
        public static void Main(string[] args)
        {
            Console.Write("nhap so giay:");
            int giay = Convert.ToInt32(Console.ReadLine());
            int phut = (giay % 3600) / 60;
            int gio = giay / 3600;
            int remainingSeconds = giay % 60;
            Console.WriteLine($"{gio}:{phut}:{remainingSeconds}");
        }
    }
}
