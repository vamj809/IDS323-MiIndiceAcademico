using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;

namespace GUI_Testing
{
    [TestClass]
    public class TC31_MoveWindow : TestSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        public bool OpcionesMenu(string User, string Passwd, int TipoUsuario = 0) { 
            if (LogIn(User, Passwd, TipoUsuario) == false) {
                return false;
            }

            return true;
        }

        //TipoUsuario = {0 <- "Estudiante", 1 <- "Profesor", 2 <- "Administrador", Else <- "Invitado"} 
        [TestMethod]
        public void BU_001_RealTest()
        {
            Assert.IsTrue(OpcionesMenu("320001", "1234", 2));
        }
    }
}
