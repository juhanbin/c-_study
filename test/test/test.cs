using System;
using System.Runtime.InteropServices;

namespace CSharp
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight=1,
            Archer=2,
            Mage=3
        }

        struct Player
        {
            public int hp;
            public int attack;
            public ClassType type;
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }

        static void CreatPlayer(ClassType choice, out int hp, out int attack)
        {
            hp = 0;
            attack = 0;
            switch (choice)
            {
                case ClassType.Knight:
                    hp = 100;
                    attack = 10;
                    break;
                case ClassType.Archer:
                    hp = 75;
                    attack = 12;
                    break;
                case ClassType.Mage:
                    hp = 50;
                    attack = 15;
                    break;
                default:
                    hp = 0;
                    attack = 0;
                    break;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ClassType.None;
                choice=ChooseClass();
                if (choice != ClassType.None)
                {
                    Player player;
                    
                    int hp;
                    int attack;
                    CreatPlayer(choice, out player.hp,out player.attack);
                    Console.WriteLine($"Hp{player.hp} Attack{player.attack}");
                }
            }
        }
    }
}