using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class Estafet : ILari
    {
        public void Jenis()
        {
            Console.WriteLine("Lari estafet adalah salah satu jenis lari");
            Console.WriteLine("lari pada perlombaan atletik yang dilaksanakan secara bergantian atau beranting");
        }
    }
}
