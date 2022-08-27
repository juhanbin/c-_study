using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 데이터 + 로직
            // 체력 0
            
            //byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            //sbyte(1바이트 -128~128), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong
            int hp;
            short level = 100;
            long id;
            hp = 100;

            byte attack = 0;
            attack--;
            Console.WriteLine("Hello Number! {0}",attack);
        }
    }
}