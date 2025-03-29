using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsRepositoryArchivoProductos : intRepositorioProductos
    {

        public  string NombreArchivo { get; set; }

        public clsRepositoryArchivoProductos(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
        }
        public Dictionary<string, recProductos> ObtenTodos()
        {
            try
            {
                TextReader txtReader;
                string linea;
                Dictionary<string, recProductos> Productos = new Dictionary<string, recProductos>();
                if (File.Exists(NombreArchivo))
                {
                    using (txtReader = new StringReader(NombreArchivo))
                    {
                        do
                        {
                            linea = txtReader.ReadLine();
                            if (linea != null)
                            {
                                string[] campos = linea.Split(',');
                                Productos.Add(campos[2], new recProductos(
                                    Convert.ToInt32(campos[0]), campos[1], campos[2]));
                            }
                        } while (linea != null);
                        txtReader.Close();
                    }
                }
                return Productos;
            }
            catch (Exception e)
            {
                throw e;
            }
            
           
        }
    }
}
