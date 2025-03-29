using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class ctrObtenProductos
    {
        private intRepositorioProductos repoProductos;

        public Dictionary<string, recProductos> Productos { get; set; }

        public ctrObtenProductos(intRepositorioProductos pRepoProductos)
        {
            repoProductos = pRepoProductos;
            Productos = new Dictionary<string, recProductos>();
        }

        public void ObtenProductos()
        {
            Productos.Clear();
            Productos = repoProductos.ObtenTodos();
        }

        public bool  ObtenProducto(string codigoBarras, out recProductos producto)
        {
            return Productos.TryGetValue(codigoBarras, out producto);
        }
    }
}
