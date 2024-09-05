using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public sealed class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public Motorcycle() { 
            HasSideCart = false;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Drive abstract motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Drive virtual motorcycle");
        }
    }
}
