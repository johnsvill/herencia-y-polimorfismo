using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Villeda Pérez";
            Cliente.Nombres = "Jonathan";
            Cliente.RFC = "JSVP";
            Cliente.Direccion = "Ciudad";
            Cliente.Colonia = "La Escondida";
            Cliente.Municipio = "Mixco";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene crédito");
            else
                Console.WriteLine("El cliente NO tiene crédito");
            Console.ReadKey();
        }
    }
}
