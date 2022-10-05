using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace CSharp
{
    class Player // 부모 / 기반
    {
        static public int counter = 1;//오로지 1개만 존재
        public int id;
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }
    class Mage : Player
    {
    }
    class Archer : Player
    {
    }
    class Knight : Player // 자식 / 파생
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
        }
    }
}
//스텍
//힙