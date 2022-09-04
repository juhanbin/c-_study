using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //0:가위  1:바위    2:보

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); //0~2사이의 랜덤 값

            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }
            
            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컵퓨터의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("컵퓨터의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("컵퓨터의 선택은 보입니다.");
                    break;
            }
            
            //승리 무승부 패배
            if(Choice==aiChoice)
                Console.WriteLine("무승부 입니다");
            else if((Choice==0 && aiChoice==2)
                    ||(Choice==1 && aiChoice==0)
                    ||(Choice==3 && aiChoice==1))
                Console.WriteLine("당신이 이겼습니다.");
            else Console.WriteLine("컴퓨터가 이겼습니다");
        }
    }
}