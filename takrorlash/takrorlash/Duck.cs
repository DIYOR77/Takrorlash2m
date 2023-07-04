using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takrorlash
{
    internal class Duck : Animal,FLY,SWIM
    {
        public Duck(string name,int age)
            : base(name, age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public void swim()
        {
            Console.WriteLine($"{Name} is swiming.");
        }
        public void fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}
