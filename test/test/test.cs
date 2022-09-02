using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 123;
            int key = 401;

            int a = id ^ key;
            int b = a ^ key;

            // <<   >>    &(and)  |(or)    &(xor)   ~(not)
            
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}