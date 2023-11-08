using Patos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Implementation
{
    public class MuteQuack : QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("No quack");
        }
    }
}
