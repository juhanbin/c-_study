using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            //sbyte(1바이트 -128~128), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong
            
            //10진수
            //0~9
                //10
                
            //2진수
            //0 1
                //0b00 0b01 0b10 0b11 0b100
                
            //16잔수
            //0~9 a b c d e f
                //0x00 0x01 0x02 ... 0x0F

            // //1바이트(참/거짓)
            // bool b;
            // b = true;
            // b = false;
            //
            // //소수
            // //4바이트
            // float f=3.14f;
            // //8바이트
            // double d=3.14;
            //
            // //2바이트
            // char c='a';
            // string str="Hello World!";
            // Console.WriteLine(str);
            
            //1. 바구니 크기가 다른 경우
            int a = 0xFFFF;
            short b = (short)a;
            
            //2. 바구니 크기는 같긴 한데, 부호가 다른 경우
            byte c = 255;
            sbyte sb = (sbyte)c;
            
            //3.소수
            float f = 3.14f;
            double d = f;
            //Console.WriteLine("Hello Number! {0}",attack);
        }
    }
}