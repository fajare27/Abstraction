using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class Sprint : ILari
    {
        public void Jenis()
        {
            Console.WriteLine("Lari sprint adalah salah satu jenis lari");
            Console.WriteLine("Lari sprint adalah berlari dalam jarak pendek dan dalam waktu singkat");
        }
    }
}
