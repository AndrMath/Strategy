using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Implementation
{
    public class Quack : QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
