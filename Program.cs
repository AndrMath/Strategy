using Patos.Abstraction;
using Patos.Implementation;
using Patos.Patos;
using PatosDeNovo.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatosDeNovo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duck Mallard = new MallardDuck();
            Mallard.DisplayDuck();
            Mallard.Swim();
            Mallard.PerformQuack();
            Mallard.PerformFly();
            Console.ReadKey();
            Duck Model = new ModelDuck();
            Model.DisplayDuck();
            Model.Swim();
            Model.PerformQuack();
            Model.PerformFly();
            Mallard.SetQuackBehavior(new MuteQuack());
            Mallard.PerformQuack();
            Console.ReadKey();
        }
    }
}
