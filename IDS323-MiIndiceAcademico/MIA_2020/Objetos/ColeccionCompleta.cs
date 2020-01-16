using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIA_2020.Objetos
{
    class ColeccionCompleta
    {
        public List<Estudiante> Estudiantes {
            get; set;
        }
        public List<Profesor> Profesores {
            get; set;
        }
        public List<Asignatura> Asignaturas {
            get; set;
        }
        public List<Calificacion> Calificaciones {
            get; set;
        }
        private GestorDeObjetos GDO;
        public ColeccionCompleta()
        {
            GDO = new GestorDeObjetos();
            Estudiantes = GDO.CargarEstudiantes();
            Profesores = GDO.CargarProfesores();
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
        public void GuardarCalificaciones()
        {
            GDO.Guardar(Calificaciones);
        }
    }
}
