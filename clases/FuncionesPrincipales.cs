﻿using _06libPedidos;

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

        public static void EjemploDesglosaImpuestos()
        {
            clsProductoPrecio Producto = new clsProductoPrecio();


            Producto.idProducto = 1;
            Producto.Description = "REF MANZANA 600 ML";
            Producto.CodigoBarras = "0001";
            Producto.PrecioPublico = 17.5m;
            Producto.PrecioMayoreo = 17;
            Producto.PorcentajeIva = 16;
            Producto.PorcentajeIeps = 8;
            decimal precioSinImpuestos, MontoIva, MontoIeps;
            Console.WriteLine(Producto);
            recMontosImpuestos Montos = new recMontosImpuestos(0, 0);
            precioSinImpuestos = Producto.DesglosaImpuestos(Montos);
            Console.WriteLine(precioSinImpuestos.ToString("C"));
            Console.WriteLine(Montos.ToString());
            

        }

        public static void EjemploColeccionesClientes()
        {
            List<clsClientes> Clientes = new List<clsClientes>();

            int opcion = 0;

            do
            {
                Console.WriteLine("Opciones de la lista de clientes");

                Console.WriteLine();
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Mostrar lista");
                Console.WriteLine("3. Eliminar cliente");
                Console.WriteLine("4. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame lops datos del cliente");
                        clsClientes cliente = new clsClientes();
                        cliente.idCliente = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame el nombre completo del cliente");
                        cliente.NombreCompleto = Console.ReadLine();
                        Console.WriteLine("Dame el RFC del cliente");
                        cliente.Rfc = Console.ReadLine();
                        Clientes.Add(cliente);
                        break;
                    case 2:
                        foreach (clsClientes item in Clientes)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Dame la posicion de la lista");
                        int posicion = Convert.ToInt32(Console.ReadLine());
                        Clientes.RemoveAt(posicion);
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
        public static void EjemploDiccionario()
        {
            try
            {
                //clsRepositorioMemProducto repoMProductos = new clsRepositorioMemProducto();
                clsRepositoryArchivoProductos repoArchProductos = new clsRepositoryArchivoProductos(@"C:\Users\kalilinux\Desktop\developer\NET Core\clases\06libPedidos\Archivos\Productos.txt");
                ctrObtenProductos cProductos = new ctrObtenProductos(repoArchProductos);
                cProductos.ObtenProductos();
                int opcion = 0;

                do
                {
                    Console.WriteLine("Opciones de diccionarios de prooducto");

                    Console.WriteLine();
                    Console.WriteLine("1. Ver la lista de productos");
                    Console.WriteLine("2. Buscar un producto por codigo de barras");
                    Console.WriteLine("3. Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            foreach (recProductos item in cProductos.Productos.Values)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Dame un código de barras");
                            string codigo = Console.ReadLine();
                            recProductos productos;
                            if (cProductos.ObtenProducto(codigo, out productos))
                                Console.WriteLine("El valor encontrado es: " + productos.ToString());
                            else
                                Console.WriteLine("El producto no se encontró");
                            break;
                        default:
                            break;
                    }
                } while (opcion != 0);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }

        }
    }
}
