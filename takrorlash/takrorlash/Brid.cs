using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takrorlash
{
    internal class Brid: Animal,FLY
    {
        public Brid(string name,int age)
            : base(name, age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating. ");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping. ");
        }
        public  void  fly()
        {
            Console.WriteLine($"{Name} is flying. ");
        }
    }
    interface FLY
    {
        void fly();
    }
}

