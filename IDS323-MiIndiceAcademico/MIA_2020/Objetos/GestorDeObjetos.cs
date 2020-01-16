using System;
using System.Collections.Generic;
using System.IO;

namespace MIA_2020.Objetos
{
    class GestorDeObjetos
    {
        /// <summary>
        /// RUTA DE LA INFORMACION A GUARDAR
        /// </summary>
        private string RutaEstudiantes = "Estudiantes.bin";
        private string RutaProfesores = "Profesores.bin";
        private string RutaAdministradores = "Administradores.bin";
        private string RutaAsignaturas = "Asignaturas.bin";
        private string RutaCalificaciones = "Calificaciones.bin";
        
        /// <summary>
        /// METODOS PARA CARGAR LAS LISTAS
        /// </summary>
        /// <returns> DEVUELVE LISTA DEL TIPO DE CADA OBJETO </returns>
        public List<Estudiante> CargarEstudiantes()
        {
            var lista = ReadFromBinaryFile<List<Estudiante>>(RutaEstudiantes);
            if(lista == null) {
                return new List<Estudiante>();
            }
            return lista;
        }
        public List<Profesor> CargarProfesores()
        {
            var lista = ReadFromBinaryFile<List<Profesor>>(RutaProfesores);
            if (lista == null) {
                return new List<Profesor>();
            }
            return lista;
        }
        public List<Administrador> CargarAdministradores()
        {
            var lista = ReadFromBinaryFile<List<Administrador>>(RutaAdministradores);
            if (lista == null) {
                return new List<Administrador>();
            }
            return lista;
        }
        public List<Asignatura> CargarAsignaturas()
        {
            var lista = ReadFromBinaryFile<List<Asignatura>>(RutaAsignaturas);
            if (lista == null) {
                return new List<Asignatura>();
            }
            return lista;
        }
        public List<Calificacion> CargarCalificaciones()
        {
            var lista = ReadFromBinaryFile<List<Calificacion>>(RutaCalificaciones);
            if (lista == null) {
                return new List<Calificacion>();
            }
            return lista;
        }
        /// <summary>
        /// METODOS PARA GUARDAR LOS CAMBIOS
        /// </summary>
        public void Guardar(List<Estudiante> lista)
        {
            WriteToBinaryFile(RutaEstudiantes, lista);
        }
        public void Guardar(List<Profesor> lista)
        {
            WriteToBinaryFile(RutaProfesores, lista);
        }
        public void Guardar(List<Administrador> lista)
        {
            WriteToBinaryFile(RutaAdministradores, lista);
        }
        public void Guardar(List<Asignatura> lista)
        {
            WriteToBinaryFile(RutaAsignaturas, lista);
        }
        public void Guardar(List<Calificacion> lista)
        {
            WriteToBinaryFile(RutaCalificaciones, lista);
        }

        /// <summary>
        /// El tipo de objeto (y aquellos que lo hereden) deben ser decorados con el atributo [Serializable].
        /// </summary>
        /// <typeparam name="T">El tipo de objeto que se escribirá en el archivo BIN.</typeparam>
        /// <param name="filePath">La ruta donde se guardará el archivo con la instancia del objeto.</param>
        /// <param name="objectToWrite">La instancia del objeto.</param>
        /// <param name="append">Si es falso, el archivo se sobreescribirá si ya existe. 
        ///                     Si es verdadero, el objeto se adjuntará al final del archivo.</param>
        private static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Lee el archivo binario
        /// </summary>
        /// <typeparam name="T">El tipo de objeto que se escribirá en el archivo BIN.</typeparam>
        /// <param name="filePath">La ruta donde se guardará el archivo con la instancia del objeto.</param>
        /// <returns> Devuelve la instancia de un objeto de un archivo binario.</returns>
        private static T ReadFromBinaryFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                if (stream.Length < 1) {
                    return default(T);
                }
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
