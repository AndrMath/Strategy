using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Implementation
{
    public class SqueackQuack : QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("SqueakSound");
        }
    }
}
