using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
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

        public bool CanMove()
        {
            var MyTitleBar = GetElement("Login").FindElementByAccessibilityId("TitleBar");
            var OriginalLocation = MyTitleBar.Location;

            System.Threading.Thread.Sleep(1000);

            Actions MoveIt = new Actions(desktopSession);
            MoveIt.DragAndDropToOffset(MyTitleBar, 100, 100);
            MoveIt.Perform();

            System.Threading.Thread.Sleep(400);

            if (OriginalLocation == GetElement("Login").FindElementByAccessibilityId("TitleBar").Location) {
                return false;
            }

            return true;
        }

        //TipoUsuario = {0 <- "Estudiante", 1 <- "Profesor", 2 <- "Administrador", Else <- "Invitado"} 
        [TestMethod]
        public void TC31_UC01_MoveWindow()
        {
            Assert.IsTrue(CanMove());//OpcionesMenu("320001", "1234", 2));
        }
    }
}
