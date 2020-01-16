using System;

namespace MIA_2020.Objetos
{
    [Serializable]
    public class Estudiante
    {
        public int ID_Estudiante { get; set; }
        public string Nombre_Estudiante { get; set; }
        public string Carrera_Estudiante { get; set; }
        public string Clave_Estudiante { get; set; }
        public System.Collections.Generic.List<Asignatura> Asignaturas { get; set; }
    }
}
