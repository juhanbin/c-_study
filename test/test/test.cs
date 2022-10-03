using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace CSharp
{
    class Knight
    {
        static public int counter = 1;//오로지 1개만 존재
        
        public int hp;
        public int attack;

        static public void Test()
        {
            counter++;
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = hp;
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
    
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();//static
            knight.Move();//일반

            Console.WriteLine();
        }
    }
}
//스텍
//힙