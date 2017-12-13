using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台编程1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            //让计算机发出蜂鸣声
            Console.Beep(1000, 1000);
            Console.Clear(); //清除屏幕内容
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }
    }
}
