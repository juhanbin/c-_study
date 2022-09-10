using System;

namespace CSharp
{
    class Program
    {
        //메소드   함수
        static void AddOne(ref int number)
        {
            number++;
        }
        
        static void Main(string[] args)
        {
            //복사(짭퉁)    참조(진퉁)
            int a = 0;
            Program.AddOne(ref a);
            Console.WriteLine($"결과는 {a}");
        }
    }
}