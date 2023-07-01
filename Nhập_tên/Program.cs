using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhập_tên
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Họ và tên:  ");
            string name = Console.ReadLine();
            Console.WriteLine("Tên Bạn là  " + name);
            Console.ReadKey();

            

        }
    }
}
