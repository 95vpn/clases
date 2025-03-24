using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06libPedidos;

namespace clases
{
    public static class FuncionesPrincipales
    {
        public static void EjemploCliente()
        {
            
            clsClientes cliente;

            cliente = new clsClientes();
            cliente.idCliente = 1;
            cliente.NombreCompleto = "Marcos Hernandez";
            cliente.Rfc = "sdfsd0215";
            Console.WriteLine(cliente.ToString());
            
        }

        public static void EjemploRecordProducto()
        {
            clsProductos Producto = new clsProductos();

            Producto.idProducto = 1;
            Producto.Description = "REF MANZANA 600 ML";
            Producto.CodigoBarras = "0001";

            clsProductos Productos2 = new clsProductos();
            Productos2 = Producto;
            Productos2.CodigoBarras = "0";

            recProductos rProducto = new recProductos(1, "REF MANZANA 600 ML", "0001");
            recProductos rProducto2 = rProducto with { CodigoBarras = "0" };

            Console.WriteLine("Producto: " + Producto);
            Console.WriteLine("Producto2: " + Productos2);
            Console.WriteLine("rProducto: " + rProducto);
            Console.WriteLine("rProducto2: " + rProducto2);

            if (Producto == Productos2)
                Console.WriteLine("Los objetos son iguales");
            else
                Console.WriteLine("Los objetos son diferentes");
            if (rProducto == rProducto2)
                Console.WriteLine("Los registros son iguales");
            else
                Console.WriteLine("Los resgistros son diferentes");
        }
    }
}
