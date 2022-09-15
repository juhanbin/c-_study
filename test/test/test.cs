using System;

namespace CSharp
{
    class Program
    {
        static int Add(int a, int b)
        {
            int ret = a + b;
            return ret;
        }
        static void Main(string[] args)
        {
            int ret=Program.Add(10, 20);
            Console.WriteLine(ret);
        }
    }
}