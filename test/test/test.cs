using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 삼항연산자
            int number = 25;

            bool isPair = ((number % 2) == 0 ? true : false);

            if ((number % 2) == 0)
                isPair = true;
            else
                isPair = false;
        }
    }
}