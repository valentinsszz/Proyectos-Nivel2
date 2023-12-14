using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Articulo[] articulos = new Articulo[10];

            //for (int x = 0; x < 10; x++)
            //{
            //    articulos[x] = new Articulo();
            //    Console.WriteLine("Ingrese los datos del producto ");
            //    Console.WriteLine("Codigo");
            //    articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Precio");
            //    articulos[x].Precio = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Codigo de marca");
            //    articulos[x].CodMarca = int.Parse(Console.ReadLine());


            //}
            //Venta venta = new Venta();

            //Console.WriteLine("Ingrese la venta");
            //Console.WriteLine("Codigo de Cliente");
            //venta.CodigoCliente = int.Parse(Console.ReadLine());
            //while (venta.CodigoCliente != 0)
            //{
            //    Console.WriteLine("Cantidad vendida");
            //    venta.CantidadVendida = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Codigo de Cliente");
            //    venta.CodigoCliente = int.Parse(Console.ReadLine());

            //    // trabajamos


            //    // pedimos denuevo
            //    Console.WriteLine("Ingrese la venta");
            //    Console.WriteLine("Codigo de Cliente");
            //    venta.CodigoCliente = int.Parse(Console.ReadLine());
            //}


            //Botella b1 = new Botella();
            //Console.WriteLine("Ingrese la cantidad");
            //b1.Cantidad = int.Parse(Console.ReadLine());
            //Console.WriteLine("ingrese el color ");
            //b1.Color = Console.ReadLine();
            //Console.WriteLine("ingrese el codigo de Botella ");
            //b1.CodigoBotella = int.Parse(Console.ReadLine());

            //if (b1.Cantidad > 100)
            //    Console.WriteLine("Es mayor a 100 mililitros es: " + b1.Cantidad);
            //else
            //{
            //   Console.WriteLine("La cantidad es " + b1.Cantidad);
            //}
            //Console.WriteLine("El color es " + b1.Color);

            //Console.WriteLine("El producto es el numero: " + b1.CodigoBotella);
            //Console.ReadKey();

            //for (int i = 0; i < length; i++)
            //{

            //}

            int n, x, acu, cont = 0;

            n = int.Parse(Console.ReadLine());

            while (n!=0)
            {
                x = 1;
                acu = 0;
                while (x<=10)
                {
                    x--;
                    acu += n + x;
                    n = int.Parse(Console.ReadLine());

                }
                if (acu>100)
                {
                    cont++;
                }
            }
            Console.WriteLine("hubo" + cont + "subgrupo");
            Console.ReadKey();
        }
    }
}
