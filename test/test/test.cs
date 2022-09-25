using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace CSharp
{
    class Knight
    {
        public int hp;
        public int attack;

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
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage;
            mage2.hp = 0;
            
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
        }
    }
}