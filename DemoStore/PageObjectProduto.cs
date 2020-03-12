using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore
{
    class PageObjectProduto
    {
        private IWebDriver driver;
        public PageObjectProduto(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "dispatch[checkout.add..94]")]
        public IWebElement btnAddToCart { get; set; }

        public void AddToCart()
        {
            btnAddToCart.Submit();

            System.Threading.Thread.Sleep(6000);
        }
    }
}
