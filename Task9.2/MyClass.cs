using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task9._2
{
    internal class MyClass
    {
        public void MyMethod(long limit)
        {
            int i = 0;
            while (true)
            {
                if (limit >= GC.GetTotalMemory(false) - 1000)
                {
                    Console.WriteLine("Використано пам'яті: "+GC.GetTotalMemory(false));
                    Console.WriteLine(i);
                    Thread.Sleep(10);
                    i++;
                }
                else
                {
                    Console.WriteLine("Перевищено ліміт використаної пам'яті");
                    break;
                }
                
            }
        }
    }
}
