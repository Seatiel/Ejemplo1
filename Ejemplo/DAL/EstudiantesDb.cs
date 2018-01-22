using Ejemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Ejemplo.DAL
{
    public class EstudiantesDb : DbContext 
    {
        public EstudiantesDb() : base("ConStr")
        {

        }

        public DbSet<Estudiantes> Estudiante { get; set; }

    }
}
