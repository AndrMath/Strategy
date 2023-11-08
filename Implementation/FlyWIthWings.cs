using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Implementation
{
    public class FlyWIthWings : FlyBehavior
    {
        public void Fly() 
        {
            Console.WriteLine("Flap, Flap, Flap");
        }
    }
}
