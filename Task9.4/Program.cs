using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task9._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyClass myClass = new MyClass();
            for (int i = 0; i < myClass.myArray.Length; i++)
            {
                Console.WriteLine(i);
                myClass.Dispose();
            }

            Console.ReadLine();
        }
    }
}
