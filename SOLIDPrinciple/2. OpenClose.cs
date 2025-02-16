using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    // Open for extension close for modification.

    public abstract class Vehicle
    {
        public abstract void Move();
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }

    public class Moterbike : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Moterbike is riding on the road.");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bicycle is pedding on the track.");
        }
    }
}
