using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Liskov
{
    //“Subtypes must be substitutable for their base types.”

    public interface IFlyingBird
    {
        public void Fly();
    }

    public interface ISwimmingBird
    {
        void Swim();
    }

    public abstract class Bird(string name)
    {
        public string Name { get; set; } = name;
    }

    public class Sparrow(string name) : Bird(name), IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

    public class Penguin(string name) : Bird(name), ISwimmingBird { 
    
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }
}
