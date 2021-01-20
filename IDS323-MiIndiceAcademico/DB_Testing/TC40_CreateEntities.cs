using MIA_2020.Objetos;
using NUnit.Framework;
using System.Linq;

namespace DB_Testing
{
    public class Tests
    {
        private ColeccionCompleta CC;

        [SetUp]
        public void Setup() {
            CC = new ColeccionCompleta();
        }

        /* ------------------- Estudiante ------------------- */
        public Estudiante CrearEstudiante(string nombre, string carrera, string clave) {
            string new_id;

            if (CC.Estudiantes.Count() < 1) {
                new_id = 1201001.ToString();
            }
            else {
                new_id = (CC.Estudiantes.Max(x => x.ID_Estudiante) + 1).ToString();
            }

            return new Estudiante() {
                ID_Estudiante = int.Parse(new_id),
                Nombre_Estudiante = nombre,
                Carrera_Estudiante = carrera,
                Clave_Estudiante = clave
            };
        }

        [Test]
        public void TC40_UC01_CrearEstudiante() {
            Estudiante EntradaEstudiante = CrearEstudiante("Mr. Prueba TC40", "SQA", "1aF1#@1957");

            CC.Estudiantes.Add(EntradaEstudiante);
            CC.GuardarEstudiantes();
            // ----------------------------------------- Ahora a buscar en los datos.
            var NuevaColeccion = new ColeccionCompleta();
            NuevaColeccion.RecargarEstudiantes();

            Estudiante SalidaEstudiante = NuevaColeccion.Estudiantes.Where(x => x.ID_Estudiante == EntradaEstudiante.ID_Estudiante)?.First();

            //Primero, valida si se guardó; luego compara la consistencia en los datos.
            if (SalidaEstudiante == null || 
                    EntradaEstudiante.ID_Estudiante         != SalidaEstudiante.ID_Estudiante ||
                    EntradaEstudiante.Nombre_Estudiante     != SalidaEstudiante.Nombre_Estudiante ||
                    EntradaEstudiante.Carrera_Estudiante    != SalidaEstudiante.Carrera_Estudiante ||
                    EntradaEstudiante.Clave_Estudiante      != SalidaEstudiante.Clave_Estudiante) { 
                Assert.Fail(); 
            }
            Assert.Pass();
        }

        /* ------------------- Profesor ------------------- */

        public Profesor CrearProfesor(string nombre, string clave) {
            string new_id;

            if (CC.Profesores.Count() < 1) {
                new_id = 220001.ToString();
            }
            else {
                new_id = (CC.Profesores.Max(x => x.ID_Profesor) + 1).ToString();
            }

            return new Profesor() {
                ID_Profesor = int.Parse(new_id),
                Nombre_Profesor = nombre,
                Clave_Profesor = clave
            };
        }

        [Test]
        public void TC40_UC02_CrearProfesor() {
            Profesor EntradaProfesor = CrearProfesor("El Profe TC40_UC02", "Acz9dm@2324.net");

            CC.Profesores.Add(EntradaProfesor);
            CC.GuardarProfesores();
            // ----------------------------------------- Ahora a buscar en los datos.
            var NuevaColeccion = new ColeccionCompleta();
            NuevaColeccion.RecargarProfesores();

            Profesor SalidaProfesor = NuevaColeccion.Profesores.Where(x => x.ID_Profesor == EntradaProfesor.ID_Profesor)?.First();

            //Primero, valida si se guardó; luego compara la consistencia en los datos.
            if (SalidaProfesor == null ||
                    EntradaProfesor.ID_Profesor     != SalidaProfesor.ID_Profesor ||
                    EntradaProfesor.Nombre_Profesor != SalidaProfesor.Nombre_Profesor ||
                    EntradaProfesor.Clave_Profesor  != SalidaProfesor.Clave_Profesor) {
                Assert.Fail();
            }
            Assert.Pass();
        }
    }
}