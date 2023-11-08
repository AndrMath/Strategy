using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatosDeNovo.Implementation
{
    internal class FlyWithRocket : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with a rocket");
        }
    }
}
