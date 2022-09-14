using System;

namespace CSharp
{
    class Program
    {
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;
            int result1;
            int result2;
            
            Divide(10,3,out result1,out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}