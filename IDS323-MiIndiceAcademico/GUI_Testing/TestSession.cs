using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace GUI_Testing
{
    public class TestSession
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string TestApp = @"C:\Users\vamj809\Source\Repos\IDS323-MiIndiceAcademico\IDS323-MiIndiceAcademico\MIA_2020\bin\Debug\MIA_2020.exe";

        protected static WindowsDriver<WindowsElement> session;
        public static WindowsDriver<WindowsElement> desktopSession;

        public static void Setup(TestContext context)
        {
            if (session == null) {
                // Create a new session to bring up the test application
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", TestApp);
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                options.AddAdditionalCapability("platformName", "Windows");

                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
                Assert.IsNotNull(session);
                Assert.IsNotNull(session.SessionId);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);

                AppiumOptions optionsDesktop = new AppiumOptions();
                optionsDesktop.AddAdditionalCapability("app", "Root");
                optionsDesktop.AddAdditionalCapability("deviceName", "WindowsPC");
                optionsDesktop.AddAdditionalCapability("ms:experimental-webdriver", true);
                desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), optionsDesktop);

            }
        }

        public static void TearDown()
        {
            if (session != null) {
                session.Quit();
                session = null;
            }

            if (desktopSession != null) {
                desktopSession.Quit();
                desktopSession = null;
            }
        }

        public WindowsElement GetElement(string AccesibilityId)
        {
            WindowsElement Elemento = null;

            for (int i = 0; i < 100; i++) {
                try {
                    if (Elemento != null)
                        break;
                    Elemento = desktopSession.FindElementByAccessibilityId(AccesibilityId);
                    System.Threading.Thread.Sleep(100);
                }
                catch { }
            }
            return Elemento;
        }

        //TipoUsuario = {0 <- "Estudiante", 1 <- "Profesor", 2 <- "Administrador", Else <- "Invitado"} 
        public bool LogIn(string User, string Passwd, int TipoUsuario = 0)
        {
            string UserRole;

            //Click on TipoUsuario ... SI es un Profesor o Administrador, hace clic y lo marca como tal.
            if (TipoUsuario == 0) {
                UserRole = "StudentsButton";
            } else if (TipoUsuario == 1) {
                UserRole = "TeachersButton";
            } else if (TipoUsuario == 2) {
                UserRole = "AdminsButton";
            } else {
                UserRole = "GuestsButton";
            }

            var winElem_LogIn_TipoCuenta = GetElement(UserRole);

            if (winElem_LogIn_TipoCuenta != null) {
                winElem_LogIn_TipoCuenta.Click();
            }
            else {
                return false;
            }

            if(TipoUsuario == 0 || TipoUsuario == 1 || TipoUsuario == 2) { 
                //Click on username
                var winElem_LogIn_UserName = GetElement("UserTextBox");

                if (winElem_LogIn_UserName != null) {
                    winElem_LogIn_UserName.Click();
                }
                else {
                    return false;
                }

                //Type username
                System.Threading.Thread.Sleep(100);
                winElem_LogIn_UserName.SendKeys(User);

                //Click on password
                var winElem_LogIn_Passwd = GetElement("PasswordTextBox");

                if (winElem_LogIn_Passwd != null) {
                    winElem_LogIn_Passwd.Click();
                }
                else {
                    return false;
                }

                //Type password
                System.Threading.Thread.Sleep(100);
                winElem_LogIn_Passwd.SendKeys(Passwd);
            }

            //Click on LogIn
            var winElem_LogIn_btnLogIn = GetElement("OkButton");

            if (winElem_LogIn_btnLogIn != null) {
                winElem_LogIn_btnLogIn.Click();
            }
            else {
                return false;
            }

            return true;
        }
    }
}
