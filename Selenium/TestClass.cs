// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.BaseClass;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            //registrar Proyecto
            driver.FindElement(By.XPath("//*[@id='navbarNav']/ul/li[4]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div/main/div/div/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[1]/input")).SendKeys("Prueba con Selenium");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[2]/input")).SendKeys("Prueba con Selenium");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[3]/input")).Click();
            Thread.Sleep(5000);
        }
    }
}
