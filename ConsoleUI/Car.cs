using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public sealed class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public Car() {
            HasTrunk = true;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Drive abstract car");
        }
    }
}
