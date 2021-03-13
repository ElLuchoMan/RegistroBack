using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registro.Models
{
    public class Registro
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string TipoDocumento { get; set; }
        public int Documento { get; set; }
        public int Telefono { get; set; }

    }
}
