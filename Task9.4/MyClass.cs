using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._4
{
    public class MyClass : IDisposable

    {
    public Array myArray = new int[10000];
    private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Данні очищено");
                }
                disposed = true;
            }
        }

        ~MyClass()
        {
            Dispose(false);
            Console.WriteLine("Finalize");
        }
    }
}
