using Patos.Abstraction;
using Patos.Implementation;
using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Patos
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(fly:new FlyWIthWings(), quack: new Quack())
        { 
        
        }
        
        public override void DisplayDuck() 
        {
            Console.WriteLine("MallardDuck");
        }
    }
}
