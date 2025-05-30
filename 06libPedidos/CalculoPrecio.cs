﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    internal static class CalculoPrecio
    {
        internal static decimal DesglosaImpuestos(decimal precio, recImpuestos Porcentajes, recMontosImpuestos Montos )
        {
            decimal resultado = 0; 
            resultado = precio / (1 + Porcentajes.PorcentajeIva / 100m);
            Montos.MontoIva = Math.Round(resultado + (Porcentajes.PorcentajeIeps / 100m), 2);
            resultado = resultado / (1 + Porcentajes.PorcentajeIeps / 100m);
            
            Montos.MontoIeps = Math.Round(resultado * (Porcentajes.PorcentajeIeps / 100m), 2);
            return Math.Round(resultado, 2);
        }
    }
}
