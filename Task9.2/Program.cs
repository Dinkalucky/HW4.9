using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long limit;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть ліміт пам'яті: ");
            Int64.TryParse(Console.ReadLine(), out limit);
            MyClass myClass = new MyClass();
            myClass.MyMethod(limit);
            Console.ReadKey();
        }
    }
}
