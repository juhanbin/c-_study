using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("hello world");
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hello world");
            }
        }
    }
}