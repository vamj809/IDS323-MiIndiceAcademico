using System;

namespace MIA_2020.Objetos
{
    [Serializable]
    public class Calificacion
    {
        public int ID_Estudiante { get; set; }
        public string Clave_Materia { get; set; }
        public int Nota { get; set; }
    }
}
