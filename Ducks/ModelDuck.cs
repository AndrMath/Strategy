using Patos.Abstraction;
using Patos.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatosDeNovo.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(fly: new NoFlying(), quack: new Quack()) { }

        public override void DisplayDuck()
        {
            Console.WriteLine("Model Duck");
        }
    }
}
