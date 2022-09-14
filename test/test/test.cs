using System;

namespace CSharp
{
    class Program
    {
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static float Add(float a,float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }
        static void Main(string[] args)
        {
            int ret = Program.Add(2, 3);
            float ret2=Program.Add(2.0f, 3.0f);
            //Console.WriteLine(ret);
        }
    }
}