using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore
{
    class PageObjectSearchResults
    {
        private IWebDriver driver;
        public PageObjectSearchResults(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        } 

        [FindsBy(How = How.Id, Using = "det_img_94")]
        public IWebElement BtnSelectProduct { get; set; }

        public PageObjectProduto ClickOnProduct()
        {
            BtnSelectProduct.Click();

            return new PageObjectProduto(driver);
        }
    }
}
