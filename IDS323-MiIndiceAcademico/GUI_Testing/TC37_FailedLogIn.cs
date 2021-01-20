using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;

namespace GUI_Testing
{
    [TestClass]
    public class TC37_FailedLogIn : TestSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup() {
            TearDown();
        }

        public bool FailedLogIn(string User, string Passwd, int TipoUsuario = 0) {
            try {
                if (LogIn(User, Passwd, TipoUsuario) == false) {
                    return false;
                }
                
                GetElement("OK", true).Click();

                //Clear Contents in Login.
                GetElement("UserTextBox").Clear();
                GetElement("PasswordTextBox").Clear();
            }
            catch(Exception e) {
                Console.Error.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        //TipoUsuario = {0 <- "Estudiante", 1 <- "Profesor", 2 <- "Administrador", Else <- "Invitado"} 
        [TestMethod]
        public void TC37_UC01_TryLogInAsNonExistingAdministrador() {
            Assert.IsTrue(FailedLogIn("329999", "000000", 2));
        }
        [TestMethod]
        public void TC37_UC02_TryLogInAsNonExistingProfesor() {
            Assert.IsTrue(FailedLogIn("229999", "000000", 1));
        }
        [TestMethod]
        public void TC37_UC03_TryLogInAsNonExistingEstudiante() {
            Assert.IsTrue(FailedLogIn("1299999", "000000", 0));
        }
    }
}
