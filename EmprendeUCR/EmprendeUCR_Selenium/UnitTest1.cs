using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace ECCI_IS_Lab01_WebApp.Selenium
{
    [TestClass]
    public class Selenium
    {
        IWebDriver driver;

        [TestCleanup]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }
        [TestMethod]
        public async Task PruebaIngresoChrome()
        {
            ///Arrange
            /// Crea el driver de Chrome
            driver = new ChromeDriver();
            /// Pone la pantalla en full screen
            driver.Manage().Window.Maximize();
            ///Act
            /// Se va a la URL de la aplicacion
            driver.Url = "https://localhost:44366/";
            ///Assert
            await Task.Delay(1000);
            var element = driver.FindElement(By.XPath("//a[@href='/Offers']"));
            Assert.AreEqual(element.Text, "OFERTAS");
        }
    }
}
