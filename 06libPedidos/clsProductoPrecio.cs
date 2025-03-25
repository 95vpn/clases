﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsProductoPrecio : clsProductos
    {
        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PorcentajeIva {  get; set; }
        public decimal PorcentajeIeps { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $"Precio publico {PrecioPublico.ToString("C")}" +
                $"Precio mayoreo: {PrecioMayoreo.ToString("C")}" +
                $"Porcentaje Iva: {PorcentajeIva.ToString()}" +
                $"Porcentaje Ieps: {PorcentajeIeps.ToString()}";
        }

        public decimal DesglosaImpuestos(out decimal MontoIva, out decimal MontoIeps)
        {
            decimal resultado = 0;

            resultado = CalculoPrecio.DesglosaImpuestos(PrecioPublico, PorcentajeIva, PorcentajeIeps, out MontoIva, out MontoIeps);
            return resultado;
        }

    }
}
