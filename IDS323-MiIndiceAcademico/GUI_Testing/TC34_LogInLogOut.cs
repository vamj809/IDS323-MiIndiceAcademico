using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace GUI_Testing
{
    [TestClass]
    public class TC34_LogInLogOut : TestSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup() {
            TearDown();
        }

        public bool LogInLogOut(string User, string Passwd, int TipoUsuario = 0) {
            if (LogIn(User, Passwd, TipoUsuario) == false) {
                return false;
            }
            //Si llega a este punto, se asume que se abrió la pantalla del menú.
            var CerrarSesion = GetElement("LogOffButton");
            CerrarSesion.Click();

            //Se hace click en un lugar aleatorio de la pantalla de inicio de sesión para asegurar que volvió a esta pantalla.
            var AseguraLogIn = GetElement("Login");
            AseguraLogIn.Click();
            return true;
        }

        //TipoUsuario = {0 <- "Estudiante", 1 <- "Profesor", 2 <- "Administrador", Else <- "Invitado"} 
        [TestMethod]
        public void TC34_UC01_LogInLogOutAsExistingAdministrador() {
            Assert.IsTrue(LogInLogOut("320001", "1234", 2));
        }
    }
}
