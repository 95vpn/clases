﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsRepositorioMemProducto : intRepositorioProductos
    {
        public Dictionary<string, recProductos> ObtenTodos()
        {
            Dictionary<string, recProductos> Productos = new Dictionary<string, recProductos>();
            Productos.Add("00001", new recProductos(1, "REF MANZANA 600 ML", "00001"));
            Productos.Add("00002", new recProductos(2, "DET COLOR 1 KG", "00002"));
            Productos.Add("00003", new recProductos(3, "LATA ATUN X 300KG", "00003"));
            Productos.Add("00004", new recProductos(4, "CREMA SOL 1LT", "00004"));
            Productos.Add("00005", new recProductos(5, "REF NARANJA 1 L", "00005"));
            Productos.Add("00006", new recProductos(5, "ARROZ Z 1KG", "00006"));
            Productos.Add("00007", new recProductos(6, "PALETA MIA 20 G", "00007"));
            Productos.Add("00008", new recProductos(7, "REF MANZANA 600 ML", "00008"));
            return Productos;
        }
    }
}
