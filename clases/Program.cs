using _06libPedidos;
using clases;

int opcion = 0;

do
{
    Console.WriteLine("Menu de opciones");
    Console.WriteLine();
    Console.WriteLine("1. Ejemplo de cliente");
    Console.WriteLine("2. Ejemplo de record de productos");
    Console.WriteLine("3. Ejemplo de paso de parametros a un metodo");
    Console.WriteLine("4. Ejemplo de colecciones de clientes");
    Console.WriteLine("5. Ejemplo de diccionarios de productos");
    Console.WriteLine("20. Salid");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            FuncionesPrincipales.EjemploCliente();
            break;
        case 2:
            FuncionesPrincipales.EjemploRecordProducto(); 
            break;
        case 3:
            FuncionesPrincipales.EjemploDesglosaImpuestos(); 
            break;
        case 4:
            FuncionesPrincipales.EjemploColeccionesClientes();
            break;
        case 5:
            FuncionesPrincipales.EjemploDiccionario();
            break;
        default:
            break;
    }
} while (opcion != 20);

