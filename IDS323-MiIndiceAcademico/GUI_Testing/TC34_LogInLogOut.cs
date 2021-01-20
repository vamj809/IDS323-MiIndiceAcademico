using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace GUI_Testing
{
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

            return true;
        }

        //TipoUsuario = {0 <- "Estudiante", 1 <- "Profesor", 2 <- "Administrador", Else <- "Invitado"} 
        [TestMethod]
        public void TC34_UC01_LogInLogOutAsExistingAdministrador() {
            Assert.IsTrue(LogInLogOut("320001", "1234", 2));
        }
    }
}
