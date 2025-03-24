using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsProductos
    {
        public int idProducto {  get; set; }
        public string Description { get; set; }
        public string CodigoBarras { get; set; }

        public override string ToString()
        {
            return $"idProducto:  { idProducto.ToString()} " + 
                $"Description: {Description}" +
                $"Codigo Barras: {CodigoBarras}";
        }
    }
}
