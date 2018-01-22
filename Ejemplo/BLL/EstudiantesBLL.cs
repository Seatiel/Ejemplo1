using Ejemplo.DAL;
using Ejemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ejemplo.BLL
{
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            using (var repositorio = new Repositorio<Estudiantes>())
            {
                try
                {
                    if (Buscar(c => c.EstudianteId == estudiante.EstudianteId) == null)
                    {
                        return repositorio.Guardar(estudiante);
                    }
                    else
                    {
                        return repositorio.Modificar(estudiante);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Mofidicar(Entidades.Estudiantes existente)
        {
            bool modificado = false;
            using (var repositorio = new Repositorio<Entidades.Estudiantes>())
            {
                modificado = repositorio.Modificar(existente);
            }
            return modificado;
        }

        public static bool Eliminar(Entidades.Estudiantes existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Estudiantes>())
            {
                eliminado = repositorio.Eliminar(existente);
            }
            return eliminado;
        }

        public static Entidades.Estudiantes Buscar(Expression<Func<Entidades.Estudiantes, bool>> criterioBusqueda)
        {
            Entidades.Estudiantes Result = null;
            using (var repoitorio = new Repositorio<Entidades.Estudiantes>())
            {
                Result = repoitorio.Buscar(criterioBusqueda);
            }
            return Result;
        }

        public static List<Entidades.Estudiantes> Listar(Expression<Func<Entidades.Estudiantes, bool>> busqueda)
        {
            List<Entidades.Estudiantes> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Estudiantes>())
            {
                try
                {
                    Result = repoitorio.Listar(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }

        public static List<Entidades.Estudiantes> ListarTodo()
        {
            List<Entidades.Estudiantes> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Estudiantes>())
            {
                try
                {
                    Result = repoitorio.ListarTodo().ToList();
                }
                catch { }
                return Result;
            }
        }
    }
}
