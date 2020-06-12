using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//using Abstraction.Interface jika menggunakan interface   
using Abstraction.AbstractClass; 


namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            //menggunakan abstact classs
            Lari lari;                     
	        lari = new Sprint(); 
            lari.Jenis();

            Console.WriteLine();
            lari = new Estafet();
            lari.Jenis();           

            Console.WriteLine();
            lari = new Marathon();
            lari.Jenis();


            //menggunakan interface
	        /*  
            ILari lari;                     
	        lari = new Sprint(); 
            lari.Jenis();

            Console.WriteLine();
            lari = new Estafet();
            lari.Jenis();           

            Console.WriteLine();
            lari = new Marathon();
            lari.Jenis(); 
            */


            Console.ReadKey();
        }
    }
}
