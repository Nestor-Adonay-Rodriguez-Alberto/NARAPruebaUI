using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NARAPruebaUI
{
    public class Guia5Test
    {
        private IWebDriver driver;

        public Guia5Test()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void Crear_Producto()
        {
            // Navega a Google
            driver.Navigate().GoToUrl("https://localhost:7250/ProductNARA/Create");
            // Realiza alguna acción en la página, por ejemplo, verificar el título de la página
            Assert.Equal("Create - UI_MVC", driver.Title);
        }

        public void Dispose()
        {
            // Cierra el navegador
            driver.Quit();
        }
    }
}
