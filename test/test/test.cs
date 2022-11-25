using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace CSharp
{
    //객체(OOP)
        
    //Knight
    //속성:hp,attack
    //기능:Move,Attack,Die

    //참조
    class Knight
    {
        //필드
        static public int counter = 1;    //오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;
        /*
        static public void Test()   //static O 붕어빵틀에 종속 / static X 인스턴스에 종속
        {
            counter++;
        }
        */

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight()
        {
            id = counter;
            counter++;
            
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }
        public Knight(int hp) : this()  //  : this() = 빈 생성자 호출후 인자 대입
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출");
        }
        public Knight(int hp,int attack)
        {
            this.hp = hp;
            Console.WriteLine("int,int  생성자 호출");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    //복사
    struct Mage
    {
        public int hp;
        public int attack;
    }
    
    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            /*
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            //KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;
            
            Knight knight = new Knight();   //객체 생성
            Knight knight2 = new Knight(50);
            Knight knight3 = new Knight(50,30);
            
            knight.hp=100;
            knight.attack = 10;
            knight.Move();
            knight.Attack();
            KillKnight(knight);

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
            */
            Knight knight = Knight.CreateKnight();  //static O
            knight.Move();  //static X
            /*
            Console.WriteLine();
            Random rand = new Random();     //static O
            rand.Next(0,2);     //static X
            */
        }
    }
}
//stack
//함수 종료시 공간 삭제

//heap
//delete하지 않으면 계속 해서 heap영역에 유지
//c#의 경우 참조하지 않으면 자동으로 삭재
//ref의 경우 꼭 heap영역에 있는게 아니라 stack영역에 있을수 있음