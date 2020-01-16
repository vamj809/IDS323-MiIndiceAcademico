using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIA_2020.Objetos
{
    public class ItemDeLista
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public ItemDeLista(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    public class ColeccionCompleta
    {
        public List<Estudiante> Estudiantes {
            get; set;
        }
        public List<Profesor> Profesores {
            get; set;
        }
        public List<Administrador> Administradores {
            get; set;
        }
        public List<Asignatura> Asignaturas {
            get; set;
        }
        public List<Calificacion> Calificaciones {
            get; set;
        }

        private GestorDeObjetos GDO;

        //Recarga todo.
        //Si lo redefines, el carga todo de nuevo. Es decir, si:
        //ColeccionCompleta [nombre_objeto] = /.../
        //Entonces lo recargas si pones:
        //[nombre_objeto] = new ColeccionCompleta();
        public ColeccionCompleta()
        {
            GDO = new GestorDeObjetos();
            Estudiantes = GDO.CargarEstudiantes();
            Profesores = GDO.CargarProfesores();
            Administradores = GDO.CargarAdministradores();
            Asignaturas = GDO.CargarAsignaturas();
            Calificaciones = GDO.CargarCalificaciones();
        }
        public void GuardarEstudiantes()
        {
            GDO.Guardar(Estudiantes);
        }
        public void GuardarProfesores()
        {
            GDO.Guardar(Profesores);
        }
        public void GuardarAsignaturas()
        {
            GDO.Guardar(Asignaturas);
        }
        public void GuardarAdministradores()
        {
            GDO.Guardar(Administradores);
        }
        public void GuardarCalificaciones()
        {
            GDO.Guardar(Calificaciones);
        }
        ////////////////////////////////////////
        public void RecargarEstudiantes()
        {
            Estudiantes = GDO.CargarEstudiantes();
        }
        public void RecargarProfesores()
        {
            Profesores = GDO.CargarProfesores();
        }
        public void RecargarAdministradores()
        {
            Administradores = GDO.CargarAdministradores();
        }
        public void RecargarAsignaturas()
        {
            Asignaturas = GDO.CargarAsignaturas();
        }

        public void RecargarCalificaciones()
        {
            Calificaciones = GDO.CargarCalificaciones();
        }
    }
}
