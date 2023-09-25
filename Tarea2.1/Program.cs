using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de camisas a comprar");
            int camisas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de cada camiseta");
            int precio = int.Parse(Console.ReadLine());

            if (camisas == 1)
            {
                Console.WriteLine($"No hay descuento, el precio seria: {precio}");
            }
            else if (camisas <= 5)
            {
                Console.WriteLine($"Descuento de 15%, el precio seria: {(camisas * precio) - (camisas * precio * 0.15)}");
            }
            else
            {
                Console.WriteLine($"Descuento de 20%, el precio seria: {(camisas * precio) - (camisas * precio * 0.20)}");
            }
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
