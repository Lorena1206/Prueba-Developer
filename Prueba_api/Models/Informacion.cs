using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Api.Models
{
    public class Informacion
    {
        public int id { get; set; }
        [Required]
        public string Usuario { get; set; }
        public string Fecha_creacion { get; set; }
        public string Fecha_actualizacion { get; set; }
        public string Estatus { get; set; } 
    }
}
