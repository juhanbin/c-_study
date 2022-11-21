using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace CSharp
{
    //객체(OOP)
        
    //Knight
    //속성:hp,attack
    //기능:Move,Attack,Die

    class Knight
    {
        public int hp;
        public int attack;

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
            Knight knight = new Knight();   //객체 생성
            
            knight.hp=100;
            knight.attack = 10;
            
            knight.Move();
            knight.Attack();
        }
    }
}