using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_colleciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "rojo";
            c2.Color = "Verde";
            c3.Color = "Amarillo";

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("Las camionetas son " + listaCamionetas.Count);
            listaCamionetas.Remove(c3);
            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color es: " + item.Color);
            }


            Console.ReadKey();
        }
    }
}
