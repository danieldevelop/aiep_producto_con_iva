using System;

namespace producto_con_iva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 0;
            const double IVA = 0.19;
            double valorIVA = 0;
            double total = 0;

            Console.WriteLine("Ingrese el precio del producto: ");
            precio = double.Parse(Console.ReadLine());

            valorIVA = precio * IVA;
            total = precio + valorIVA;

            Console.WriteLine($"\nSubtotal: ${precio} " +
                $"\nValor IVA: ${valorIVA} " +
                $"\nTotal: ${total}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
