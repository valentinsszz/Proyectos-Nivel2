using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("pepe");
            p1.setEdad(20);
            Console.WriteLine("La edad es " + p1.getEdad());
            Console.WriteLine(p1.saludar());

            //Perro b1 = new Perro();
            //b1.Nombre = "Pepe";
            //Console.WriteLine("el nombre del perro es " + b1.Nombre);

            //b1.Color = "Negro";
            //Console.WriteLine("El color es " + b1.Color);

            //b1.Origen = "Bolivia";
            //Console.WriteLine("El origen es" + b1.Origen);
            Console.ReadKey();


        }
    }
}
