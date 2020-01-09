using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiIndiceAcademico_F1.Objetos
{
    class Calificacion
    {
        public int ID_Estudiante { get; set; }
        public int ID_Profesor { get; set; }
        public string Clave_Materia { get; set; }

        public int Nota { get; set; }
    }
}
