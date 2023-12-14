using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            Cocina c1 = new Cocina();
            
            Electrodomesticos e1 = new Electrodomesticos();
            e1.Voltaje = 220;
        }
    }
}
