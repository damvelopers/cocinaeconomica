using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAlimentos
{
    class Proveedor
    {
        private int Id;
        private string Nombre;
        private string InformacionContacto;

        public Proveedor()
        {
            this.Nombre = "";
        }

        public Proveedor(string nombre, string informacionContacto)
        {
            this.Nombre = nombre;
        }


    }
}
