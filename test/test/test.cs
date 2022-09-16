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
        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;
            
            while (true)
            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");

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

                if (choice != ClassType.None)
                    break;
            }
        }
    }
}