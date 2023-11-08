using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Patos.Abstraction
{
    public abstract class Duck
    {
        FlyBehavior Flying;
        QuackBehavior Quack;

        public Duck(FlyBehavior fly, QuackBehavior quack)
        {
            Flying = fly;
            Quack = quack;
        }

        public abstract void DisplayDuck();

        public void PerformQuack() 
        {
            Quack.QuackSound();
        }

        public void PerformFly()
        { 
            Flying.Fly();
        }

        public void Swim() 
        {
            Console.WriteLine("All ducks float");
        }

        public void SetQuackBehavior(QuackBehavior quack)
        {
            Quack = quack;
        }

        public void SetFlyBehavior(FlyBehavior fly)
        {
            Flying = fly;
        }
    }
}
