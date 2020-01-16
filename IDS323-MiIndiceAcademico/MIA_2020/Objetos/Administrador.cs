using System;

namespace MIA_2020.Objetos
{
    [Serializable]
    public class Administrador
    {
        public int Usuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}
