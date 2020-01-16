using System;

namespace MIA_2020.Objetos
{
    [Serializable]
    public class Asignatura
    {
        public string Clave_Materia { get; set; }
        public string Nombre_Asignatura { get; set; }
        public int ID_Profesor { get; set; }
        public int Credito { get; set; }
    }
}
