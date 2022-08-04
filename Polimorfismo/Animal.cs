using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("El animal hace sonidos");
        }
    }

    internal class ping : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("El cerdo hace: wee wee");
        }
    }

    internal class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("El perro hace: bow bow");
        }
    }
}
