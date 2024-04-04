using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._04._04.Models
{
    internal abstract class Animal
    {
        public abstract void Eat();
    }
    abstract class Bird : Animal
    {
        public abstract void Fly();
        

        
    }
    class Parriot : Bird
    {

        public override void Eat() 
        {
            Console.WriteLine("Qush yemi");
        }
        public void Talk()
        {
            Console.WriteLine("Cik cik");
        }
        public override void Fly()
        {
            Console.WriteLine("Fly is parriot");
        }
    }
    class Eagle : Bird
    {
        public override void Eat() 
        {
            Console.WriteLine("Ilan yeyir");
        }
        public override void Fly()
        {
            Console.WriteLine("Fly is eagle");
        }
    }
    abstract class Fish : Animal
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
    class Shark : Fish
    {

        public override void Eat()
        {
            Console.WriteLine("Kicik baliqlari yeyir");
        }
        public void Hunt()
        {
            Console.WriteLine("Dead");
        }
    }
}
