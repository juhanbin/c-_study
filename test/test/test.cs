using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int level = 50;
            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);
            
            //&& AND    ||OR    ! NOT
            //a=살아있는 고랩 유저인가요?
            bool a = isAlive && isHighLevel;

            //b = 살아있거나, 고랩 유저이거나, 둘 중 하나인가요?
            bool b = isAlive || isHighLevel;
            
            //c = 죽은 유저인가요?
            bool c = !isAlive;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
        }
    }
}