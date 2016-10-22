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
            this.Id = -1;
            this.Nombre = "";
            this.InformacionContacto = "";
        }

        public Proveedor(int Id, string Nombre, string InformacionContacto)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.InformacionContacto = InformacionContacto;
        }
    }
}