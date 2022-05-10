using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання3
{
    internal class Program
    {
        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            System.Threading.Thread t = new System.Threading.Thread(Go);
            t.Name = "Thread" + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        static void Main(string[] args)
        {
            Go(10);
            Console.ReadKey();
        }
    }
}
