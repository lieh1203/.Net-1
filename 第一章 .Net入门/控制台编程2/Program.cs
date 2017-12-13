using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台编程2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "如鹏网控制台"; //控制台标题内容
            Console.WriteLine(12345);
            Console.SetCursorPosition(5, 10); //按照坐标输出内容后面的aaa
            Console.WriteLine("aaa");
            //后续输出的内容都为红色
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("bbbbb");
            Console.WriteLine("ccccc");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White; //设置前景色
            Console.BackgroundColor = ConsoleColor.Green; //设置背景色
            Console.WriteLine("dddddddddddddd");
            Console.ReadKey();
            Console.ResetColor(); //恢复默认颜色（默认可以自行设置）
            Console.WriteLine("xxxxxxxx");
            Console.ReadKey();
        }
    }
}
