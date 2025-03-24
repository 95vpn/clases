using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsPersonas
    {
        private int _idPersona;
        private string _NombreCompleto;

        public int IdPersona { 
            get => _idPersona; 
            set => _idPersona = value; 
        }
        public string NombreCompleto { 
            get => _NombreCompleto; 
            set => _NombreCompleto = value; 
        }

        public clsPersonas()
        {
            _idPersona = 0;
            _NombreCompleto = String.Empty;
        }
    }
}
