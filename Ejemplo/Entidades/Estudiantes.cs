using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Ejemplo.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }

        public string Nombres { get; set; }

        public string Matricula { get; set; }

        public string Telefono { get; set; }
    }
}
