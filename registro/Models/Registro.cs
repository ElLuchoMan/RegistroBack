using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace registro.Models
{
    public class Registro
    {
        public int id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
        [Required]
        public int Documento { get; set; }
        [Required]
        public int Telefono { get; set; }

    }
}
