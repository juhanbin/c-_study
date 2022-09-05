using System;

namespace CSharp
{
    class Program
    {
        enum Choice
        {
            Rock=1,
            Paper = 2,
            Scissors = 0
        }
        static void Main(string[] args)
        {
            //0:가위  1:바위    2:보

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); //0~2사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }
            
            switch (aiChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("컵퓨터의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("컵퓨터의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("컵퓨터의 선택은 보입니다.");
                    break;
            }
            
            //승리 무승부 패배
            if(choice==aiChoice)
                Console.WriteLine("무승부 입니다");
            else if((choice==(int)Choice.Scissors && aiChoice==(int)Choice.Paper)
                    ||(choice==(int)Choice.Rock && aiChoice==(int)Choice.Scissors)
                    ||(choice==(int)Choice.Paper && aiChoice==(int)Choice.Rock))
                Console.WriteLine("당신이 이겼습니다.");
            else Console.WriteLine("컴퓨터가 이겼습니다");
        }
    }
}