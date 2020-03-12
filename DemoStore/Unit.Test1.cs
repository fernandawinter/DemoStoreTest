using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace DemoStore
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [TestMethod]
        public void CompraDeProdutosDemoStore()
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Url = "http://demo.cs-cart.com/stores/ddf977de9b778cd2/";

            PageObjectHeader pageObjectHeader = new PageObjectHeader(driver);

            PageObjectSearchResults pageObjectSearchResults = pageObjectHeader.Search("Batman");

            PageObjectProduto pageObjectProduct = pageObjectSearchResults.ClickOnProduct();

            pageObjectProduct.AddToCart();

            pageObjectSearchResults = pageObjectHeader.Search("PS2");

            pageObjectHeader.ClicksOnCart();

            pageObjectHeader.ClicksOnCheckout();
        }
    }
}
