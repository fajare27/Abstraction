using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Marathon : Lari
    {
        public override void Jenis()
        {
            Console.WriteLine("Lari marathon adalah salah satu jenis lari");
            Console.WriteLine("Maraton adalah ajang lari jarak jauh yang biasanya sepanjang 42,195 kilometer");
        }
    }
}
